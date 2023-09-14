namespace Medical_Centre.proj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientDetails", "gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientDetails", "gender");
        }
    }
}
