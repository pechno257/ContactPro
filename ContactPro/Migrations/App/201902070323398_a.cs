namespace ContactPro.Migrations.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserCreated", c => c.String());
            AddColumn("dbo.Customers", "UserModified", c => c.String());
            AlterColumn("dbo.Customers", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Customers", "DateModified", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateModified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "UserModified");
            DropColumn("dbo.Customers", "UserCreated");
        }
    }
}
