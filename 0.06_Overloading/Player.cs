using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Overloading
{
    class Player
    {
        public void Attack()
        {
            Console.WriteLine("the player attacked for points");
        }
        public void Attack(int points)
        {
            Console.WriteLine("The player attack for {0} points", points);
        }
        public void Attack(string weaponType, int points)
        {
            Console.WriteLine("The player attacked for {0} points with the {1}", weaponType, points);
        }

    }
}
