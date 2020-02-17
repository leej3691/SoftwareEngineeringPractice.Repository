﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EstateAgents.Library.DAL
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class EstateAgentsDbContext : IdentityDbContext<ApplicationUser>
    {

        public EstateAgentsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
           
        }

        public static EstateAgentsDbContext Create()
        {
            return new EstateAgentsDbContext();
        }

        //public virtual DbSet<TestTable> TestTable { get; set; }
    }
    
}
