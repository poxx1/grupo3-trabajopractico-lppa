namespace Marketplace.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditEntitiesFields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderedProduct", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.OrderedProduct", "CustomerOrder_Id", "dbo.CustomerOrder");
            DropIndex("dbo.OrderedProduct", new[] { "CustomerOrder_Id" });
            DropIndex("dbo.OrderedProduct", new[] { "Product_Id" });
            AlterColumn("dbo.Cart", "CardId", c => c.Int(nullable: false));
            AlterColumn("dbo.Product", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Product", "Description", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Product", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.OrderedProduct", "CustomerOrder_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderedProduct", "Product_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerOrder", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "Address", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "City", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "State", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "PostalCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "Country", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "Phone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "Email", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerOrder", "CustomerUserName", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.OrderedProduct", "CustomerOrder_Id");
            CreateIndex("dbo.OrderedProduct", "Product_Id");
            AddForeignKey("dbo.OrderedProduct", "Product_Id", "dbo.Product", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderedProduct", "CustomerOrder_Id", "dbo.CustomerOrder", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderedProduct", "CustomerOrder_Id", "dbo.CustomerOrder");
            DropForeignKey("dbo.OrderedProduct", "Product_Id", "dbo.Product");
            DropIndex("dbo.OrderedProduct", new[] { "Product_Id" });
            DropIndex("dbo.OrderedProduct", new[] { "CustomerOrder_Id" });
            AlterColumn("dbo.CustomerOrder", "CustomerUserName", c => c.String());
            AlterColumn("dbo.CustomerOrder", "Email", c => c.String());
            AlterColumn("dbo.CustomerOrder", "Phone", c => c.String());
            AlterColumn("dbo.CustomerOrder", "Country", c => c.String());
            AlterColumn("dbo.CustomerOrder", "PostalCode", c => c.String());
            AlterColumn("dbo.CustomerOrder", "State", c => c.String());
            AlterColumn("dbo.CustomerOrder", "City", c => c.String());
            AlterColumn("dbo.CustomerOrder", "Address", c => c.String());
            AlterColumn("dbo.CustomerOrder", "LastName", c => c.String());
            AlterColumn("dbo.CustomerOrder", "FirstName", c => c.String());
            AlterColumn("dbo.OrderedProduct", "Product_Id", c => c.Int());
            AlterColumn("dbo.OrderedProduct", "CustomerOrder_Id", c => c.Int());
            AlterColumn("dbo.Category", "Name", c => c.String());
            AlterColumn("dbo.Product", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Product", "Description", c => c.String());
            AlterColumn("dbo.Product", "Name", c => c.String());
            AlterColumn("dbo.Cart", "CardId", c => c.String());
            CreateIndex("dbo.OrderedProduct", "Product_Id");
            CreateIndex("dbo.OrderedProduct", "CustomerOrder_Id");
            AddForeignKey("dbo.OrderedProduct", "CustomerOrder_Id", "dbo.CustomerOrder", "Id");
            AddForeignKey("dbo.OrderedProduct", "Product_Id", "dbo.Product", "Id");
        }
    }
}
