using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story5
{
    class Story: IComparable
    {

        private String name;
        private String authorName;
        private String genre;
        private int noOfChapters;
        private int noOfLikes;
        private int noOfReads;

        public Story()
        {
        }
        public Story(string name, string authorName, string genre, int noOfChapters, int noOfLikes, int noOfReads)
        {
            this.Name = name;
            this.AuthorName = authorName;
            this.Genre = genre;
            this.NoOfChapters = noOfChapters;
            this.NoOfLikes = noOfLikes;
            this.NoOfReads = noOfReads;
        }

        public string Name { get => name; set => name = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NoOfChapters { get => noOfChapters; set => noOfChapters = value; }
        public int NoOfLikes { get => noOfLikes; set => noOfLikes = value; }
        public int NoOfReads { get => noOfReads; set => noOfReads = value; }

        public int CompareTo(object obj)
        {
            Story story = obj as Story;
            return String.Compare(this.Name, story.Name);
        }

        public static IComparer<Story> SortNoOfReads()
        {
            return (IComparer<Story>)new NoOfReadsComparator();
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", Name,AuthorName,Genre,NoOfChapters,NoOfLikes,  NoOfReads);
        }
        public static Story createStory(String detail)
        {
            //This method accepts a String. The story detail separated
            //by commas is passed as the argument. Split the details and create a story object and returns it.
            string[] story;
            story = detail.Split(',');
            return new Story(story[0], story[1], story[2], Int32.Parse(story[3]), Int32.Parse(story[4]), Int32.Parse(story[5]));

        }
    }
}
