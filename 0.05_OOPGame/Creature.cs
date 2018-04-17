using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOPGame
{
    public class Creature: Character
    {
        public Creature (string firstName,int creatureLevel, int creaturePowerlevel,bool cPL)
        {
            CreatureName = firstName;
            this.CurrentPower = creaturePowerlevel;
            this.Level = creatureLevel;
            this.IsLowOnPower = cPL;
        }
        public string CreatureName { get; set; }

    }
}
