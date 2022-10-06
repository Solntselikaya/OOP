using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{

    internal class Printer 
    {
        public void PrintTimeTableOfGroup(string number)
        {
            Console.WriteLine($"Schedule of group �{number}");
            Console.WriteLine(" ");
            Console.WriteLine("Monday");
            PrintDayTimetable(0, number);
            Console.WriteLine("Tuesday");
            PrintDayTimetable(1, number);
            Console.WriteLine("Wednesday");
            PrintDayTimetable(2, number);
            Console.WriteLine("Thursday");
            PrintDayTimetable(3, number);
            Console.WriteLine("Friday");
            PrintDayTimetable(4, number);
            Console.WriteLine("Saturday");
            PrintDayTimetable(5, number);
        }

        private void PrintDayTimetable(int day, string number)
        {
            Timetable nowTimetable = Schedule.schedule[number];
            for (int i = 0; i < 7; i++)
            {
                switch (nowTimetable[day,i].lessonType)
                {
                    case "Lecture":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "Seminar":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Practice":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case "Lab":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "Test":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine($"Lesson �{i} - {nowTimetable[day,i].name}");
                Console.WriteLine($"Classroom �{nowTimetable[day, i].classroom}");
                Console.WriteLine($"Teacher - {nowTimetable[day, i].teacher}");
                Console.WriteLine(" ");
                Console.ResetColor();
            }
        }
    }
}