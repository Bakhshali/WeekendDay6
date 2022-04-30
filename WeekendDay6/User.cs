using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay6
{
    internal class User : IAccount
    {
        private string _password;
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(!PasswordChecker(_password))
                _password = value;
            }

        }

        public  bool PasswordChecker(string pw)
        {
            bool hasDigit = false;
            bool hasLetter = false;
            bool hasUpper = false;

            if (pw.Length > 8)

                foreach (var item in pw)
                {
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                    }
                    if (char.IsLetter(item))
                    {
                        hasLetter = true;
                    }
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                    }
                }
            bool result = hasDigit && hasLetter && hasUpper;
            return result;
        }

        public User(string fullname,string email)
        {
            Fullname = fullname;
            Email = email;
            _id++;
            Id = _id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
        }


    }
}
