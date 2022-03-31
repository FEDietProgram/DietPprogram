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
        FEDietDbContext fEDietDbContext;
        public UserDetailRepository()
        {
            fEDietDbContext = new FEDietDbContext();    
        }

        public UserDetail GetUserDetailByID(int id)
        {
            UserDetail userdetail = fEDietDbContext.UserDetails.Where(x => x.ID == id).FirstOrDefault();

            return userdetail;
        }

        public int UserAge(DateTime birth)
        {
            int age;
            age= DateTime.Now.Year- birth.Year;
            return age;
        }


        public AgeGroup UserAgeGroup(int age)
        {
            AgeGroup ageGroup;
            if (age > 0 && age <= 1) ageGroup = AgeGroup.infant;
            else if (age > 1 && age <= 8) ageGroup = AgeGroup.child;
            else if (age > 8 && age <= 18) ageGroup = AgeGroup.young;
            else if (age > 18 && age <= 50) ageGroup = AgeGroup.elder;
            else ageGroup = AgeGroup.old;
            return ageGroup;
        }

                    /*BKİ değerinin normal değerlerin (18.50-24.99
            kg/m2) altında ya da üzerinde olması sağlık
            riskinin arttığının göstergesidir.
               BKİ’nin hesaplanabilmesi için vücut ağırlığı
            ve boy uzunluğu tekniğine göre ölçülür. Vücut
            ağırlığının (kg cinsinden) boy uzunluğunun
            (metre cinsinden) karesine bölünmesiyle
            hesaplanır [BKİ: Vücut ağırlığı (kg) / boy
            uzunluğu (m)2].     
         */


        public decimal UserPerdayCalorie(UserDetail user)
        {
            if (user.Gender)
            {
                return 10 * user.Weight + 6.25M * user.Height - 5 * UserAge(user.BirthDate) - 161;
            }
            else
            {
                return 10 * user.Weight + 6.25M * user.Height - 5 * UserAge(user.BirthDate) + 5;

            }      


        }

        public decimal CalculateUserBMI(decimal mass, decimal height)
        {
            return mass / (height*height);
        }

        public decimal CalculateUserFatRate(UserDetail userDetail)
        {
            int age = UserAge(userDetail.BirthDate);
            AgeGroup agegroup = UserAgeGroup(age);
            if (userDetail.Gender)
            {
                if (agegroup != AgeGroup.infant || agegroup != AgeGroup.child)
                {
                    return 1.20M * CalculateUserBMI(userDetail.Weight, userDetail.Height) + 0.23M * age - 5.4M;
                }
                else
                {
                    return 1.51M * CalculateUserBMI(userDetail.Weight, userDetail.Height) + 0.70M * age + 1.4M;
                }
            }
            else
            {
                if (agegroup != AgeGroup.infant || agegroup != AgeGroup.child)
                {
                    return 1.20M * CalculateUserBMI(userDetail.Weight, userDetail.Height) + 0.23M * age - 16.2M;
                }
                else
                {
                    return 1.51M * CalculateUserBMI(userDetail.Weight, userDetail.Height) + 0.70M * age - 2.2M;
                }
            }
        } 
        


    }
}
