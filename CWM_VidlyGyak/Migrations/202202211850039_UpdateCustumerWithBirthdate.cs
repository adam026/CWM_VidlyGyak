namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustumerWithBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Custumers", "Birthdate", c => c.DateTime(nullable: true));
            DropColumn("dbo.Custumers", "SzuletesiEv");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Custumers", "SzuletesiEv", c => c.Int(nullable: true));
            DropColumn("dbo.Custumers", "Birthdate");
        }
    }
}
