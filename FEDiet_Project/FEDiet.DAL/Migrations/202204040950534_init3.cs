namespace FEDiet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.User", "Surname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Meal", "MealName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Food", "FoodName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.UserDetail", "Gender", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.UserDetail", "Job", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDetail", "Job", c => c.String());
            AlterColumn("dbo.UserDetail", "Gender", c => c.String());
            AlterColumn("dbo.Food", "FoodName", c => c.String());
            AlterColumn("dbo.Meal", "MealName", c => c.String());
            AlterColumn("dbo.User", "Email", c => c.String());
            AlterColumn("dbo.User", "Password", c => c.String());
            AlterColumn("dbo.User", "Surname", c => c.String());
            AlterColumn("dbo.User", "Name", c => c.String());
        }
    }
}
