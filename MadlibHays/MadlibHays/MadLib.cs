using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MadlibHays
{
    static class MadLib
    {
        //declare variables
        static string Creature;
        static string Luminous;
        static string Ghastly;
        static string Spectral;
        static string Countryman;
        static string Farrier;
        static string Farmer;
        static string Dreadful;
        static string Apparition;
        static string Hound;
        static string Story;

        public static void Run()
        {
            Console.WriteLine("+--------+");
            Console.WriteLine("| MADLIB |");
            Console.WriteLine("+--------+");

            //ask player to enter words
            Console.WriteLine("Please enter a NOUN:  ");
            Creature = Console.ReadLine();
            Console.Write("Please enter an ADJECTIVE: ");
            Luminous = Console.ReadLine();

            Console.Write("Please enter an ADJECTIVE: ");
            Ghastly = Console.ReadLine();

            Console.Write("Please enter an ADJECTIVE: ");
            Spectral = Console.ReadLine();

            Console.Write("Please enter an OCCUPATION: ");
            Countryman = Console.ReadLine();

            Console.Write("Please enter an OCCUPATION: ");
            Farrier = Console.ReadLine();

            Console.Write("Please enter an OCCUPATION: ");
            Farmer = Console.ReadLine();

            Console.Write("Please enter an ADJECTIVE: ");
            Dreadful = Console.ReadLine();

            Console.Write("Please enter a NOUN: ");
            Apparition = Console.ReadLine();

            Console.Write("Please enter a NOUN: ");
            Hound = Console.ReadLine();

            //write out finished story
            Story = "While on an evening stroll the " + Countryman + "," + Farrier + ", and the " + Farmer + " all met up for a chat about the " + Spectral + " " + Apparition + " that had been appearing throughout the small town of. " + Creature + " The " + Farrier + " said they heard " + Ghastly + " " + Hound + "'s late at night all the way from their " + Luminous + " House by the sea. The " + Farmer + " and the " + Countryman + " both expressed to their friend how " + Dreadful + " it must be to hear " + Ghastly + " " + Hound + "'s all night... After talking for quite some time everyone parted ways and went home.";
            Console.WriteLine(Story);

            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit the game.");
            Console.ReadKey();
        }
    }
}
