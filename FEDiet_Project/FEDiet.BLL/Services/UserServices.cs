using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class UserServices
    {
        UserRepository userRepository;
        public UserServices()
        {
            userRepository = new UserRepository();  
        }

        public void AddUser(User _user)
        { 
            if (_user != null)
            {
                if (string.IsNullOrEmpty(userRepository.PasswordStrengthCheck(_user.Password)))
                {
                    userRepository.UserSignUp(_user);
                }
                else
                {
                    throw new Exception("Lütfen girdiğiniz parolayı kontrol ediniz.");
                }
                

            }
            else
            {
                throw new Exception("Kullanıcı bilgileri boş veya eksik!");
            }
            
        }

        public int UpdateUser(User user)
        {
            if(user==null)
            {
                throw new Exception("Kullanıcı bilgilerinizi kontrol ediniz");
            }
            return userRepository.UpdateUser(user);
        }


        public User CheckUser(string email,string password)
        {
            if (email == null && password == null)
            {
                throw new Exception("Mail adresinizi veya şifrenizi kontrol ediniz");             
            }
              return userRepository.CheckSignIn(email, password);
        }

        public decimal UserFatRate(DateTime day,User user)
        {
            decimal fatRate=0;
            if(user != null)
            {
               fatRate= userRepository.UserFatRate(day, user);
            }
            return fatRate;
        }

        public decimal UserCarbRate(DateTime day, User user)
        {
            decimal carbRate = 0;
            if (user != null)
            {
                carbRate = userRepository.UserFatRate(day, user);
            }
            return carbRate;
        }

        public decimal UserWaterRate(DateTime day, User user)
        {
            decimal waterRate = 0;
            if (user != null)
            {
                waterRate = userRepository.UserFatRate(day, user);
            }
            return waterRate;
        }

        public decimal UserProteinRate(DateTime day, User user)
        {
            decimal proteinRate = 0;
            if (user != null)
            {
                proteinRate = userRepository.UserFatRate(day, user);
            }
            return proteinRate;
        }

        public List<User> UserList()
        {
            return userRepository.UserList();
        }

        public int UserAge(DateTime date)
        {
            return userRepository.UserAge(date);
        }

        public string CheckPasswordStrength(string password)
        {
            return userRepository.PasswordStrengthCheck(password);
        }

        //userRepository;

        public List<Food> BadFoodList(User _user)
        {
           
            return userRepository.BadFoodList(_user);
        }

        public List<Food> BetterFoodList(User _user)
        {           
            return userRepository.BetterFoodList(_user);
        }

        public string FavoriteFoodbyUser(User _user)
        {           
            return userRepository.FavoriteFoodbyUser(_user);
        }

        public string MaxCaloryOfUser(User _user)
        {            
            return userRepository.MaxCaloryOfUser(_user);
        }

        public string MaxProteinOfUser(User _user)
        {           
            return userRepository.MaxProteinOfUser(_user);
        }

        public string MaxFatOfUser(User _user)
        {           
            return userRepository.MaxFatOfUser(_user);
        }

        public string MaxCarbsOfUser(User _user)
        {           
            return userRepository.MaxCarbsOfUser(_user);
        }

        public string MaxWaterOfUser(User _user)
        {           
            return userRepository.MaxWaterOfUser(_user);
        }

        public DateTime UserFailedDay(User _user)
        {         
            return userRepository.UserFailedDay(_user);
        }

        public DateTime BestDay(User _user)
        {         
            return userRepository.BestDay(_user);
        }




    }
}
