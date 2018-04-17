using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Tom = new Player();

            Tom.Attack();
            Tom.Attack(5);


            Console.ReadLine();
        }
   
    }
}
