namespace FEDiet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activity",
                c => new
                    {
                        ActivityID = c.Int(nullable: false, identity: true),
                        ActivityName = c.String(nullable: false, maxLength: 30),
                        ActivityTime = c.DateTime(nullable: false),
                        ActivityDuration = c.Double(nullable: false),
                        BurnedCalory = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Goal",
                c => new
                    {
                        GoalID = c.Int(nullable: false, identity: true),
                        GoalName = c.String(),
                        GoalWeight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GoalID);
            
            CreateTable(
                "dbo.Meal",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        MealName = c.String(),
                        MealCalory = c.Double(nullable: false),
                        MealTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MealID);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        FoodPciture = c.String(),
                        Portion = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        CaloryPerOnePortion = c.Double(nullable: false),
                        FatCaloryPerGram = c.Double(nullable: false),
                        ProteinCaloryPerGram = c.Double(nullable: false),
                        CarbonhydratesCaloryPerGram = c.Double(nullable: false),
                        FoodCategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.FoodCategory", t => t.FoodCategoryID)
                .Index(t => t.FoodCategoryID);
            
            CreateTable(
                "dbo.FoodCategory",
                c => new
                    {
                        FoodCategoryID = c.Int(nullable: false, identity: true),
                        FoodCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.FoodCategoryID);
            
            CreateTable(
                "dbo.UserDetail",
                c => new
                    {
                        UserDetailID = c.Int(nullable: false),
                        Gender = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Job = c.String(),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        NeckWidth = c.Double(nullable: false),
                        WaistWidth = c.Double(nullable: false),
                        HipWidth = c.Double(nullable: false),
                        UserSituation = c.String(),
                        DailyRequiredCaloryTaken = c.Double(nullable: false),
                        DailyRequiredWaterConsumption = c.Double(nullable: false),
                        BodyMassIndex = c.Double(nullable: false),
                        BodyFatRate = c.Double(nullable: false),
                        AgeGroup = c.Int(nullable: false),
                        BloodGroup = c.Int(nullable: false),
                        DietType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserDetailID)
                .ForeignKey("dbo.User", t => t.UserDetailID)
                .Index(t => t.UserDetailID);
            
            CreateTable(
                "dbo.Water",
                c => new
                    {
                        WaterID = c.Int(nullable: false, identity: true),
                        AmountOfWaterConsumed = c.Double(nullable: false),
                        WaterConsumedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WaterID);
            
            CreateTable(
                "dbo.UserActivity",
                c => new
                    {
                        User_UserID = c.Int(nullable: false),
                        Activity_ActivityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserID, t.Activity_ActivityID })
                .ForeignKey("dbo.User", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Activity", t => t.Activity_ActivityID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Activity_ActivityID);
            
            CreateTable(
                "dbo.UserGoal",
                c => new
                    {
                        User_UserID = c.Int(nullable: false),
                        Goal_GoalID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserID, t.Goal_GoalID })
                .ForeignKey("dbo.User", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Goal", t => t.Goal_GoalID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Goal_GoalID);
            
            CreateTable(
                "dbo.FoodMeal",
                c => new
                    {
                        Food_FoodID = c.Int(nullable: false),
                        Meal_MealID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Food_FoodID, t.Meal_MealID })
                .ForeignKey("dbo.Food", t => t.Food_FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Meal", t => t.Meal_MealID, cascadeDelete: true)
                .Index(t => t.Food_FoodID)
                .Index(t => t.Meal_MealID);
            
            CreateTable(
                "dbo.UserMeal",
                c => new
                    {
                        User_UserID = c.Int(nullable: false),
                        Meal_MealID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserID, t.Meal_MealID })
                .ForeignKey("dbo.User", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Meal", t => t.Meal_MealID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Meal_MealID);
            
            CreateTable(
                "dbo.UserWater",
                c => new
                    {
                        User_UserID = c.Int(nullable: false),
                        Water_WaterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserID, t.Water_WaterID })
                .ForeignKey("dbo.User", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Water", t => t.Water_WaterID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Water_WaterID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserWater", "Water_WaterID", "dbo.Water");
            DropForeignKey("dbo.UserWater", "User_UserID", "dbo.User");
            DropForeignKey("dbo.UserDetail", "UserDetailID", "dbo.User");
            DropForeignKey("dbo.UserMeal", "Meal_MealID", "dbo.Meal");
            DropForeignKey("dbo.UserMeal", "User_UserID", "dbo.User");
            DropForeignKey("dbo.FoodMeal", "Meal_MealID", "dbo.Meal");
            DropForeignKey("dbo.FoodMeal", "Food_FoodID", "dbo.Food");
            DropForeignKey("dbo.Food", "FoodCategoryID", "dbo.FoodCategory");
            DropForeignKey("dbo.UserGoal", "Goal_GoalID", "dbo.Goal");
            DropForeignKey("dbo.UserGoal", "User_UserID", "dbo.User");
            DropForeignKey("dbo.UserActivity", "Activity_ActivityID", "dbo.Activity");
            DropForeignKey("dbo.UserActivity", "User_UserID", "dbo.User");
            DropIndex("dbo.UserWater", new[] { "Water_WaterID" });
            DropIndex("dbo.UserWater", new[] { "User_UserID" });
            DropIndex("dbo.UserMeal", new[] { "Meal_MealID" });
            DropIndex("dbo.UserMeal", new[] { "User_UserID" });
            DropIndex("dbo.FoodMeal", new[] { "Meal_MealID" });
            DropIndex("dbo.FoodMeal", new[] { "Food_FoodID" });
            DropIndex("dbo.UserGoal", new[] { "Goal_GoalID" });
            DropIndex("dbo.UserGoal", new[] { "User_UserID" });
            DropIndex("dbo.UserActivity", new[] { "Activity_ActivityID" });
            DropIndex("dbo.UserActivity", new[] { "User_UserID" });
            DropIndex("dbo.UserDetail", new[] { "UserDetailID" });
            DropIndex("dbo.Food", new[] { "FoodCategoryID" });
            DropTable("dbo.UserWater");
            DropTable("dbo.UserMeal");
            DropTable("dbo.FoodMeal");
            DropTable("dbo.UserGoal");
            DropTable("dbo.UserActivity");
            DropTable("dbo.Water");
            DropTable("dbo.UserDetail");
            DropTable("dbo.FoodCategory");
            DropTable("dbo.Food");
            DropTable("dbo.Meal");
            DropTable("dbo.Goal");
            DropTable("dbo.User");
            DropTable("dbo.Activity");
        }
    }
}
