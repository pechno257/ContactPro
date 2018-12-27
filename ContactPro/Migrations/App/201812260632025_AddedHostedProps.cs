namespace ContactPro.Migrations.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHostedProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsHosted", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "HostedServer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "HostedServer");
            DropColumn("dbo.Customers", "IsHosted");
        }
    }
}
