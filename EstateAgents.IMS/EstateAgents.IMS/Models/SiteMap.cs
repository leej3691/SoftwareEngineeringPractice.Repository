using System.Collections.Generic;
using System.Linq;
using System.Web;
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

            if(HttpContext.Current.User.Identity.IsAuthenticated)
            {
                siteMap = "~/Sitemaps/user.sitemap";
            }

            this.Root = XElement.Load(HttpContext.Current.Server.MapPath(siteMap));
   
            this.Nodes = Root.Elements().ToList();
        }
    }
}
