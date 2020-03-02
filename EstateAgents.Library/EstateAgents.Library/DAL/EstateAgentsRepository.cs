using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgents.Library.DAL
{
    /// <summary>
    /// Repository - For all database interactions
    /// </summary>
    public class EstateAgentsRepository
    {
        #region Client

        /// <summary>
        /// Client - Create a client
        /// </summary>
        /// <param name="client"></param>
        public static void CreateClient(Client client)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.Client.Add(client);
                db.SaveChanges();
            }
        }

        public static void UpdateClient(Client client)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.Client.Attach(client);
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Client - Get client fullname by user id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static string GetClientNameByUserId(Guid UserId)
        {
            string FullName = "";

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                Client client = db.Client.Where(c => c.UserId == UserId).FirstOrDefault();
                string Forename = client.Forename;
                string Surname = client.Surname;
                FullName = Forename + " " + Surname;
            }

            return FullName;
        }

        /// <summary>
        /// Client - Get client by user id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static Client GetClientByUserId(Guid UserId)
        {
            Client client = new Client();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                client = db.Client.Where(c => c.UserId == UserId).FirstOrDefault();
            }

            return client;
        }


        /// <summary>
        /// Client - Get client by client id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static Client GetClientByClientId(int ClientId)
        {
            Client client = new Client();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                client = db.Client.Where(c => c.Id == ClientId).FirstOrDefault();
            }

            return client;
        }

        #endregion

        #region Employee

        public static Employee GetEmployeeByUserId(Guid UserId)
        {
            Employee employee = new Employee();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                employee = db.Employee.Where(c => c.UserId == UserId).FirstOrDefault();
            }

            return employee;
        }

        #endregion

        #region Property

        /// <summary>
        /// Property - Get 3 properties
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static List<Property> GetTop3Properties()
        {
            List<Property> properties = new List<Property>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                properties = db.Property.Take(3).ToList();
            }

            return properties;
        }

        public static List<Property> GetAllProperties()
        {
            List<Property> properties = new List<Property>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                properties = db.Property.ToList();
            }

            return properties;
        }

        public static List<Property> GetPropertyListSavedByClientId(int ClientId)
        {
            List<Property> properties = new List<Property>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                List<PropertySaved> psList = db.PropertySaved.Where(p => p.ClientId == ClientId && p.Saved == true).ToList();
                
                foreach(var item in psList)
                {
                    Property p = GetPropertyByPropertyId(item.PropertyId);
                    properties.Add(p);
                }

            }

            return properties;
        }

        public static List<Property> GetPropertyListBySearchCriteria(string IncludeSoldProperties, string Location, int NumberOfBedrooms, decimal PriceFrom, decimal PriceTo, string PropertySaleType, string PropertyType)
        {
            int PropertyStatus = 0;
            if(IncludeSoldProperties == "No")
            {
                PropertyStatus = 3;
            }

            List<Property> properties = new List<Property>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                string PropertySaleTypeDescription = db.PropertySaleType.Where(i => i.Description == PropertySaleType).FirstOrDefault().Description;
                string PropertyTypeDescription = db.PropertyType.Where(i => i.Description == PropertyType).FirstOrDefault().Description;

                properties = db.Property.Where(p =>
                    p.PropertyStatusId != PropertyStatus &&
                    (p.AddressLine1 == Location || p.AddressLine2 == Location || p.AddressLine3 == Location || p.AddressLine4 == Location || p.AddressLine5 == Location) &&
                    p.NumberOfBedrooms == NumberOfBedrooms &&
                    (p.PropertyPrice >= PriceFrom && p.PropertyPrice <= PriceTo) &&
                    PropertySaleTypeDescription == PropertySaleType &&
                    PropertyTypeDescription == PropertyType &&
                    p.ClosedDate == null
                    ).ToList();

            }

            return properties;
        }

        

        /// <summary>
        /// Property - Get property by property id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static Property GetPropertyByPropertyId(int Id)
        {
            Property property = new Property();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                property = db.Property.Where(p => p.Id == Id).FirstOrDefault();
            }

            return property;
        }

        #endregion

        #region PropertyType

        

        /// <summary>
        /// Property Type - 
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static string GetPropertyTypeDescriptionByPropertyTypeId(int Id)
        {
            string returnValue = "";

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                returnValue = db.PropertyType.Where(p => p.Id == Id).FirstOrDefault().Description;
            }

            return returnValue;
        }

        #endregion

        #region Property Images

        /// <summary>
        /// Property Images - Create a property image
        /// </summary>
        /// <param name="client"></param>
        public static void CreatePropertyImage(PropertyImages image)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.PropertyImages.Add(image);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Property Images - Get property images list by property id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static List<PropertyImages> GetPropertyImagesByPropertyId(int PropertyId)
        {
            List<PropertyImages> iList = new List<PropertyImages>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                iList = db.PropertyImages.Where(p => p.PropertyId == PropertyId).ToList();
            }

            return iList;
        }

        #endregion

        #region Property Saved

        public static void CreatePropertySaved(PropertySaved propertySaved)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.PropertySaved.Add(propertySaved);
                db.SaveChanges();
            }
        }

        public static void UpdatePropertySaved(PropertySaved propertySaved)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.PropertySaved.Attach(propertySaved);
                db.Entry(propertySaved).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static PropertySaved GetPropertySavedByClientIdAndPropertyId(int ClientId, int PropertyId)
        {
            PropertySaved ps = new PropertySaved();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                ps = db.PropertySaved.Where(p => p.ClientId == ClientId && p.PropertyId == PropertyId).FirstOrDefault();
            }

            return ps;
        }

        public static bool CheckIfPropertyIsSavedForClient(int ClientId, int PropertyId)
        {
            bool returnValue = false;
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                PropertySaved PropertySaved = db.PropertySaved.Where(p => p.ClientId == ClientId && p.PropertyId == PropertyId).FirstOrDefault();
                if(PropertySaved == null)
                {
                    return returnValue;
                }
                else
                {
                    returnValue = PropertySaved.Saved;
                }
            }

            return returnValue;
        }

        #endregion

        #region Property Viewings

        public static void CreatePropertyViewing(PropertyViewings propertyViewings)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.PropertyViewings.Add(propertyViewings);
                db.SaveChanges();
            }
        }

        public static void UpdatePropertyViewing(PropertyViewings propertyViewings)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.PropertyViewings.Attach(propertyViewings);
                db.Entry(propertyViewings).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static List<PropertyViewings> GetPropertyViewingsByClientId(int ClientId)
        {
            List<PropertyViewings> viewings = new List<PropertyViewings>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                viewings = db.PropertyViewings.Where(p => p.ClientId == ClientId && p.Cancelled == null).ToList();
            }

            return viewings;
        }

        public static PropertyViewings GetPropertyViewingById(int Id)
        {
            PropertyViewings p = new PropertyViewings();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                p = db.PropertyViewings.Where(pv => pv.Id == Id).FirstOrDefault();
            }

            return p;
        }

        #endregion

        #region Property Offers

        public static void CreatePropertyOffer(PropertyOffers propertyOffers)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.PropertyOffers.Add(propertyOffers);
                db.SaveChanges();
            }
        }

        public static void UpdatePropertyOffer(PropertyOffers propertyOffers)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.PropertyOffers.Attach(propertyOffers);
                db.Entry(propertyOffers).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static List<PropertyOffers> GetPropertyOffersByClientId(int ClientId)
        {
            List<PropertyOffers> offers = new List<PropertyOffers>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                offers = db.PropertyOffers.Where(o => o.ClientId == ClientId).ToList();
            }

            return offers;
        }

        public static PropertyOffers GetPropertyOffersById(int Id)
        {
            PropertyOffers offers = new PropertyOffers();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                offers = db.PropertyOffers.Where(p => p.Id == Id).FirstOrDefault();
            }

            return offers;
        }

        #endregion

        #region Property Offers Status

        public static PropertyOfferStatus GetPropertyOffersStatusById(int Id)
        {
            PropertyOfferStatus status = new PropertyOfferStatus();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                status = db.PropertyOfferStatus.Where(p => p.Id == Id).FirstOrDefault();
            }

            return status;
        }

        #endregion

        #region Enquiry

        public static void CreateEnquiry(Enquiry enquiry)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.Enquiry.Add(enquiry);
                db.SaveChanges();
            }
        }

        #endregion

        #region Property Features

        public static List<PropertyFeatures> GetPropertyFeaturesByPropertyId(int PropertyId)
        {
            List<PropertyFeatures> iList = new List<PropertyFeatures>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                iList = db.PropertyFeatures.Where(p => p.PropertyId == PropertyId).ToList();
            }

            return iList;
        }

        #endregion

        #region Chatbot Questions

        public static List<ChatbotQuestions> GetChatbotQuestionsList()
        {
            List<ChatbotQuestions> q = new List<ChatbotQuestions>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                q = db.ChatbotQuestions.ToList();
            }

            return q;
        }

        #endregion

        #region Chatbot Questions Live

        public static void CreateChatbotQuestionsLiveFromRange(List<ChatbotQuestionsLive> chatbotQuestionsLiveList)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.ChatbotQuestionsLive.AddRange(chatbotQuestionsLiveList);
                db.SaveChanges();
            }

        }

        public static void CreateChatbotQuestionsLive(ChatbotQuestionsLive chatbotQuestionsLive)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.ChatbotQuestionsLive.Add(chatbotQuestionsLive);
                db.SaveChanges();
            }
        }

        public static void UpdateChatbotQuestionsLive(ChatbotQuestionsLive qhatbotQuestionsLive)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.ChatbotQuestionsLive.Attach(qhatbotQuestionsLive);
                db.Entry(qhatbotQuestionsLive).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static List<ChatbotQuestionsLive> GetChatbotQuestionsLiveByTemplateIdAndQuestionAsked(int TemplateId)
        {
            List<ChatbotQuestionsLive> qLiveList = new List<ChatbotQuestionsLive>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                qLiveList = db.ChatbotQuestionsLive.Where(c => c.ChatbotTemplateId == TemplateId && c.QuestionAskedDate != null).OrderBy(o => o.Sequence).ToList();
            }

            return qLiveList;
        }

        public static List<ChatbotQuestionsLive> GetChatbotQuestionsLiveCurrentQuestions(int TemplateId)
        {
            List<ChatbotQuestionsLive> qLive = new List<ChatbotQuestionsLive>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                List<ChatbotQuestionsLive> qList = db.ChatbotQuestionsLive.Where(c => c.ChatbotTemplateId == TemplateId && c.QuestionAskedDate != null && c.QuestionAnswer == null).ToList();

                if (qList.Count() > 0)
                {
                    ChatbotQuestionsLive q = qList.First();
                    qLive.Add(q);
                }

            }

            return qLive;
        }

        public static List<ChatbotQuestionsLive> GetChatbotQuestionsLiveNextQuestions(int TemplateId)
        {
            List<ChatbotQuestionsLive> qLive = new List<ChatbotQuestionsLive>();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                List<ChatbotQuestionsLive> qList = db.ChatbotQuestionsLive.Where(c => c.ChatbotTemplateId == TemplateId && c.QuestionAskedDate == null).OrderBy(o => o.Sequence).ToList();

                if (qList.Count() > 0)
                {
                    ChatbotQuestionsLive q = qList.First();
                    qLive.Add(q);
                }
            }

            return qLive;
        }

        #endregion

        #region Chatbot Templates

        public static ChatbotTemplates CreateChatbotTemplate(ChatbotTemplates chatbotTemplates)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.ChatbotTemplates.Add(chatbotTemplates);
                db.SaveChanges();
            }

            return chatbotTemplates;
        }

        public static ChatbotTemplates UpdateChatbotTemplate(ChatbotTemplates userTemplate)
        {
            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                db.ChatbotTemplates.Attach(userTemplate);
                db.Entry(userTemplate).State = EntityState.Modified;
                db.SaveChanges();
            }

            return userTemplate;
        }

        public static ChatbotTemplates GetChatbotTemplateByTemplateId(int TemplateId)
        {
            ChatbotTemplates t = new ChatbotTemplates();

            using (EstateAgencyContext db = new EstateAgencyContext())
            {
                t = db.ChatbotTemplates.Where(c => c.Id == TemplateId).FirstOrDefault();
            }

            return t;
        }

        #endregion

        #region Examples
        //CREATE


        //    return user;
        //}
        //UPDATE
        //public static void UpdateUser(User user)
        //{
        //    using (ChatbotDBContext db = new ChatbotDBContext())
        //    {
        //        db.User.Attach(user);
        //        db.Entry(user).State = EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //}
        //GET
        //public static User GetUserByUserId(int UserId)
        //{
        //    User u = new User();

        //    using (ChatbotDBContext db = new ChatbotDBContext())
        //    {
        //        u = db.User.Where(c => c.Id == UserId).FirstOrDefault();
        //    }

        //    return u;
        //}
        #endregion
    }
}
