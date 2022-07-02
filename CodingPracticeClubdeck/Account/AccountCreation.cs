using System;
using System.Linq;
namespace CodingPracticeClubdeck
{
    public class AccountCreation
    {
        LoginPage loginPage = new LoginPage();

        private string draftUsername;
        private string draftPassword;

        public void SignUp()
        {
            UsernameCreation();
            PasswordCreation();
            AccountConfirmation();
        }
        public void UsernameCreation()
        {
            bool selecting = true;
            var UsernameMinChar = 3;
            var UsernameMaxChar = 15;

            while (selecting)
            {
                System.Console.WriteLine("\nPlease enter a username:");
                string username = System.Console.ReadLine().Trim();

                if (username.Count() > UsernameMaxChar)
                    Console.WriteLine("----Username must be less than {0} characters----", UsernameMaxChar);
                else if (username.Count() < UsernameMinChar)
                    Console.WriteLine("----Username must be greater than {0} characters----", UsernameMinChar);
                else if (String.IsNullOrEmpty(username))
                    Console.WriteLine("----Invalid Input----");
                else
                {
                    draftUsername = username;
                    selecting = false;
                }
            }
        }
        private void PasswordCreation()
        {
            bool selecting = true;
            var PasswordMinChar = 3;
            var PasswordMaxChar = 25;

            while (selecting)
            {
                Console.WriteLine("Please enter a password:");
                string password = System.Console.ReadLine();
                if (password.Count() > PasswordMaxChar)
                    Console.WriteLine("----Username must be less than {0} characters----", PasswordMaxChar);
                else if (password.Count() < PasswordMinChar)
                    Console.WriteLine("----Username must be greater than {0} characters----", PasswordMinChar);
                else if (password == draftUsername)
                    Console.WriteLine("----Password and Username cannot be the same----");
                else if (String.IsNullOrEmpty(password))
                    Console.WriteLine("----Invalid Input----");
                else
                {
                    draftPassword = password;
                    selecting = false;
                }
            }
        }
        private void AccountConfirmation()
        {
            bool selecting = true;

            while (selecting)
            {
                Console.WriteLine("Username: " + draftUsername + "\n[Re-enter password: Confirm and Login]\n" +
                    "[1: Edit Username] [2: Edit Password] [3: Exit]");
                var passwordConfirmation = System.Console.ReadLine();

                if (passwordConfirmation == draftPassword)
                {
                    selecting = false;

                    AccountRepository.AddAccount(draftUsername, draftPassword);
                    Console.WriteLine("\nAccount Created!\nLogging In...\n");
                    
                    loginPage.Login(draftUsername, draftPassword);
                }
                else
                {
                    switch (passwordConfirmation)
                    {
                        case "1":
                            UsernameCreation();
                            break;
                        case "2":
                            PasswordCreation();
                            break;
                        case "3":
                            selecting = false;
                            loginPage.LoginStart();
                            break;
                        default:
                            Console.WriteLine("----Invalid Password or Input----");
                            break;
                    }
                }
            }
        }
    }
}
