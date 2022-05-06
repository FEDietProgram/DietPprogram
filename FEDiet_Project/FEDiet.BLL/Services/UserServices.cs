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

        public bool AddUserAccount(User user)
        {
            if (user == null)
            {
                throw new Exception("User is null");
            }
            else
            {
                return userRepository.UserSignUp(user);
            }
        }

        public bool UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }
        public bool DeleteUser(User user)
        {
            return userRepository.DeleteUser(user);
        }

        public User CheckSignIn(string email, string password)
        {
            if (email == null && password == null)
            {
                throw new Exception("Mail adresi ve şifrenizi girin");
            }
            else
            {
                return userRepository.CheckSignIn(email, password);
            }
        }

        public string CheckPasswordStrength(string password)
        {
            return userRepository.PasswordStrengthCheck(password);
        }

        public User CheckUser(string email,string password)
        {
            if (email == null && password == null)
            {
                throw new Exception("Mail adresinizi veya şifrenizi kontrol ediniz");             
            }
              return userRepository.CheckSignIn(email, password);
        }

        public double UserFatRate(DateTime day, User user)
        {
            double fatRate = 0;
            if (user != null)
            {
                fatRate = userRepository.UserFatRate(day, user);
            }
            return fatRate;
        }

        public double UserCarbRate(DateTime day, User user)
        {
            double carbRate = 0;
            if (user != null)
            {
                carbRate = userRepository.UserCarbRate(day, user);
            }
            return carbRate;
        }
             
        public double UserProteinRate(DateTime day, User user)
        {
            double proteinRate = 0;
            if (user != null)
            {
                proteinRate = userRepository.UserProteinRate(day, user);
            }
            return proteinRate;
        }

        public bool DeleteMealbyUser(User user, Meal meal,Food food)
        {
            if (meal == null)
            { throw new Exception("yemek seç"); }

            return userRepository.DeleteMealbyUser(user, meal,food);
        }

        public bool UpdateMealbyUser(User _user, Meal _meal,Food food)
        {         
            return userRepository.UpdateMealbyUser(_user, _meal,food);   
        }



        ////userRepository;

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
