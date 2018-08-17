namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b791b6c-bece-4703-b79f-f757f12ce454', N'guest@vidly.com', 0, N'AAIXyD9YR+8WxF2aPrmYqa5g4wt+BD9891tVPhRTinwcx8Nw0JLOxV9UirqCPPzG9A==', N'43430169-98c8-4217-b132-c027fd4de0ab', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c3536082-fdcd-4851-ad90-ffb65fb551f7', N'admin@vidly.com', 0, N'AC9aefhPdRh/tRYrlV41mARU9v8mTfRvzq/NT5vRre+mqGHFCgU+JJGgu2iEALeuSw==', N'7de9d2cd-81f4-4568-9e72-01e806fe8198', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ac92375b-59aa-449d-9d29-36238afdc782', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c3536082-fdcd-4851-ad90-ffb65fb551f7', N'ac92375b-59aa-449d-9d29-36238afdc782')

");
        }
        
        public override void Down()
        {
        }
    }
}
