namespace Vidly2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SetNumberOfMoviesAvailableInModel : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }

        public override void Down()
        {
        }
    }
}
