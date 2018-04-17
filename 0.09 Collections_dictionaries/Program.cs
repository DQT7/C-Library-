using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Challenge 
BRONZE:
Create a Dictionary that has all of the academy award winners for best picture from 2000-2005.
Iterate over that dictionary and print it to the console.
SILVER: 
Create a Dictionary of Best Picture Nominees that has the year as the key and an array of movies as the values for the same years.
Iterate over that Dictionary and print the values to the console.
GOLD:
Create two Readline prompts in the console. The first one should say this:
    
    Please type a year in the space below to show the movie that won:
    >
Then after entering a number, you should be able to enter another number and list out all the nominees for a year.
    Please type a year to show the movies that were up for an award that year:
    >
    
*/

namespace _0._09_Collections_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> AWW = new Dictionary<int, string>();
            AWW.Add(2000, "American Beauty");
            AWW.Add(2001, "Gladiator");
            AWW.Add(2002, "Beautiful Mind");
            AWW.Add(2003, "Chicago");
            AWW.Add(2004, "Lord of the Rings: The Return of the King");
            AWW.Add(2005, "Million Dollar Baby");

            foreach (KeyValuePair<int, string> pair in AWW)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                Console.WriteLine("                                         ");
                Console.WriteLine("                                         ");
                Console.ReadLine();
            }

        };

        var AWN = new Dictionary<string, string>()
            { 
              {"2001", "CROUCHING TIGER, HIDDEN DRAGON,ERIN BROCKOVICH,CHOCOLAT,TRAFFIC"},
                { "2002", "IN THE BEDROOM,GOSFORD PARK,THE LORD OF THE RINGS: THE FELLOWSHIP OF THE RING,MOULIN ROUGE"},
            };
            
        }

        //private static void NewMethod(IDictiona<string, string> AWN)
        {
            foreach (KeyValuePair<string, string> pair in AWN)
            {
                Console.WriteLine("{0}:{1}", pair.Key, pair.Value);
              
        }
    }
}
