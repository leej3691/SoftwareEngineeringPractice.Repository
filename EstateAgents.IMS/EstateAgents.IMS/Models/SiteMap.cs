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
            string username = HttpContext.Current.User.Identity.GetUserName();
            
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                //if (HttpContext.Current.User.("Admin"))
                //{
                //    siteMap = "~/Sitemaps/admin.sitemap";
                //}
                //else if (HttpContext.Current.User.IsInRole("Employee"))
                //{
                //    siteMap = "~/Sitemaps/employee.sitemap";
                //}

                siteMap = "~/Sitemaps/employee.sitemap";

            }

            this.Root = XElement.Load(HttpContext.Current.Server.MapPath(siteMap));
   
            this.Nodes = Root.Elements().ToList();
        }
    }
}
