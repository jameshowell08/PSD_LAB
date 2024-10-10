using PSD_LAB.Handler;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Controller
{
    public class UserController
    {
        UserHandler Uhand = new UserHandler();

        public int RegisterValidation(string username, string email, string gender, DateTime dob, string password, string confirmpassword)
        {
            if (username.Length > 5 && username.Length < 15)
            {
                if (!(string.IsNullOrEmpty(email)) && email.EndsWith(".com"))
                {
                    if (!string.IsNullOrEmpty(gender))
                    {

                        if (!IsDateTimeEmpty(dob))
                        {
                            if (IsAlphaNumeric(password) && password == confirmpassword)
                            {
                                int temp = Uhand.RegisterHand(username, email, gender, dob, password);
                                return temp;
                            }

                        }

                    }
                }

            }
            return 0;

        }
        public bool IsAlphaNumeric(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public User GetUserByID(int id)
        {
            return Uhand.GetUserByID(id);
        }

        public List<User> GetUsers()
        {
            return Uhand.GetUsers();
        }


        public int UpdateProfile(int Id, string username, string email, string gender, DateTime dob)
        {
            if (username.Length > 5 && username.Length < 15)
            {
                if (!(string.IsNullOrEmpty(email)) && email.EndsWith(".com"))
                {
                    if (!string.IsNullOrEmpty(gender))
                    {
                        if (!IsDateTimeEmpty(dob))
                        {
                            int temp = Uhand.UpdateProfile(Id,username, email, gender, dob);
                            return temp;
                        }

                    }
                }

            }
            return 0;
        }
        public int UpdatePassword(int Id, string oldpassword, string newpassword)
        {

            if (IsAlphaNumeric(newpassword))
            {
                return Uhand.UpdatePassword(Id, oldpassword, newpassword);
                
            }
            return 0;

        }

        public bool IsDateTimeEmpty(DateTime dateTime)
        {

            return dateTime == DateTime.MinValue;
        }


        public User LoginValidation(string username, string password)
        {
            User UserValid = Uhand.LoginHand(username, password);
            return UserValid;
        }
        public int RoleValidation(User UserValid)
        {
            if (UserValid.UserRole.Equals("Admin"))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }
}