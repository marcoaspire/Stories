using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story4
{
    class Story
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

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", Name,AuthorName,Genre,NoOfChapters,NoOfLikes,  NoOfReads);
        }
    }
}
