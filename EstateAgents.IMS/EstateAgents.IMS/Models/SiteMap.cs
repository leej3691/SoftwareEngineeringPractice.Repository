using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Xml.Linq;

namespace EstateAgents.IMS.Models
{
    public class SiteMap
    {
        public XElement Root { get; set; }
        public List<XElement> Nodes { get; set; }

        public SiteMap()
        {
      
            string siteMap = "~/Sitemaps/default.sitemap";
            
            
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string username = HttpContext.Current.User.Identity.GetUserName();
                string role = EstateAgentsRepository.GetUserRole(username);

                if (role == "Admin")
                {
                    siteMap = "~/Sitemaps/admin.sitemap";
                }
                else if (role == "Employee")
                {
                    siteMap = "~/Sitemaps/employee.sitemap";
                }

            }

            this.Root = XElement.Load(HttpContext.Current.Server.MapPath(siteMap));
   
            this.Nodes = Root.Elements().ToList();
        }
    }
}
