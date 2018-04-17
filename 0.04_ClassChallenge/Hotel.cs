using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ClassChallenge
{
    class Hotel
    {
        public bool isAvailable { get; set;}
        public int NumBeds { get; set; }
        public string RoomNumber { get; set; }

        public void CheckAvailability()
        {
            if (isAvailable)
                Console.WriteLine("{0} is available", RoomNumber);
        }
        else
        Console.WriteLine("")


    }
}
