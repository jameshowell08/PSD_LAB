using PSD_LAB.Factory;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Repositories
{
    public class UserRepository
    {
        public Database1Entities db = DatabaseSingleton.GetInstance();
        UserFactory UF = new UserFactory();

        public void AddUser(string username, string email, string gender, DateTime dob, string password)
        {
            User newUser = UF.createUser(username,email,gender,dob,password);
            db.Users.Add(newUser);
            db.SaveChanges();
        }
        
        public int GenerateID()
        {
            return GetLastID() + 1;
        }
        public int GetLastID()
        {
            return(from x in db.Users select x.UserID).ToList().LastOrDefault();
        }

        public User GetUserByID(int id)
        {
            User user = db.Users.Find(id);
            return user;
        }

        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }

        public bool FindUsername(string username)
        {
            User usernametemp = db.Users.Where(x => x.Username == username).FirstOrDefault();
            if(usernametemp != null)
            {
                return false;
            }
            return true;
        }

        public User GetUserLogin(string username, string password)
        {
            User accTemp = db.Users.Where(x => x.Username == username && x.UserPassword == password).FirstOrDefault();
            return accTemp;
        }

        public void UpdateProfile(int Id, string username, string email, string gender, DateTime dob)
        {
            User user = db.Users.Find(Id);
            user.Username = username;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = dob;
            db.SaveChanges();
        }

        public string GetPasswordByID(int Id)
        {
            User user = GetUserByID(Id);
            return user.UserPassword;
        }
        public void UpdatePassword(int Id,string newpassword)
        {
            User user = db.Users.Find(Id);
            user.UserPassword = newpassword;
            db.SaveChanges();
        }
                                      
    }
}