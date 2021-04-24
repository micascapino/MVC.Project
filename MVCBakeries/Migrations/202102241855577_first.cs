namespace MVCBakeries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cupcakes", "Bakery_BakeryId", "dbo.Bakeries");
            DropIndex("dbo.Cupcakes", new[] { "Bakery_BakeryId" });
            RenameColumn(table: "dbo.Cupcakes", name: "Bakery_BakeryId", newName: "BakeryId");
            AlterColumn("dbo.Cupcakes", "BakeryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cupcakes", "BakeryId");
            AddForeignKey("dbo.Cupcakes", "BakeryId", "dbo.Bakeries", "BakeryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cupcakes", "BakeryId", "dbo.Bakeries");
            DropIndex("dbo.Cupcakes", new[] { "BakeryId" });
            AlterColumn("dbo.Cupcakes", "BakeryId", c => c.Int());
            RenameColumn(table: "dbo.Cupcakes", name: "BakeryId", newName: "Bakery_BakeryId");
            CreateIndex("dbo.Cupcakes", "Bakery_BakeryId");
            AddForeignKey("dbo.Cupcakes", "Bakery_BakeryId", "dbo.Bakeries", "BakeryId");
        }
    }
}
