using FEDiet.DAL.EntityConfiguration;
using FEDiet.DAL.Strategy;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL//HasOptional(a => a.Goal).WithMany(b => b.User).HasForeignKey(c => c.GoalID)
{
    internal class FEDietDbContext:DbContext
    {
        public FEDietDbContext() : base("Data Source=.;Initial Catalog=FEDietDB;Integrated Security=true;")
        {
            Database.SetInitializer(new AdminStrategy());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities{ get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ActivityConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new GoalConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new UserDetailConfiguration());

        }


    }
}
