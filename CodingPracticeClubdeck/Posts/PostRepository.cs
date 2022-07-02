using System.Collections.Generic;

namespace CodingPracticeClubdeck
{
    public class PostRepository
    {
        private static readonly List<PostServices> PostList = new List<PostServices>();

        public void AddPost(string postTitle, string postContent, string postTime, string authorAccount)
        {
            PostList.Add(new PostServices
            {
                PostTitle = postTitle,
                PostContent = postContent,
                PostTime = postTime,
                AuthorAccount = authorAccount
            });
        }

    }
}

