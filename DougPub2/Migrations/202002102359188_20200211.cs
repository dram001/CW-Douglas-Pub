namespace DougPub2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20200211 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "TableNo", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.AspNetUsers", "TableNo", c => c.String());
            DropColumn("dbo.Orders", "Address");
            DropColumn("dbo.Orders", "City");
            DropColumn("dbo.Orders", "State");
            DropColumn("dbo.Orders", "PostalCode");
            DropColumn("dbo.Orders", "Country");
            DropColumn("dbo.Orders", "Phone");
            DropColumn("dbo.Orders", "Experation");
            DropColumn("dbo.Orders", "SaveInfo");
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "PostalCode");
            DropColumn("dbo.AspNetUsers", "Country");
            DropColumn("dbo.AspNetUsers", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            AddColumn("dbo.AspNetUsers", "Country", c => c.String());
            AddColumn("dbo.AspNetUsers", "PostalCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
            AddColumn("dbo.Orders", "SaveInfo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "Experation", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "Phone", c => c.String(nullable: false, maxLength: 24));
            AddColumn("dbo.Orders", "Country", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Orders", "State", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "City", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "Address", c => c.String(nullable: false, maxLength: 70));
            DropColumn("dbo.AspNetUsers", "TableNo");
            DropColumn("dbo.Orders", "TableNo");
        }
    }
}
