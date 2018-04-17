using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var classList = new List<string>();
            classList.Add("dq");
            classList.Add("adam");
            classList.Add("ian");
            classList.Add("6God");
            foreach(var member in classList)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine(classList.Capacity);


            ArrayList highScores = new ArrayList();
            highScores.Add(2500);
            highScores.Add(4500);
            highScores.Add(10000);
            //          2        3          
            foreach (int i in highScores)
                //              4
                Console.WriteLine(i);
            Console.WriteLine(classList.Capacity);
            Console.ReadLine();
        }
    }
}
