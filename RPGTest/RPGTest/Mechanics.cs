using System;

namespace RPGTest
{
    public class Mechanics
    {
        public struct Character
        {
            public int ID;
            public string name;
            public int str, agi, inl, xp, lvl;


            public Character(int ID, string name, int str, int agi, int inl, int xp, int lvl) : this()
            {
                this.ID = 0;
                this.name = String.Empty;
                this.str = 1;
                this.agi = 1;
                this.inl = 1;
                this.xp = 0;
                this.lvl = 1;

            }
        }

        static Character player = new Character(0, "Player", 1, 1, 1, 0, 1);

        Character[] npc = new Character[16];

    }
}

