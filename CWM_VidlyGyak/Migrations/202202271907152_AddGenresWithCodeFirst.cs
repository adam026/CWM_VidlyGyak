namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenresWithCodeFirst : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Family')");
        }

        public override void Down()
        {
        }
    }
}
