using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Factory
{
    public class UserFactory
    {   
        public static UserRepository Urepo = new UserRepository();
        public User createUser(string username, string email, string gender, DateTime dob, string password)
        {
            User user =  new User();
            user.UserID = Urepo.GenerateID();
            user.Username = username;   
            user.UserGender = gender;   
            user.UserEmail = email;
            user.UserDOB = dob;
            user.UserPassword = password;
            user.UserRole = "Customer";
            return user;
        }
    }
}