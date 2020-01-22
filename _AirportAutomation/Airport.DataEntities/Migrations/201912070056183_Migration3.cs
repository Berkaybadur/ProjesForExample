namespace Airport.DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Personel", "District_DistrictId", "dbo.District");
            DropIndex("dbo.Personel", new[] { "District_DistrictId" });
            RenameColumn(table: "dbo.Personel", name: "District_DistrictId", newName: "DistrictId");
            AlterColumn("dbo.Personel", "DistrictId", c => c.Int(nullable: false));
            CreateIndex("dbo.Personel", "DistrictId");
            AddForeignKey("dbo.Personel", "DistrictId", "dbo.District", "DistrictId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personel", "DistrictId", "dbo.District");
            DropIndex("dbo.Personel", new[] { "DistrictId" });
            AlterColumn("dbo.Personel", "DistrictId", c => c.Int());
            RenameColumn(table: "dbo.Personel", name: "DistrictId", newName: "District_DistrictId");
            CreateIndex("dbo.Personel", "District_DistrictId");
            AddForeignKey("dbo.Personel", "District_DistrictId", "dbo.District", "DistrictId");
        }
    }
}
