using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingPracticeClubdeck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Login?
            var login = new Account();
            var home = new Home();
            login.Login();
            home.Boot();
        }
    }
}
