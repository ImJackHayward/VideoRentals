namespace FirstApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3c6ec7ad-7f76-449d-9035-2e2efdcbaf4b', N'1@1.com', 0, N'AArTN70Bgx5xpqy4qJptaKMdX7ZfhgJOAogBXRhzaQ6MgweMNJg+3rSrOg7INe4ToA==', N'505bebb7-011c-4f3a-9f05-ce7ac8744759', NULL, 0, 0, NULL, 1, 0, N'1@1.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c2166dcc-dcfb-4fd7-9394-4c31b6715444', N'admin@haywards.com', 0, N'AHSyNC2DF0SxsEJCyc5l0xT6dTro60LoBGyqDpgKgw/9UoCGaPcEdoHTJVfnP2lckQ==', N'7c58f11a-f910-4a52-9cab-15182520dd05', NULL, 0, 0, NULL, 1, 0, N'admin@haywards.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1727dc3e-c1c6-439c-8b9b-360ba07ac83b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c2166dcc-dcfb-4fd7-9394-4c31b6715444', N'1727dc3e-c1c6-439c-8b9b-360ba07ac83b')
");
        }
        
        public override void Down()
        {
        }
    }
}
