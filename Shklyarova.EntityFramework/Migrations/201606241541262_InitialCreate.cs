namespace Shklyarova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SomeText = c.String(),
                        dtEntry = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestEntries");
        }
    }
}
