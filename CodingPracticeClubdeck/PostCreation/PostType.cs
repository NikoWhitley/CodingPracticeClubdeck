namespace CodingPracticeClubdeck
{
    public class Post
    {
        public void PostType()
        {
            System.Console.WriteLine("\n<Create a Post>\n" +
                "What kind of post would you like to create?\n" +
                "[1: Feed] [4: BACK]");

            Home home = new Home();
            FeedPost feedPost = new FeedPost();
            bool _onPage = true;

            while (_onPage)
            {
                var _input = System.Console.ReadLine().Trim();

                switch (_input)
                {
                    case "1":
                        feedPost.CreateFeedPost();
                        _onPage = false;
                        break;
                    case "4":
                        home.Boot();
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
