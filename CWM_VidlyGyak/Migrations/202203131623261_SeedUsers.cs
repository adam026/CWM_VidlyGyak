namespace CWM_VidlyGyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7e6b4e80-e2fc-4ab0-a0e3-63d2b13ed440', N'admin@vidly.com', 0, N'APP1jFOdPDjuQBlVMo2MrBzahJ7T5Q2+Mgi9CGd0gkWxMkJxSlfyTZaJyuB9jkyY4g==', N'e3726cb6-7af2-48c8-a75f-0466b8ba0133', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f8ca3a52-c950-4a05-bdfd-b64ab054c3fc', N'guest@gmail.com', 0, N'ACRJZpByN+BBAj6DD0ryBWTM62seZwKfMvXrc8GR69UUU+rj2AMT4LGIcu2ht6USOw==', N'84383e4c-add0-46a6-916f-f683fcd12260', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4a9f92b0-3af6-4e4c-bea9-1138f195c27f', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7e6b4e80-e2fc-4ab0-a0e3-63d2b13ed440', N'4a9f92b0-3af6-4e4c-bea9-1138f195c27f')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
