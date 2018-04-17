using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {


            Character dq = new Character();
            dq.HealAlly();
            Player joe = new Player();
            joe.HealAlly();

            Console.ReadLine();

        }
    }
}
