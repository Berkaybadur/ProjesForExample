namespace Airport.DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expedition", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Ticket", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ticket", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Expedition", "Price");
        }
    }
}
