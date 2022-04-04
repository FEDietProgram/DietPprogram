namespace FEDiet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.User", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.User", "Surname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
