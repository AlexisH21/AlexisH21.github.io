using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;


namespace StudyApplicationHays
{

    class StudyGroupSystem
    {
        List<Classmate> MyGroup;

        public StudyGroupSystem()
        {
           MyGroup = new List<Classmate>();
           
        }
        public void Run()
        {
            WriteLine("== My Study Group ==");

                string addResponse;
                do
                {
                    Write("Do you want to add someone to your study group?  (yes/no)");
                    addResponse = ReadLine().Trim().ToLower();
                    if(addResponse == "yes")
                    {
                        Write("What is the classmate's name? ");
                        string name = ReadLine().Trim();
                        Write("What class are they from?  (english/ math/ science)");
                        string gradeClass = ReadLine().Trim();
                        Write("What level are they in the class?");
                        int level = Convert.ToInt32(ReadLine());//may cause an error.
                        Classmate newClassmate = new Classmate(name, gradeClass, level);
                        MyGroup.Add(newClassmate);
                        WriteLine("Added!!");
                    }
                } while (addResponse == "yes");
                //Display the group.
                WriteLine("\n Awesome, You're study group is: ");
                foreach(Classmate currentclassmate in MyGroup)
                {
                    currentclassmate.DisplayInfo();

                }
                
        }
    }
    
}



