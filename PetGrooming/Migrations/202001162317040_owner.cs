namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owner : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerID = c.String(nullable: false, maxLength: 128),
                        OwnerFName = c.String(),
                        OwnerLname = c.String(),
                        OwnerAddress = c.String(),
                        OwnerPhone = c.String(),
                        OwnerEmail = c.String(),
                    })
                .PrimaryKey(t => t.OwnerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
        }
    }
}
