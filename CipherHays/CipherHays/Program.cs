using System;

namespace CipherHays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher = new Cipher();
            //Greet user with information
            cipher.Greeting();
        }

        internal class Cipher
        {
            string Alphabet = "abcdefghijklmnopqrstuvwxyz";
            string Substitute = "qedcjalmnfgzoswtvbhixypk";

            //Greeting
            public void Greeting()
            {
                Console.WriteLine("Welcome to the cipher projet!");
                Console.WriteLine("Do you want to encode or decode a message? A) encode, B) decode");

                string UserInput = Console.ReadLine();
                UserInput.ToUpper();
                if (UserInput.ToUpper() == "A")
                {
                    Encode();

                }
                else if (UserInput.ToUpper() == "B")
                {
                    Decode();
                }
                else
                {
                    Greeting();
                }

            }
            //refrenced: https://www.programmingalgorithms.com/algorithm/simple-substitution-cipher/
            public void Encode()
            {
                char[] AlphabetAsArray = Alphabet.ToCharArray();
                char[] SubstituteAsArray = Substitute.ToCharArray();

                Console.WriteLine("Type your message.");

                
                string message = Console.ReadLine();
                char[] messageAsArray = message.ToCharArray();
                for (int i = 0; i < messageAsArray.Length; i++)
                {
                    int oldCharIndex = Alphabet.IndexOf(char.ToLower(messageAsArray[i]));
                    if (oldCharIndex >= 0)
                    {//why is this giving an error???
                      out message += char.IsUpper(messageAsArray[i]) ? char.ToUpper(Alphabet[oldCharIndex]) : Substitute[oldCharIndex];
                    }
                    else
                    {

                    }
                    
         
                }

            }
            public void Decode()
            {
                char[] AlphabetAsArray = Alphabet.ToCharArray();
                char[] SubstituteAsArray = Substitute.ToCharArray();

                Console.WriteLine("Type your message.");
                string message = Console.ReadLine();
            }
        }

    }
}
