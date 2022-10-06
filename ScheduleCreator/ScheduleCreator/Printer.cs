using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{

    internal class Printer 
    {
        public void PrintTimetableOfGroup(string number)
        {
            Console.WriteLine($"Schedule of group ¹{number}");
            Console.WriteLine(" ");
            Console.WriteLine("Monday");
            printDayTimetable(0, number);
            Console.WriteLine("Tuesday");
            printDayTimetable(1, number);
            Console.WriteLine("Wednesday");
            printDayTimetable(2, number);
            Console.WriteLine("Thursday");
            printDayTimetable(3, number);
            Console.WriteLine("Friday");
            printDayTimetable(4, number);
            Console.WriteLine("Saturday");
            printDayTimetable(5, number);
        }

        private void printDayTimetable(int day, string number)
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
                Console.WriteLine($"Lesson ¹{i} - {nowTimetable[day,i].name}");
                Console.WriteLine($"Classroom ¹{nowTimetable[day, i].classroom}");
                Console.WriteLine($"Teacher - {nowTimetable[day, i].teacher}");
                Console.WriteLine(" ");
                Console.ResetColor();
            }
        }
    }
}