using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCalc
{
    public class Creatures
    {   
        public Creatures(int id, string name, int str, int agi, int inl, int lvl, bool dead){ }

        public static Creatures player        = new Creatures(0, "Player", 3, 3, 3, 1, false);
        public static Creatures importedchar  = new Creatures(1, "Rat", 1, 5, 1, 1, false);
    }
}
