using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;



namespace StudyApplicationHays
{
    public class Classmate
    {
        private string Name;
        private string GradeClass;
        private int Level;

        public Classmate(string name, string gradeClass, int level)
        {
            Name = name;
            GradeClass = gradeClass;
            Level = level;
        }

        //new Classmate("Cindy", "Math", ConsoleColor.Blue, 10),
        //new Classmate("Owen", "Science", ConsoleColor.Green, 40),
        //new Classmate("Stacy", "English", ConsoleColor.Red, 12)};

        public void DisplayInfo()
        {
            
            WriteLine($">{Name}<");
            WriteLine($"Level in {GradeClass}:{Level}");
            
        }
    }
}