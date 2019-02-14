namespace ContactPro.Migrations.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAuditToContacts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Contacts", "AddedBy", c => c.String());
            AddColumn("dbo.Contacts", "LastModified", c => c.DateTime());
            AddColumn("dbo.Contacts", "LastModifiedBy", c => c.String());
            DropColumn("dbo.Contacts", "DateCreated");
            DropColumn("dbo.Contacts", "DateModified");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contacts", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contacts", "LastModifiedBy");
            DropColumn("dbo.Contacts", "LastModified");
            DropColumn("dbo.Contacts", "AddedBy");
            DropColumn("dbo.Contacts", "DateAdded");
        }
    }
}
