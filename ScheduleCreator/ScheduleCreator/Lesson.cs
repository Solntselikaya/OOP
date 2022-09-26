using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
	public Lesson()
	{
        enum Type
        {
            Lecture,
            Seminar,
            Practice,
            Lab,
            Test
        }
        private string audience; 
        private string subject; 
        private string teacher; 
        private Type lessonType; 

    public PrintLesson()
    {
        switch{
            case lessonType.Lecture:
            Console.ForegroundColor = ConsoleColor.Red;
                break;
            case lessonType.Seminar:
            Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case lessonType.Practice:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case lessonType.Lab:
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case lessonType.Test:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
        }

        Console.WriteLine(subject);
        Console.WriteLine(audience,": ", teacher);
        Console.ResetColor();
    }
    }
}
