using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Handler
{
    public class UserHandler
    {
        UserRepository Urepo = new UserRepository();

        public int RegisterHand(string username, string email, string gender, DateTime dob, string password)
        {
            bool checkusernameunique = UsernameHand(username);
            if (checkusernameunique)
            {
                Urepo.AddUser(username, email, gender, dob, password);
                return 1;
            }
            return 0;
        }

       
        public bool UsernameHand(string username)
        {
            return Urepo.FindUsername(username);
        }
        public User GetUserByID(int id)
        {
            return Urepo.GetUserByID(id);
        }

        public List<User> GetUsers()
        {
            return Urepo.GetUsers();
        }


        public int UpdateProfile(int Id, string username, string email, string gender, DateTime dob)
        {
            bool checkusernameunique = Urepo.FindUsername(username);
            if (checkusernameunique)
            {
                Urepo.UpdateProfile(Id,username, email, gender, dob);
                return 1;
            }
            return 0;
        }

        public bool CheckPassword(string oldpasswordDb, string oldpassword)
        {
            return oldpasswordDb == oldpassword;
        }


        public int UpdatePassword(int Id, string oldpassword, string newpassword)
        {
            string oldpasswordDb = Urepo.GetPasswordByID(Id).Trim();
            if (oldpasswordDb == oldpassword)
            {
                Urepo.UpdatePassword(Id, newpassword);
                return 1;
            }
            return 0;
        }


        public User LoginHand(string username, string password)
        {
            return Urepo.GetUserLogin(username, password);
        }

       
    }
}