namespace MVCBakeries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bakeries",
                c => new
                    {
                        BakeryId = c.Int(nullable: false, identity: true),
                        BakeryName = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.BakeryId);
            
            CreateTable(
                "dbo.Cupcakes",
                c => new
                    {
                        CupcakeId = c.Int(nullable: false, identity: true),
                        CupcakeType = c.String(),
                        Description = c.String(),
                        GlutenFree = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bakery_BakeryId = c.Int(),
                    })
                .PrimaryKey(t => t.CupcakeId)
                .ForeignKey("dbo.Bakeries", t => t.Bakery_BakeryId)
                .Index(t => t.Bakery_BakeryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cupcakes", "Bakery_BakeryId", "dbo.Bakeries");
            DropIndex("dbo.Cupcakes", new[] { "Bakery_BakeryId" });
            DropTable("dbo.Cupcakes");
            DropTable("dbo.Bakeries");
        }
    }
}
