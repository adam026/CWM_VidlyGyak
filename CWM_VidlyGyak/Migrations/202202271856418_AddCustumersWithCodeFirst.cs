namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustumersWithCodeFirst : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Custumers ON");
            Sql("INSERT INTO Custumers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (1, 'Mekk Elek', 1, 2, '1995-03-27')");
            Sql("INSERT INTO Custumers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (2, 'Patta Nóra', 0, 3, '1998-09-29')");
            Sql("INSERT INTO Custumers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (3, 'Para Zita', 1, 4, '2005-03-11')");
            Sql("INSERT INTO Custumers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (4, 'Beviz Elek', 0, 1, '1942-11-20')");

        }

        public override void Down()
        {
        }
    }
}
