using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story5
{
    //Sort a list using IComparable and IComparer interfaces. Sort by Name or by No. of Reads
    class Program
    {
        static void Main(string[] args)
        {
            List<Story> list = new List<Story>();
            string[] story;
            Story story1;
            Console.WriteLine("Enter the number of stories");
            try
            {
                int number = Int32.Parse(Console.ReadLine());
                for (int count = 0; count < number; count++)
                {
                    story1 = createStory(Console.ReadLine());
                    list.Add(story1);
                }
                Console.WriteLine("Enter a type to sort");
                Console.WriteLine("1.Sort by Name");
                Console.WriteLine("2.Sort by No. of Reads");
                number = Int32.Parse(Console.ReadLine());
                if (number == 1)
                {
                    list.Sort();
                }
                else if (number == 2)
                {
                    list.Sort(Story.SortNoOfReads());
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }



            Console.ReadKey();

        }
       
        
        static Story createStory(String detail)
        {
            //This method accepts a String. The story detail separated
            //by commas is passed as the argument. Split the details and create a story object and returns it.
            string[] story; 
            story = detail.Split(',');
            return new Story(story[0], story[1], story[2], Int32.Parse(story[3]), Int32.Parse(story[4]), Int32.Parse(story[5]));

        }
        
        
    }
}
