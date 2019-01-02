using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TRPG_Engine
{
    class Program
    {
        public static List<Characters> Character = new List<Characters>();

        public static string GetStringClss(int clss)
        {           
            if (clss == 1)
                return "Rogue";
            if (clss == 2)
                return "Wizard";
            else
                return "Warrior";
        }


        static int InitDB()
        {
            Character.Add(new Characters(0, "Player", 4, 3, 3));
            Character.Add(new Characters(1, "Rat", 2, 1, 1));
            Character.Add(new Characters(2, "Bear", 4, 3, 1));
            Character.Add(new Characters(3, "Bandit", 1, 1, 5));
            Character.Add(new Characters(4, "Bandit Healer", 1, 4, 1));
            Character.Add(new Characters(5, "Bandit Boss", 10, 10, 10));
            return 0;           
        }

        static void TestDB()
        {
            try
            {
                foreach (Characters id in Character)
                {
                    Console.WriteLine(
                           id.name + "\n" +
                           id.str + " | " +
                           id.wis + " | " +
                           id.agi + " | " +
                           id.hp + " hp | " +
                           id.mana + " mp | " +
                           GetStringClss(id.clss)
                           );
                }
            }
            catch (Exception)
            {
                //let it just fail silently
            }
        }

        static void GameOver()
        {
            Console.WriteLine("\n\n\n YOU DIED\n\n\n PRESS ANY KEY TO EXIT");

            Console.ReadKey();
            Environment.Exit(0);
        }

        static bool DetermineTurns(Characters a, Characters b)
        {
            if (a.agi < b.agi)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void FightRound(Characters a, Characters b)
        {
            bool afirst = DetermineTurns(a, b);

            if (afirst)
            {
                int dmg = Convert.ToInt32(a.str * 0.3) + a.atkmod;
                if (dmg >= 0)
                {
                    b.hp -= dmg;
                    Console.WriteLine(b.name + " takes " + dmg + " damage.");
                }
                else
                {
                    Console.WriteLine(b.name + " takes 0 damage.");
                }

                if (b.hp > 0)
                {
                    dmg = Convert.ToInt32(b.str * 0.3) + b.atkmod - Convert.ToInt32(a.agi * 0.3f);
                    if (dmg >= 0)
                    {
                        a.hp -= dmg;
                        Console.WriteLine(a.name + " takes " + dmg + " damage.");
                    }
                    else
                    {
                        Console.WriteLine(a.name + " takes 0 damage.");
                    }
                }
            }
            else
            {
                int dmg = Convert.ToInt32(b.str * 0.3) + b.atkmod - Convert.ToInt32(a.agi * 0.3f);
                if (dmg >= 0)
                {
                    a.hp -= dmg;
                    Console.WriteLine(a.name + " takes " + dmg + " damage.");
                }
                else
                {
                    Console.WriteLine(a.name + " takes 0 damage.");
                }


                if (a.hp > 0)
                {
                    dmg = Convert.ToInt32(a.str * 0.3) + a.atkmod;
                    if (dmg >= 0)
                    {
                        b.hp -= dmg;
                        Console.WriteLine(b.name + " takes " + dmg + " damage.");
                    }
                    else
                    {
                        Console.WriteLine(b.name + " takes 0 damage.");
                    }
                    
                }
            }

        }

        static void Fight(Characters a, Characters b)
        {
            Console.WriteLine("\n" + a.name + " approaches " + b.name + "!");

            while (a.hp > 0 && b.hp > 0)
            {
                FightRound(a,b);
            }

            if (a.hp <= 0)
            {
                GameOver();
            }
            else if (b.hp <= 0)
            {
                Console.WriteLine(a.name + " won the fight. " + b.name + " was defeated.");
                a.AdvanceCharacter();
            }         
        }

        static void TestFight()
        {
            Fight(Character[0], Character[1]);
            Fight(Character[0], Character[2]);
            Fight(Character[0], Character[3]);
            Fight(Character[0], Character[4]);
        }

        private static readonly string[] names 
            = new string[21] { "Bandit", "Fiery", "Hexxed", "Troll", "Mutated", "Sleepy", "Sneaky", "Orcish",
                               "Demented", "Grown", "Ethernal", "Devilish", "Manly", "Girlish", "Small",
                               "Autistic", "Tiny", "Buffed", "Burning", "Slimy", "Sweaty"};
        private static readonly string[] suffix 
            = new string[14] { "Scoundrel", "Guard", "Kobold", "Mage", "Warrior", "Thief", "Cleric", "Paladin",
                                "Bear", "Scorpion", "Imp", "Demon", "Spider", "Elemental"};


        static void ProcNPCs(int count)
        {
            int level = 6;
            Random rnd = new Random();
            for (int i = 6; i <= (count + 6); i++)
            {
                string name = names[rnd.Next(1, names.Length)] + " " + suffix[rnd.Next(1, suffix.Length)];
                Character.Add(new Characters(i, name, rnd.Next(1, level), rnd.Next(1, level), rnd.Next(1, level)));
                level += 3;
            }
        }

        static void Intro()
        {
            Console.Write("Samohra TRPG\n\nEnter your name: ");
            Character[0].name = Console.ReadLine();
            Console.WriteLine("You chose " + Character[0].name + " as your name.\nPress any key to continue.");
            Console.ReadKey();
        }

        static void Main()
        {
            InitDB();
            ProcNPCs(60);
            int i = 1;

            //TestDB();
            //TestFight();

            Intro();

            while (true)
            {
                if (i < Character.Count)
                {
                    Console.WriteLine("\n\nLEVEL " + i);
                    Character[0].RefreshStats();
                    Console.WriteLine(
                           Character[0].name + "\n" +
                           Character[0].str + " STR | " +
                           Character[0].wis + " WIS | " +
                           Character[0].agi + " AGI | " +
                           Character[0].hp + " hp | " +
                           GetStringClss(Character[0].clss)
                           );

                    Fight(Character[0], Character[i]);
                    i++;
                }
            }
        }
    }
}

