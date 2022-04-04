namespace FEDiet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activity", "ActivityName", c => c.String());
            AlterColumn("dbo.User", "Name", c => c.String());
            AlterColumn("dbo.User", "Surname", c => c.String());
            AlterColumn("dbo.User", "Password", c => c.String());
            AlterColumn("dbo.User", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.User", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Activity", "ActivityName", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
