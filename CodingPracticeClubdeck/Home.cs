namespace CodingPracticeClubdeck
{
    public class Home
    {
        public void Boot()
        {
            System.Console.WriteLine(
                "<Home>\n" +
                "(Type numbers to navigate)\n" +
                "[1: View Feed] [2: Make a Post]");

            Post tCard = new Post();
            bool _onPage = true;

            while (_onPage)
            {
                var _input = System.Console.ReadLine().Trim();

                switch (_input)
                {
                    case "2":
                        tCard.PostType();
                        _onPage = false;
                        break;
                    default:
                        System.Console.WriteLine("----Invalid Input----\n");
                        break;
                }
            }
        }
    }
}
