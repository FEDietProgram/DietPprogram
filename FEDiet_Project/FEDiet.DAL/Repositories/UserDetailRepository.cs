using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class UserDetailRepository
    {
        FEDietDbContext db;
        public UserDetailRepository()
        {
            db = new FEDietDbContext();    
        }

        public bool AddUserDetail(UserDetail userDetail)
        {
            db.UserDetails.Add(userDetail);
            return db.SaveChanges() > 0;
        }

        public bool UpdateUserDetail(UserDetail userDetail)
        {
            UserDetail updatedUserDetail = db.UserDetails.Find(userDetail.UserDetailID);
            updatedUserDetail.Weight = userDetail.Weight;
            updatedUserDetail.Height = userDetail.Height;
            updatedUserDetail.NeckWidth = userDetail.NeckWidth;
            updatedUserDetail.WaistWidth = userDetail.WaistWidth;
            updatedUserDetail.Birthdate = userDetail.Birthdate;
            updatedUserDetail.Job = userDetail.Job;
            updatedUserDetail.Gender = userDetail.Gender;
            updatedUserDetail.AllergenicFoods = userDetail.AllergenicFoods;
            updatedUserDetail.UserSituation = userDetail.UserSituation;

            return db.SaveChanges() > 0;
        }

        public bool DeleteUserDetail(UserDetail userDetail)
        {
            UserDetail deletedUserDetail = db.UserDetails.Find(userDetail.UserDetailID);
            db.UserDetails.Remove(deletedUserDetail);
            return db.SaveChanges() > 0;
        }

        public UserDetail GetUserDetailByID(int id)
        {
            UserDetail userdetail = db.UserDetails.Where(x => x.UserDetailID == id).FirstOrDefault();

            return userdetail;
        }

        public int UserAge(DateTime birth)
        {
            int age;
            age = DateTime.Now.Year - birth.Year;
            return age;
        }
        public int CalculatePregnancyWeek(UserDetail userDetail)
        {
            int weeks = Convert.ToInt32((DateTime.Now - (DateTime)userDetail.PregnancyStartDate).TotalDays / 7);
            return weeks ;
           
        }


        //public UserDetail FillUserDetailByUser(User user)
        //{
        //    UserDetail userDetail = new UserDetail();
        //    userDetail = user.UserDetail;
        //    return userDetail;
        //}
        public AgeGroup UserAgeGroup(int age)
        {
            AgeGroup ageGroup =0;
          
             if (age > 1 && age <= 8) ageGroup = AgeGroup.Child;  
             else if (age > 8 ) ageGroup = AgeGroup.GrownUp;
            return ageGroup;
        }

        //            /*BKİ değerinin normal değerlerin (18.50-24.99
        //    kg/m2) altında ya da üzerinde olması sağlık
        //    riskinin arttığının göstergesidir.
        //       BKİ’nin hesaplanabilmesi için vücut ağırlığı
        //    ve boy uzunluğu tekniğine göre ölçülür. Vücut
        //    ağırlığının (kg cinsinden) boy uzunluğunun
        //    (metre cinsinden) karesine bölünmesiyle
        //    hesaplanır [BKİ: Vücut ağırlığı (kg) / boy
        //    uzunluğu (m)2].     
        // */


        public decimal UserPerdayCalorie(UserDetail _userDetail)
        {
            UserDetail userDetail = db.UserDetails.Find(_userDetail.UserDetailID);
            string gender = userDetail.Gender.ToString();

            if (gender == "Female")
            {
                return 10 * (decimal)userDetail.Weight + (decimal)(6.25 * userDetail.Height) - 5 * UserAge(userDetail.Birthdate) - 161;
            }
            else
            {
                return 10 * (decimal)userDetail.Weight + (decimal)(6.25 * userDetail.Height) - 5 * UserAge(userDetail.Birthdate) + 5;

            }
        }

       



    }
}
