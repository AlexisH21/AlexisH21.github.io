using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventureGame
{
    internal class Player
    {


        public string PlayerName { get; set; }

        public Player(string playerName)
        {
            PlayerName = playerName;

        }

        public int Politnesspoints;

        public Player(int politnesspoints)
        {
            Politnesspoints = politnesspoints;
        }

       
        //Talking dialogue. I would have loved to put this in a class called Talking but I was unable to figure out how to make it work in time to turn this in.
            internal static void PlayerDialogue()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" Y/N: Sorry, Can you please come play with me?");
                Thread.Sleep(2000);
            }
            internal static void PlayerDialogue1()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" Y/N: Yes please. :)");
            }
            internal static void PlayerDialogue2()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" Y/N: Come on Harper! I'm gonna win!! RUN FASTER!!");
                Thread.Sleep(1000);
            }
            internal static void PlayerDialogue3()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Thread.Sleep(2000);
                Console.WriteLine(" Y/N: HELLO!! HARPER?! WHERE ARE YOU?!?!...CAN YOU HEAR ME?! HELLO!?");
            }
            internal static void PlayerDialogue4(string playerName)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" {playerName}: You can call me {playerName}.");
            }
            internal static void PlayerDialogue5(string playerName)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" {playerName}: My name is {playerName}.");
            }
            internal static void PlayerDialogue6(string playerName)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" {playerName}: Yes, I'm lost. Can you help me find my way back home?");
            }
            internal static void PlayerDialogue7(string playerName)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" {playerName}: What's your name? I need to go home.");
            }
            internal static void PlayerDialogue8(string playerName)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" {playerName}: ...That's a beautiful name.");
                Thread.Sleep(1000);
            }
            internal static void PlayerDialogue9(string playerName)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" {playerName}: Can I have more? I'm still hungry.");
            }
        
       
        public class Politness
        {
            public static int counter;

        }

    
    }
}



