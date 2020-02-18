using System;
using System.Collections.Generic;
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
