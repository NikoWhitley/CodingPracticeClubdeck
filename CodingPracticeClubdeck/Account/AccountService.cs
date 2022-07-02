using System.Collections.Generic;
using System.Linq;


namespace CodingPracticeClubdeck
{
    public class AccountService
    {
        public static string CurrentUser;
        public string Username { get; set; }
        public string Password { private get; set; }

        public bool LoginRequest(string username, string password)
        {
            var account = AccountRepository.GetAccount(username);

            if (account == null)
            {
                return false;
            }
            else if (account.Password == password)
            {
                CurrentUser = username;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePassword(string username, string password, string newPassword)
        {
            var account = AccountRepository.GetAccount(username);

            if (account == null)
                return false;

            if (account.Password != password) return false;

            else
            {
                account.Password = newPassword;
                AccountRepository.UpdatePassword(username, newPassword);
                return true;
            }
        }
    }
}
