namespace MovieRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusersandroles : DbMigration
    {
        public override void Up()
        {
            Sql(@"


INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a2e1f0f6-9a14-4938-b397-a62f12750dab', N'sve2338383', N'22023833', N'codewithafzalahmed@hotmail.com', 0, N'APJB0gCnE3Tcc1xQQPs0S2W8AiWtAEyiPiqnbLHd1fu78I0P+bPzH3466nMv68oC9g==', N'9260639d-6aa5-43ca-b7e0-80b86addbc19', NULL, 0, 0, NULL, 1, 0, N'test@test.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd6e651a2-418b-4df0-a057-969143e68441', N'ApplicationManager')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a2e1f0f6-9a14-4938-b397-a62f12750dab', N'd6e651a2-418b-4df0-a057-969143e68441')


                ");
        }
        
        public override void Down()
        {
        }
    }
}


