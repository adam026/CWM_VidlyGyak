namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserNameToAppUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "User_Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "User_Name");
        }
    }
}
