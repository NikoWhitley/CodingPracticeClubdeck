namespace CodingPracticeClubdeck
{
    public class Home
    {
        PostCreation feedPostCreation = new PostCreation();

        public void Boot()
        {
            bool onPage = true;

            System.Console.WriteLine(
                "<Home>\n" +
                "(Type numbers to navigate)\n" +
                "[1: View Feed] [2: Create a Post]");

            while (onPage)
            {
                var input = System.Console.ReadLine().Trim();

                switch (input)
                {
                    case "2":
                        onPage = false;
                        feedPostCreation.CreateFeedPost();
                        break;
                    default:
                        System.Console.WriteLine("----Invalid Input----\n");
                        break;
                }
            }
        }
    }
}
