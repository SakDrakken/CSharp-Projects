using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGTest
{
    public class Mechanics
    {
        public class Character : Mechanics
        {
            public byte ID = 0;
            public string name = null;
            public int str = agi = inl = xp = 0, lvl = 1;

            public Character(byte ID, string name, int str, int agi, int inl, int xp, int lvl) : this()
            {
                this.ID = 0;
                this.name = String.Empty();
                this.str = 1;
                this.agi = 1;
                this.inl = 1;
                this.xp = 0;
                this.lvl = 1;

            }
        }

        static Character player = new Character(0, "Player", 1, 1, 1, 0, 1);
       
    }
}

