namespace ContactPro.Migrations.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpecInst : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "SpecInstr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "SpecInstr");
        }
    }
}
