namespace ContactPro.Migrations.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDBFieldName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Customers", "AddedBy", c => c.String());
            AddColumn("dbo.Customers", "LastModified", c => c.DateTime());
            AddColumn("dbo.Customers", "LastModifiedBy", c => c.String());
            DropColumn("dbo.Customers", "DateCreated");
            DropColumn("dbo.Customers", "UserCreated");
            DropColumn("dbo.Customers", "DateModified");
            DropColumn("dbo.Customers", "UserModified");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "UserModified", c => c.String());
            AddColumn("dbo.Customers", "DateModified", c => c.DateTime());
            AddColumn("dbo.Customers", "UserCreated", c => c.String());
            AddColumn("dbo.Customers", "DateCreated", c => c.DateTime());
            DropColumn("dbo.Customers", "LastModifiedBy");
            DropColumn("dbo.Customers", "LastModified");
            DropColumn("dbo.Customers", "AddedBy");
            DropColumn("dbo.Customers", "DateAdded");
        }
    }
}
