namespace Airport.DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassesId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ClassesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Classes");
        }
    }
}
