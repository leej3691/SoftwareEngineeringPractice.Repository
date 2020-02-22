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
