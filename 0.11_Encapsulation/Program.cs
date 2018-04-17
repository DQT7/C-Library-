using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks
using _0._05_OOPGame;

namespace _0._11_Encapsulation
{
    class Program
    {
       static void Main(string[] args)
        {
            bank_public chase = new bank_public();
            decimal Amount = chase.GetAmount();
            Console.WriteLine("Your balance is : {0}", Amount);

            bankProtected bp = new bankProtected();
            Creature steve = new Crea ture();



        }
    }
}
