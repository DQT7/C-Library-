using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOPGame
{
    class Player: Character
    {
        //constuctor
        public Player(string firstName, int playerLevel, int currentPowerLevel)
        {
            this.PlayerName = firstName;
            this.CurrentPower = currentPowerLevel ;
            this.Level = playerLevel;

        }
        public string PlayerName { get; set; }
   
    }
}
