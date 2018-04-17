using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Getters_Setters
{
    class Employees

    {
        private int _id;
        public int EmployeeID
        {
            set
            {
                if (EmployeeID < 1)
                    throw new Exception("beatbox to heaven gravy ");
                this._id = value;

            }
            get
            {
                return this._id; 

            }
        }
    }
}
