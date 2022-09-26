using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Element.Teacher;

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
        private Classroom audience; 
        private string subject; 
        private Teacher teacher; 
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

    //public void Get()//вывод
    //{

    //}

    //public void Set(auto audi, auto sub, auto teac, auto lesType)//ввод
    //{
    //    if (isString(audi) and day<6 and lesson >= 0 and lesson<7)
    //            return isFree(day, lesson)
    //        else Console.WriteLine("Ошибка ввода даты или номера пары");
    //    return false;
    //}
}   
}
