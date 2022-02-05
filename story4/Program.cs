using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story4
{
    //Filter data from a list, By author  or  by number of likes.
    //Example of stories
    //who are u to me ?,Chatan,Romance,12, 4000, 4990
    //Hold on,TRTells,Horror,15, 3000, 3333
    //Dark witch,Fanny,Action,8, 2000, 2759
    //Pirate's Life,Lauren,Romance,25, 2500, 2631
    //Dark witch2,Fanny,Action,8, 2000, 2759
    class Program
    {
        static void Main(string[] args)
        {
            List<Story> list = new List<Story>();
            StoryBO sBO = new StoryBO();
            List<Story> match= null;
            string[] story;
            Story story1;
            Console.WriteLine("Enter the number of stories");
            try
            {
                int number = Int32.Parse(Console.ReadLine());
                for (int count = 0; count < number; count++)
                {
                    story = Console.ReadLine().Split(',');
                    story1 = new Story(story[0], story[1], story[2], Int32.Parse(story[3]), Int32.Parse(story[4]), Int32.Parse(story[5]));
                    list.Add(story1);
                }
                Console.WriteLine("Enter a search type: ");
                Console.WriteLine("1.By author");
                Console.WriteLine("2.By number of likes\n");
                number = Int32.Parse(Console.ReadLine());
                if (number==1)
                {
                    Console.WriteLine("Enter the author name:");
                    string author = Console.ReadLine();
                    match = sBO.findStory(list, author);
                }
                else if (number==2)
                {
                    Console.WriteLine("Enter the number of likes:");
                    int likes = Int32.Parse(Console.ReadLine());
                    match = sBO.findStory(list, likes);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                if (match.Count > 0)
                {
                    Console.WriteLine("Name\t\t\tAuthor\tGenre\tNoOfChapters\tNoOfLikes\tNoOfReads");
                    foreach (var item in match)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                    
                else
                    Console.WriteLine("No such story is present");
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }

            
            
            Console.ReadKey();
        }
    }
}
