using System.Collections.Generic;

namespace CodingPracticeClubdeck
{
    public static class AccountRepository
    {
        private static List<AccountService> _accounts = new List<AccountService>();

        public static void AddAccount(string username, string password)
        {
            _accounts.Add(new AccountService
            {
                Username = username,
                Password = password
            });
        }
        public static AccountService GetAccount(string username)
        {
            return _accounts.Find(x => x.Username == username);
        }
        public static void UpdatePassword(string username, string password)
        {
            _accounts.Find(x => x.Username == username).Password = password;
        }
    }
}
