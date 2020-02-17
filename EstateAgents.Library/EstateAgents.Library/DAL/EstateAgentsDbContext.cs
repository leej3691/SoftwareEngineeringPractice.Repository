using System.Data.Entity;

namespace EstateAgents.Library.DAL
{
    public class EstateAgentsDbContext : DbContext
    {

        public EstateAgentsDbContext()
            : base("DefaultConnection")
        {
           
        }

        //public virtual DbSet<TestTable> TestTable { get; set; }
    }
    
}
