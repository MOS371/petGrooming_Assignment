namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        GroomerID = c.String(nullable: false, maxLength: 128),
                        GroomerFName = c.String(),
                        GroomerLName = c.String(),
                        GroomerDOB = c.DateTime(nullable: false),
                        GroomerPhone = c.String(),
                        GroomerHourRate = c.Int(nullable: false),
                        GroomerExpirence = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}
