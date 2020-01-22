namespace Airport.DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ticket", "Classes_ClassesId", "dbo.Classes");
            DropIndex("dbo.Ticket", new[] { "Classes_ClassesId" });
            RenameColumn(table: "dbo.Ticket", name: "Classes_ClassesId", newName: "ClassesId");
            AlterColumn("dbo.Ticket", "ClassesId", c => c.Int(nullable: true));
            CreateIndex("dbo.Ticket", "ClassesId");
            AddForeignKey("dbo.Ticket", "ClassesId", "dbo.Classes", "ClassesId", cascadeDelete: false);
            DropColumn("dbo.Ticket", "ClassId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ticket", "ClassId", c => c.Int(nullable: true));
            DropForeignKey("dbo.Ticket", "ClassesId", "dbo.Classes");
            DropIndex("dbo.Ticket", new[] { "ClassesId" });
            AlterColumn("dbo.Ticket", "ClassesId", c => c.Int());
            RenameColumn(table: "dbo.Ticket", name: "ClassesId", newName: "Classes_ClassesId");
            CreateIndex("dbo.Ticket", "Classes_ClassesId");
            AddForeignKey("dbo.Ticket", "Classes_ClassesId", "dbo.Classes", "ClassesId");
        }
    }
}
