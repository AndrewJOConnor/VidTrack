using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidTrack.Classes
{
    class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AccountType { get; set; }//........................1 = generic user, 2 = admin.




        public Account(
            string newAccountUsername,
            string newAccounPassword,
            string newAccountEmail,
            string newAccountType
        )
        {
            Username = newAccountUsername;
            Password = newAccounPassword;
            Email = newAccountEmail;
            AccountType = newAccountType;
        }
    }




   
}
