using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SharpPhone
{
    public class SharpPhoneDataStore
    {
        List<SmartPhone> Phones = new List<SmartPhone>();
        List<UserAccount> Accounts = new List<UserAccount>();
    }

    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int FailedAttempts { get; set; }
        public bool locked { get; set; }
    }

    internal class SmartPhoneJsonStore
    {
        public SmartPhoneJsonStore Data { get; set; } =
    }
}