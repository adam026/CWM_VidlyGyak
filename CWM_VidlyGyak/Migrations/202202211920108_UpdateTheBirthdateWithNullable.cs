namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTheBirthdateWithNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Custumers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Custumers", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
