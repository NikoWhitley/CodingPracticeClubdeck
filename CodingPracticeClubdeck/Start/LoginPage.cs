using System;
using System.Linq;

namespace CodingPracticeClubdeck
{
    public class LoginPage
    {
        Home home = new Home();
        AccountService accountService = new AccountService();
        AccountCreation accountCreation = new AccountCreation();

        public void LoginStart()
        {
            bool selecting = true;

            System.Console.WriteLine("Welcome to ClubDeck\n" +
                "<Login>\n" +
                "[1: Create Account] [2: Log In]");

            while (selecting)
            {
                string input = System.Console.ReadLine().Trim();

                switch (input)
                {
                    case "1":
                        selecting = false;
                        accountCreation.SignUp();
                        break;
                    case "2":
                        selecting = false;
                        Login();
                        break;
                    default:
                        System.Console.WriteLine("----Invalid Input----\n");
                        break;
                }
            }
        }
        public void Login()
        {
            Console.WriteLine("Username:");
            var username = System.Console.ReadLine();
            Console.WriteLine("Password:");
            var password = System.Console.ReadLine();

            bool loginConfirmation = accountService.LoginRequest(username, password);

            if (loginConfirmation)
            {
                home.Boot();
            }
            else
            {
                Console.WriteLine("----Invalid Username or Password----");
                Login();
            }
        }
        public void Login(string username, string password)
        {
            bool loginConfirmation = accountService.LoginRequest(username, password);

            if (loginConfirmation)
            {
                home.Boot();
            }
        }
    }
}
