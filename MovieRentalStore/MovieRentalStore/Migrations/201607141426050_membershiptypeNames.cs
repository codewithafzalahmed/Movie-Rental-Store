namespace MovieRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membershiptypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE [MovieRentalStore].[dbo].[MembershipTypes] SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE [MovieRentalStore].[dbo].[MembershipTypes] SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE [MovieRentalStore].[dbo].[MembershipTypes] SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE [MovieRentalStore].[dbo].[MembershipTypes] SET Name = 'Annual' WHERE Id = 4");
        }

        public override void Down()
        {
        }
    }
}
