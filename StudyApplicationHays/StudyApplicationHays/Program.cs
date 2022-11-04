using System;
using System.Collections.Generic;
using static System.Console;


namespace StudyApplicationHays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "=== Study Application Assignment ===";

          //  List<string> inventory = new List<string>();
          //  WriteLine($" you currently have {inventory.Count} items.");


          //  inventory.Add("A NoteBook");
          //  inventory.Add("A PencilBag");
          //  inventory.Add("A BookBag");
          //  inventory.Add("A Stick of gum");
          //  inventory.Add("A HairBand");
          //  inventory.Add("A CellPhone");
          //  //inventory.RemoveAt(0); // removes first item in list

          //  WriteLine(" What item would you like to have in your inventory?");
          //  string response = ReadLine().Trim();
          //  inventory.Add(response);

          //  WriteLine($" you currently have {inventory.Count} items.");
          //  WriteLine($"Is A Stick of gum in the list?{inventory.Contains("A Stick of gum")}");

          //  for(int i = 0; i < inventory.Count; i++)
          //  {
          //      WriteLine($">{inventory[i]}");
          //  }
          ////  foreach (string item in inventory)
          ////  {
          ////      WriteLine($">{item}");
          ////  }

            StudyGroupSystem studyGroupSystem = new StudyGroupSystem();
            studyGroupSystem.Run();


            //WriteLine(" Lets Study! \n \n Press any key to exit.");
            //ReadKey();

        }
    }
}
