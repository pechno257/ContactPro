namespace ContactPro.Migrations.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMailAddress : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MailStreet");
            DropColumn("dbo.Customers", "MailCity");
            DropColumn("dbo.Customers", "MailState");
            DropColumn("dbo.Customers", "MailZip");
            DropColumn("dbo.Customers", "MailCountry");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MailCountry", c => c.String());
            AddColumn("dbo.Customers", "MailZip", c => c.String());
            AddColumn("dbo.Customers", "MailState", c => c.String());
            AddColumn("dbo.Customers", "MailCity", c => c.String());
            AddColumn("dbo.Customers", "MailStreet", c => c.String());
        }
    }
}
