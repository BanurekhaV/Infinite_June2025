namespace MVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Qty = c.Int(nullable: false),
                        Sales_SaleID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sales", t => t.Sales_SaleID)
                .Index(t => t.Sales_SaleID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SaleID = c.Int(nullable: false, identity: true),
                        Saledate = c.DateTime(nullable: false),
                        QtySold = c.Int(nullable: false),
                        SaleAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SaleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Sales_SaleID", "dbo.Sales");
            DropIndex("dbo.Products", new[] { "Sales_SaleID" });
            DropTable("dbo.Sales");
            DropTable("dbo.Products");
        }
    }
}
