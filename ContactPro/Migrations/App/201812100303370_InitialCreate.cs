namespace ContactPro.Migrations.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        CustomerID = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        JobTitle = c.String(),
                        DirectLine = c.String(),
                        Mobile = c.String(),
                        Email = c.String(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        CompanyName = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Fax = c.String(),
                        XceleratorURL = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Country = c.String(nullable: false),
                        MailStreet = c.String(),
                        MailCity = c.String(),
                        MailState = c.String(),
                        MailZip = c.String(),
                        MailCountry = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Contacts", new[] { "CustomerID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Contacts");
        }
    }
}
