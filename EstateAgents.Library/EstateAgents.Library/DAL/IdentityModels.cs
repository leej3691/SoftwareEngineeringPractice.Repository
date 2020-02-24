using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EstateAgents.Library.DAL
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    public class EstateAgencyContext : ApplicationDbContext
    {
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeJobTitle> EmployeeJobTitle { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyImages> PropertyImages { get; set; }
        public virtual DbSet<PropertySaleType> PropertySaleType { get; set; }
        public virtual DbSet<PropertySaved> PropertySaved { get; set; }
        public virtual DbSet<PropertyStatus> PropertyStatus { get; set; }
        public virtual DbSet<PropertyType> PropertyType { get; set; }
        public virtual DbSet<PropertyViewings> PropertyViewings { get; set; }
        public virtual DbSet<PropertyFeatures> PropertyFeatures { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<ChatbotQuestions> ChatbotQuestions { get; set; }
        public virtual DbSet<ChatbotQuestionsLive> ChatbotQuestionsLive { get; set; }
        public virtual DbSet<ChatbotQuestionType> ChatbotQuestionType { get; set; }
        public virtual DbSet<ChatbotTemplates> ChatbotTemplates { get; set; }

    }
}