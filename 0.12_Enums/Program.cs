using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Enums
{
    class Program
    {
        static void Main(string[] args)
          
        {
            Weekday day = Weekday.Friday;

            
            switch (day)
               
            {
                case Weekday.monday:
                    Console.Write("poridge black cast member ");
                    break;
                case Weekday.Tuesday:
                    Console.Write("purple rain ");
                    break;
                case Weekday.Wednesday:
                    Console.Write("right gap");
                    break;
                case Weekday.Thursday:
                    Console.Write("ian the baldr ");
                    break;
                case Weekday.Friday:
                    Console.Write("poridge black cast ");
                    break;
                case Weekday.saturday:
                    Console.Write("black cast member ");
                    break;
                case Weekday.sunday:
                    Console.Write("simple punch ");
                    break;
                default:
                    break;

                    Console.ReadLine();

            }
        }
    }

    enum Weekday

    {
        monday=0,
        Tuesday = 1,
        Wednesday =2,
        Thursday = 3,
        Friday =4,
        saturday=5,
        sunday = 6,
       
    }

}
