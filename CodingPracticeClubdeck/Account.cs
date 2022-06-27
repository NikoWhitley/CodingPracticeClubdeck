namespace CodingPracticeClubdeck
{
    public class Account
    {
        //set a way to create multiple accounts where posts are associated. Switch accounts with passwords to view different things.
        //must be signed in to get to Home

        public string username;
        private string password;
        //enum or something for storing password and username association

        private bool _loggedIn = false;
        public void Login()
        {
            System.Console.WriteLine("ClubDeck\n");
            if (_loggedIn)
            {
                System.Console.WriteLine("Currently signed in as:" + username);
                //logout
            }
            else
            {
                System.Console.WriteLine(
                    "<Login>\n" +
                    "Enter username:");
                var _input = System.Console.ReadLine();
            }
        }
    }
}
