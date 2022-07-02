using System;
using System.Collections.Generic;
using System.Globalization;

namespace CodingPracticeClubdeck
{

    public class PostCreation
    {
        PostRepository postRepository = new PostRepository();
        Home home = new Home();

        private string PostTitle;
        private string PostContent;
        private string PostTime = DateTime.Now.ToString("MMM dd, yyyy | hh:mm tt");
        private string AuthorTitle = "*Working on this*";

        
        public void CreateFeedPost()
        {
            PostTitleCreation();
            PostContentCreation();
            PostConfirmation();
        }
        private void PostTitleCreation()
        {
            System.Console.WriteLine("\n<Create Feed Post: Title>\nPost Title:");

            while (true)
            {
                string _title = System.Console.ReadLine().Trim();
                int _charLimit = 25;
              

                if (string.IsNullOrEmpty(_title))
                {
                    System.Console.WriteLine("----Title is Required----");
                }
                else if (_title.Length > _charLimit)
                {
                    System.Console.WriteLine("----Title Exceeds Character Limit----");
                }
                else
                {
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    PostTitle = textInfo.ToTitleCase(_title);
                    break;
                }
            }
        }
        private void PostContentCreation()
        {
            System.Console.WriteLine("\n<Create Feed Post: Content>\nPost Content:");

            while (true)
            {
                string Content = System.Console.ReadLine();
                int CharLimit = 100;

                if (string.IsNullOrEmpty(Content))
                {
                    System.Console.WriteLine("----Content is Required----");
                }
                else if (Content.Length > CharLimit)
                {
                    System.Console.WriteLine("----Title Exceeds Character Limit----");
                }
                else
                {
                    PostContent = Content.Trim();
                    break;
                }
            }
        }
        private void PostConfirmation()
        {
            bool confirming = true;

            while (confirming)
            {
                System.Console.WriteLine(
                "\n<Feed Post Confirmation>\n" +
                PostTime + "\n" +
                PostTitle + "\n" +
                PostContent + "\n" +
                "[1: Confirm and Post] [2: Edit Title] [3: Edit Content] [4: Cancel]");

                var input = System.Console.ReadLine();

                switch (input)
                {
                    case "1":
                        postRepository.AddPost(PostTitle, PostContent, PostTime, AuthorTitle);

                        Console.WriteLine("\n'{0}' was posted!\n", PostTitle);
                        confirming = false;
                        home.Boot();
                        break;
                    case "2":
                        PostTitleCreation();
                        break;
                    case "3":
                        PostContentCreation();
                        break;
                    default:
                        Console.WriteLine("----Invalid Input----");
                        break;
                }
            }
        }
    }
}
