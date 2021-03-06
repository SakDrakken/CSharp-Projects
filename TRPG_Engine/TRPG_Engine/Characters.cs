﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_Engine
{
    public class Characters
    {
        public int id = 0;

        public string name = null;
        public int str = 0;
        public int wis = 0;
        public int agi = 0;

        public int hp = 0;
        public int mana = 0;

        public int clss = 0;

        public static float hpmult = 0.6f;
        public static float mpmult = 0.5f;
        public int atkmod = 0;

        readonly Random choice = new Random();

        //levelup or some advancement shit
        public void AdvanceCharacter()
        {

            switch (choice.Next(1,6))
            {
                case 1:
                    Console.WriteLine(name + " has found an upgrade for his weapon. +1 ATK");
                    atkmod++; RefreshStats();
                    break;
                case 2:
                    Console.WriteLine(name + " got stronger. +1 STR");
                    str++; RefreshStats();
                    break;
                case 3:
                    Console.WriteLine(name + " got quicker. +1 AGI");
                    agi++; RefreshStats();
                    break;
                case 4:
                    Console.WriteLine(name + " got smarter. +1 WIS");
                    wis++; RefreshStats();
                    break;
                case 5:
                    Console.WriteLine(name + " has found a magic item, that increases power! +3 STR");
                    str += 3; RefreshStats();
                    break;
                case 6:
                    Console.WriteLine(name + " has found a tome, that increases all stats! +1 to all");
                    str++; agi++; wis++; atkmod++; RefreshStats();
                    break;
              }
        }

        public Characters(int id, string name, int str, int wis, int agi)
        {
            this.id = id;
            this.name = name;
            this.str = str;
            this.wis = wis;
            this.agi = agi;

            hp = Convert.ToInt32(str * hpmult);
            mana = Convert.ToInt32(wis * mpmult);

            RefreshStats();

            
        }

        public void RefreshStats()
        {
            hp = Convert.ToInt32(str * hpmult);
            mana = Convert.ToInt32(wis * mpmult);

            if (str > agi && str > wis)
                clss = 0;
            else if (agi > str && agi > wis)
                clss = 1;
            else if (wis > str && wis > agi)
                clss = 2;
            else if (wis == str && str == agi)
                clss = 0;
            else
                clss = 0;
        }
        
    }   
}
