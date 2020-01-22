namespace Airport.DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Country", newName: "Countries");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Countries", newName: "Country");
        }
    }
}
