using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay6
{
    internal interface IAccount
    {

        public bool PasswordChecker(string pw);

        public void ShowInfo();
    }
}
