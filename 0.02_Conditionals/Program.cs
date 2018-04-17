using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = "DQ";
            switch (student)
            {
                case "DQ":
                    Console.WriteLine(" This is the right choice");
                    break;
                case "Ray":
                    Console.WriteLine("Hey Ray");
                    break;
            }

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
