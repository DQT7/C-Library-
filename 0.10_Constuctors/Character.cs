using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constuctors
{
    public abstract class Character
    {
        public Character(string  username)
        {
            Username = username; 
        }
        public Character(string username, int age)
        {
           Age = age;
        }
        public Character(string username,int age,int health)
        {
            Health = health;
        }

        public int Age { get; set; }
        public string  Username{ get; set; }
        public int Health { get; set; }
    }
}
