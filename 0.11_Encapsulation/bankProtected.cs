using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Encapsulation
{
    class bankProtected
    {
        public void CloseAccount()
        {
            ApplyLateFees();
        }
            
        protected void ApplyLateFees()
        {
            Console.WriteLine("I want my money ");
        }
    }
}
//public              -> open to all
//protected           -> open to the class and all derived classes
//private             -> open only to the class itself
//internal            ->  open to the namespace
//protected internal  -> limited to current assembly and derived types