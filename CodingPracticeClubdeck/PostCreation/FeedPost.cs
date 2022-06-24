using System;
using System.Collections.Generic;
using System.Globalization;

namespace CodingPracticeClubdeck
{
    public class FeedPost
    {
        private string _postTitle;
        private string _postContent;
        private DateTime _dateTime = new DateTime();
        private DateTime _now = DateTime.Now;
        
        public void CreateFeedPost()
        {
            PostTitle();
            PostContent();
            PostConfirmation();
        }
        private void PostTitle()
        {
            System.Console.WriteLine("\n<Create Feed Post: Title> (1/3)\nPost Title:");

            while (true)
            {
                string _title = System.Console.ReadLine().Trim();
                int _charLimit = 50;
              

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
                    _postTitle = textInfo.ToTitleCase(_title);
                    break;
                }
            }
        }
        private void PostContent()
        {
            System.Console.WriteLine("\n<Create Feed Post: Content> (2/3)\nPost Content:");

            while (true)
            {
                string _content = System.Console.ReadLine();
                int _charLimit = 100;

                if (string.IsNullOrEmpty(_content))
                {
                    System.Console.WriteLine("----Content is Required----");
                }
                else if (_content.Length > _charLimit)
                {
                    System.Console.WriteLine("----Title Exceeds Character Limit----");
                }
                else
                {
                    _postContent = _content.Trim();
                    break;
                }
            }
        }
        private void PostConfirmation()
        {
            System.Console.WriteLine(
                "\n<Feed Post Confirmation (3/3)>\n" +
                _now + "\n" +
                //do what you have to to make the date time more readable. Do something specific.
                 _postTitle + "\n" +
                _postContent + "\n" +
                "[1: Confirm and Post] [2: Edit Title] [3: Edit Content] [4: Cancel]");
        }

        private void Research(string _postTitleData, string _postContentData)
        {
            var postTitleData = new List<string>();
            var postContentData = new List<string>();

            foreach (var word in _postTitleData.Split(' ')) 
                //perhaps split each post title into one iteration
                //of the list, then make recommendations like: see
                //posts related to: "This is what I put as my post title!!" ?
            {
                
            }

            //create class that returns a profile score to be used in feed,
            //recommending posts based on what they type
        }
        
    }
}
