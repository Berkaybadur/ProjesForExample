namespace Airport.DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTicket",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        NumberOfSeats = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CustomerName = c.String(nullable: false),
                        ExpeditionId = c.Int(nullable: false),
                        ClassesId = c.Int(nullable: false),
                        AirplaneId = c.Int(nullable: false),
                        AirportsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Airplane", t => t.AirplaneId, cascadeDelete: false)
                .ForeignKey("dbo.Airports", t => t.AirportsId, cascadeDelete: false)
                .ForeignKey("dbo.Classes", t => t.ClassesId, cascadeDelete: false)
                .ForeignKey("dbo.Expedition", t => t.ExpeditionId, cascadeDelete: false)
                .Index(t => t.ExpeditionId)
                .Index(t => t.ClassesId)
                .Index(t => t.AirplaneId)
                .Index(t => t.AirportsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTicket", "ExpeditionId", "dbo.Expedition");
            DropForeignKey("dbo.UserTicket", "ClassesId", "dbo.Classes");
            DropForeignKey("dbo.UserTicket", "AirportsId", "dbo.Airports");
            DropForeignKey("dbo.UserTicket", "AirplaneId", "dbo.Airplane");
            DropIndex("dbo.UserTicket", new[] { "AirportsId" });
            DropIndex("dbo.UserTicket", new[] { "AirplaneId" });
            DropIndex("dbo.UserTicket", new[] { "ClassesId" });
            DropIndex("dbo.UserTicket", new[] { "ExpeditionId" });
            DropTable("dbo.UserTicket");
        }
    }
}
