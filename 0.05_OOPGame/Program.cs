using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOPGame
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome Soldier. Whats your Name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("What would you like your gamername to be ?");
            string gamerName = Console.ReadLine();
            Console.WriteLine("what is your Type? \n" +
                "1:barbarian\n" +
                "2:Monkey\n" +
                "3:Ninja Spirit\n");
            int parseType = int.Parse(Console.ReadLine());
            Console.WriteLine(gamerName);



        
            Creature zed = new Creature("zed",100,10,true);

            Player DQ = new Player("DQ",100,7);
            
        }
    }
}
