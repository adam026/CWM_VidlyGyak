namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesWithCodeFirst : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInstock, GenreId) VALUES (1, 'Dune', '2021-10-21', '2022-02-27', 5, 3)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInstock, GenreId) VALUES (2, 'Death on the Nile', '2022-02-17', '2022-02-27', 11, 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInstock, GenreId) VALUES (3, 'The Great Gatsby', '2013-05-16', '2022-02-27', 33, 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInstock, GenreId) VALUES (4, 'The Hangover', '2009-06-17', '2022-02-27', 4, 5)");

        }

        public override void Down()
        {
        }
    }
}
