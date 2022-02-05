using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story4
{
    class StoryBO
    {
        public List<Story> findStory(List<Story> storyList, String authorName)
        {
            //This method accepts a list of stories and authorName as arguments
            //and returns a list of stories that matches with the given authorName. 
            List<Story> match = new List<Story>();
            

            return storyList.FindAll(a => a.AuthorName.Equals(authorName));
        }
        public List<Story> findStory(List<Story> storyList, int noOfLikes)
        {
            //This method accepts a list of stories and noOfLikes
            //as arguments and returns a list of stories that has greater likes than the given noOfLikes
            List<Story> likes = new List<Story>();
            return storyList.FindAll(a => a.NoOfLikes> noOfLikes);
        }
    }
}
