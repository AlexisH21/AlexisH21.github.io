using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Game
    {
        int Guess = 0;
        int Target = 6;
        string Input = "";
        string[] Words = { "cat", "hat", "rat", "bat" };
        Random RandomNumber = new Random();
        public void Play()
        {
            Target = RandomNumber.Next(Words.Length);
            Console.WriteLine("Can you guess what word I'm thinking of ?!");
            for (int i = 0; i < Words.Length; i++)
            {
                if (i == (Words.Length - 1))
                    Console.Write("or " + Words[i] + "? ");
                else
                    Console.Write(Words[i] + ", ");
            }
            Input = Console.ReadLine();
            if(Input == Words[Target])
            {
                Console.WriteLine(" Congrats!! You guessed CORRECT!!");
               
            }
            else
            {
                Console.WriteLine(" Oh No! That was incorrect :( \n  Press Enter to continue.");
                Console.ReadLine();
                Play();
            }
            Console.ReadKey();
        }
         
    }
}
