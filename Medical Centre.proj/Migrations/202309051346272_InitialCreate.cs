namespace Medical_Centre.proj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientDetails",
                c => new
                    {
                        SNumber = c.String(nullable: false, maxLength: 8),
                        Role = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        University = c.Int(nullable: false),
                        Cillness = c.Int(nullable: false),
                        CreatePassword = c.String(),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.SNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientDetails");
        }
    }
}
