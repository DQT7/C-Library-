using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ClassChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel guest = new Hotel();
            guest.RoomNumber = 50;
            guest.isAvailable = true;
            guest.CheckAvailablity();
            Console.WriteLine("Your room number is " + guest.RoomNumber);
        }
      
    }
}
