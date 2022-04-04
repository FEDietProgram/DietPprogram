namespace FEDiet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Food", "Portion", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Food", "Portion", c => c.Double(nullable: false));
        }
    }
}
