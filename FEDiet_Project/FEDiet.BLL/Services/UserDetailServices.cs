using FEDiet.DAL.Repositories;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    
    public class UserDetailServices
    {
        UserDetailRepository userDetailRepository;

        public UserDetailServices()
        {
            userDetailRepository = new UserDetailRepository();
        }


        public bool UserGender(bool gender)
        {
            bool genderResult = true;
            if (gender)
            {
                return genderResult;

            }
            else
            {
                genderResult = false;
                return genderResult;
            }
        }

        public int UserAge(DateTime birth)
        {    
            int ageResult = 0;       
            if(birth!=null)
            {
              ageResult=  userDetailRepository.UserAge(birth);
            }

            else { throw new Exception("Doğum tarihinizi giriniz"); }

            return ageResult;   
        }

        public AgeGroup UserAgeGroups(int age)
        {
            AgeGroup ageGroup = new AgeGroup();
            if (age != null)
            {
                ageGroup = userDetailRepository.UserAgeGroup(age);
            }
            return ageGroup;
        }
       
    }
}
