using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Story3;

namespace story3
{
    //Count how many times a value appears in a list and return a SortedList. 
    class Program
    {
        static void Main(string[] args)
        {
            string[] story;
            Story story1;
            ///3
            List<Story> list = new List<Story>();
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
                SortedList<string, int> stories = Story.genreWiseCount(list);
                Console.WriteLine("Genre\tCount");
                foreach (var item in stories)
                {
                    Console.WriteLine("{0}\t{1}",item.Key,item.Value);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
            
            Console.ReadKey();

        }
    }
}
