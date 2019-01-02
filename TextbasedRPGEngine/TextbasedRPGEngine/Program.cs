using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedRPGEngine
{
    public class Program
    {

        static void Init()
        {
            Console.Title = "Super Cool TRPG Engine";
            
        }

        static void Main()
        {
            Init();
            while (true)
            {
                Commands.EvalCommand();
            }
        }
    }

    public class Commands
    {
        public static string buffer = null;

        public static object GetCommand(bool isBuffered)
        {
            if (isBuffered)
            {
                buffer = Console.ReadLine();
                return buffer;
            }
            else
            {
                return Console.ReadLine();
            }
            
        }

        public static void EvalCommand()
        {
            GetCommand(true);
            if (buffer == String.Empty || buffer.Replace(" ", "") == String.Empty)
            {
                GetCommand(true);
            }
            else
            {
                switch (buffer)
                {
                    case "help":
                        Graphics.Message("No help for you pleb.", true);                     
                        break;
                    case "start":
                        Mechanics.StartAdventure();
                        Mechanics.GetCharacter();
                        break;
                    case "restart":
                        Mechanics.isNew = !Mechanics.isNew;
                        Mechanics.StartAdventure();
                        break;
                    case "who":
                        Mechanics.GetCharacter();
                        break;
                    case "kek":
                        Graphics.Message("You kek'd.", false);
                        break;
                    default:
                        Graphics.Message("Unknown command.", true);
                        break;
                }
                
            }
        }
    }

    class Graphics
    {
        public static void Refresh()
        {
            Console.Clear();
        }

        public static void Message(string arg, bool isQuoted)
        {
            if(isQuoted)
            {
                Console.WriteLine("> " + arg);
            }
            else
            {
                Console.WriteLine("* " + arg);
            }
        }
    }

    class Mechanics
    {
        static string playername;
        static string playerclass;
        public static bool isNew = true;


        public static void StartAdventure()
        {

            if (!isNew)
            {
                Graphics.Message("Use 'restart' instead.", true);
            }

            while (isNew)
            {
                isNew = !isNew;
                Graphics.Message("Starting new adventure...", true);
                Random newAdv = new Random();              
                int rv1 = newAdv.Next(0,10);
                int rv2 = newAdv.Next(0,10);
                int rv3 = newAdv.Next(0,10);
                CreateCharacter(rv1, rv2, rv3);
            }
                     
        }

        public static void CreateCharacter(int randomValue1, int randomValue2, int randomValue3)
        {
            string[] namePool = { "Jack", "Josh", "Jake", "John", "Jay", "James", "Jonas", "Joel", "Jelly", "Justin", "Jacob"};
            playername = namePool[randomValue1];
            string[] classPool = { "Warrior", "Rogue", "Mage", "Hunter", "Shaman", "Warlock", "Necromancer", "Priest", "Spellblade", "Paladin", "Trader"};
            playerclass = classPool[randomValue2];
        }

        public static void GetCharacter()
        {
            Graphics.Message("Name: " + playername + ",the " + playerclass,true);
        }
    }

    enum NPCIDs
    {
        blank = 0,
        player = 1,
        rat = 2,
    }

    public class NPCList
    {
        
    }

    class Behavior
    {

    }

}
