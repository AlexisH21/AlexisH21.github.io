using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading;


namespace AdventureGame
{
    
        class Fairy
        {
            string Name;
            string SkinTone;
            string HairTexture;
            string Haircolor;
            string EyeColor;
            string DressMaterial;
            

            public Fairy(string name, string skintone, string hairtexture, string haircolor, string eyecolor, string dressmaterial)
            {

                Name = name;
                SkinTone = skintone;
                HairTexture = hairtexture;
                Haircolor = haircolor;
                EyeColor = eyecolor;
                DressMaterial = dressmaterial;
                
            }
         
        public void Dialogue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ???: What are you doing out here all alone at this time of night? Are you lost??");
            Thread.Sleep(1000);
            Console.WriteLine(" ???: What's your name?");
            Console.ResetColor();
        }
            public void Description1()
            {
                Console.WriteLine($" You're exhausted and decide to stay by the stump over night. \n You curl up resting up against the stump as you start to dose off, you hear russling from infront of you and open your eyes to see a beautiful women with long {Haircolor}{HairTexture} hair, skinTone skin and mesmerasing {EyeColor}  eyes. \n  She stares at you curiously and and steps closer to you; you notice she's wearing a dress made from {DressMaterial}. ");
               

            }
            public void Description2()
            {
            Console.ForegroundColor = ConsoleColor.White;
              Console.WriteLine($" The sun is low in the sky and with no home in sight you relize you must find somewhere to camp for the night. You hear movement in the forest behind you and spin around to face whatever made that sound. \n You see a women... \n A women with {EyeColor} eyes and long {HairTexture} {Haircolor} hair standing infront of you. \n With her hands hands clasped behind her back she walks gracefully toward you.");
            }
        public void Dialogue3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Name}: Of course you can have more! Eat as much as you'd like.");
        }
        public void Dialogue1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Name}: Oh, You can call me {Name}. If you need help I can help you afer you've gotten some rest.");
        }
        public void Description4()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" Her long {Haircolor} {HairTexture} falling into her face and covering parts of her beautiful {EyeColor} eyes as she does so. \n Her {SkinTone} skin is backlight by the moon as she stares at you. You feel like you could stare at she other worldly presents for ever.");
            Thread.Sleep(1000);
            Console.WriteLine(" You hear another noise off in the woods and snap out of your trance.");
        }
        public void Dialogue2()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($" {Name}: Are you getting sleepy? you look sleepy.");
        }
        public void Narrorator()
        {
            Console.WriteLine($" You wake up in a soft bed made of moss and hear {Name} speak from across the room.");
            Thread.Sleep(1000);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($" {Name}: Oh good you're awake.");
            Console.ResetColor();
            Console.WriteLine(" She says sweetly.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Name}: Here eat something. you must be starving.");
            Console.ResetColor();
            Console.WriteLine(" She hands you a bowl of what appears to be a warm bowl of oats with an egg and some roasted veggies in it.");
            Thread.Sleep(1000);
            Console.WriteLine(" You take the garcously take the bowl of oats and begin eating. She stares at you eagerly as you eat.");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine(" The bowl of oats she gave you is the BEST food you've ever tasted. \n Instead of becoming full. Each bite you take makes you hungier. Before you know it you've devoured the food she gave you feeling worse then when you started eating. \n");
            
        }
        public void Dialogue5()
        {
           Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($" {Name}: Do you need some help? I can help you.");
            Thread.Sleep(1000);
        }
        public void Dialogue6(string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Name}: Of couse I can help you find your way home {playerName}.");
        }
        public void Dialogue7()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Name}: Just follow me and you'll get home.");
        }
        public void Dialogue8(string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" ???: ...Well, It's lovely to meet you {playerName}.");
        }
        public void Dialogue9(string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" ???: Well, It's lovely to meet you {playerName}! \n Let me take you back to my home you look exhausted.");
            Thread.Sleep(2000);
        }
    }
      

    //public string FairyName1 { get => fairyName; set => fairyName = value; }
    //"Absinthe", "Belladonna", "Arachna", "Olette", "Fern", "Sparrow", "Coni", "Aspen", "Birdie", "Holly", "Dove", "Mouse", "Quil"
    

    /* Random random = new Random();
           //                  0        1       2        3       4        6       7         8         9            10          11     12
     string fairyName[] = { "Holly", "Poppy", "Raven", "Moss", "Fern", "Alvar", "Iara", "Begonia", "Willow", "HummingBird", "Quil", "Birch" };
     int fairyname = Random.Next(0,fairyName.Length);
     Console.WriteLine("she name is {}",fairyName[fairyname]);
    */


}