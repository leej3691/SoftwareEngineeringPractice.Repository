namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTestTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.TestTable");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TestTable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
