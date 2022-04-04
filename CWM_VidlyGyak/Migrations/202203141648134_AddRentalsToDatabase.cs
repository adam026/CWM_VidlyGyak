namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalsToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Custumer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Custumers", t => t.Custumer_Id, cascadeDelete: true)
                .Index(t => t.Custumer_Id);
            
            AddColumn("dbo.Movies", "Rental_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Rental_Id");
            AddForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals");
            DropForeignKey("dbo.Rentals", "Custumer_Id", "dbo.Custumers");
            DropIndex("dbo.Rentals", new[] { "Custumer_Id" });
            DropIndex("dbo.Movies", new[] { "Rental_Id" });
            DropColumn("dbo.Movies", "Rental_Id");
            DropTable("dbo.Rentals");
        }
    }
}
