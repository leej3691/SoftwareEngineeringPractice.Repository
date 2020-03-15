using EstateAgents.Library.DAL;
using EstateAgents.Library.Helpers;
using EstateAgents.WebPortal.Models;
using EstateAgents.WebPortal.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            return View(model);
        }

        public ActionResult Contact()
        {
            ContactViewModel model = new ContactViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult ContactEnquiry(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                Enquiry e = new Enquiry();
                e.Forename = model.Forename;
                e.Surname = model.Surname;
                e.Email = model.Email;
                e.Mobile = model.Mobile;
                e.EnquiryBody = model.EnquiryBody;

                EstateAgentsRepository.CreateEnquiry(e);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Contact", model);
            }
        }

        public ActionResult ChatbotNew()
        {
            //Create Chatbot Template
            ChatbotTemplates t = EstateAgentsRepository.CreateChatbotTemplate(new ChatbotTemplates { StartedDate = DateTime.Now });

            //Chatbot Questions Live Generation
            List<ChatbotQuestions> qList = EstateAgentsRepository.GetChatbotQuestionsList();
            List<ChatbotQuestionsLive> qLiveList = new List<ChatbotQuestionsLive>();

            qLiveList = qList.Select(x => new ChatbotQuestionsLive()
            {
                ChatbotQuestionTypeId = x.ChatbotQuestionTypeId,
                Description = x.Description,
                ChatbotTemplateId = t.Id,
                Sequence = x.Sequence
            }).ToList();

            EstateAgentsRepository.CreateChatbotQuestionsLiveFromRange(qLiveList);

            //Get next questions to show to the user. Update question date so it becomes visible
            List<ChatbotQuestionsLive> nextQuestions = EstateAgentsRepository.GetChatbotQuestionsLiveNextQuestions(t.Id);

            if (nextQuestions.Count > 1)
            {
                foreach (var item in nextQuestions)
                {
                    item.QuestionAskedDate = DateTime.Today;
                    item.QuestionAskedTime = DateTime.Now.ToShortTimeString();

                    //Update next question with date / time of question
                    EstateAgentsRepository.UpdateChatbotQuestionsLive(item);
                }
            }
            else if (nextQuestions.Count == 1)
            {
                ChatbotQuestionsLive q = nextQuestions.FirstOrDefault();

                q.QuestionAskedDate = DateTime.Today;
                q.QuestionAskedTime = DateTime.Now.ToShortTimeString();

                //Update next question with date / time of question
                EstateAgentsRepository.UpdateChatbotQuestionsLive(q);
            }

            ChatbotViewModel model = new ChatbotViewModel(t.Id); 

            return View("Chatbot", model);
        }

        [HttpPost]
        public ActionResult ChatbotSubmitAnswer(string Answer, int ChatbotTemplateId, ChatbotViewModel model)
        {
            bool AnswerInvalid = false;
            string AnswerInvalidResponse = "";

            //Get current question and update with answers
            List<ChatbotQuestionsLive> currentQuestions = EstateAgentsRepository.GetChatbotQuestionsLiveCurrentQuestions(ChatbotTemplateId);

            ChatbotQuestionsLive q = currentQuestions.FirstOrDefault();

            //Validate Mobile Number - Answer
            if (q.ChatbotQuestionTypeId == 2)
            {
                if (!ValidationHelper.IsMobileNumber(Answer))
                {
                    AnswerInvalid = true;
                    AnswerInvalidResponse = "Hmm, it looks like the mobile number is wrong. Can you please try entering your mobile number again please.";
                }
            }
            //Validate Email - Answer
            if (q.ChatbotQuestionTypeId == 3)
            {
                if (!ValidationHelper.IsEmailAddress(Answer))
                {
                    AnswerInvalid = true;
                    AnswerInvalidResponse = "Hmm, it looks like the email address is wrong. Can you please try entering your email address again please.";
                }
            }

            q.QuestionAnswer = Answer;
            q.QuestionAnswerDate = DateTime.Today;
            q.QuestionAnswerTime = DateTime.Now.ToShortTimeString();

            //Update next question with date / time of question
            EstateAgentsRepository.UpdateChatbotQuestionsLive(q);

            //Answer is Invalid
            if (AnswerInvalid)
            {
                //Create validation entry
                ChatbotQuestionsLive v = new ChatbotQuestionsLive();
                v.ChatbotQuestionTypeId = q.ChatbotQuestionTypeId;
                v.Description = AnswerInvalidResponse;
                v.QuestionAskedDate = DateTime.Now;
                v.QuestionAskedTime = DateTime.Now.ToShortTimeString();
                v.ChatbotTemplateId = q.ChatbotTemplateId;
                v.Sequence = q.Sequence;
                EstateAgentsRepository.CreateChatbotQuestionsLive(v);
            }
            else
            {
                //Get next question and update question date so it becomes visible to the user
                List<ChatbotQuestionsLive> nextQuestions = EstateAgentsRepository.GetChatbotQuestionsLiveNextQuestions(ChatbotTemplateId);

                if (nextQuestions.Count > 1)
                {
                    foreach (var item in nextQuestions)
                    {
                        item.QuestionAskedDate = DateTime.Today;
                        item.QuestionAskedTime = DateTime.Now.ToShortTimeString();

                        //Update next question with date / time of question
                        EstateAgentsRepository.UpdateChatbotQuestionsLive(item);
                    }
                }
                else if (nextQuestions.Count == 1)
                {
                    ChatbotQuestionsLive ql = nextQuestions.FirstOrDefault();

                    ql.QuestionAskedDate = DateTime.Today;
                    ql.QuestionAskedTime = DateTime.Now.ToShortTimeString();

                    //Update next question with date / time of question
                    EstateAgentsRepository.UpdateChatbotQuestionsLive(ql);
                }
            }
            
            ChatbotViewModel vm = new ChatbotViewModel(ChatbotTemplateId);
            return View("Chatbot", vm);
        }

        [HttpPost]
        public ActionResult ChatbotComplete(int ChatbotTemplateId)
        {
            ChatbotTemplates template = EstateAgentsRepository.GetChatbotTemplateByTemplateId(ChatbotTemplateId);
            template.CompletedDate = DateTime.Now;
            EstateAgentsRepository.UpdateChatbotTemplate(template);

            HomeViewModel model = new HomeViewModel();
            return View("Index", model);
        }
    }
}