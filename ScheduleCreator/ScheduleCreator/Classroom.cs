using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    internal class Classroom:Element
    {
        private int size;

        bool IsFree(int day, int lesson)
        {
            if (day >= 0 && day<6 && lesson >= 0 && lesson<7){
                if (workload[day][lesson] == true)
                    return true;
                else return false;
            }
            else Console.WriteLine("Ого! Ошибка ввода даты или номера пары");
            return false;
        }

    }

}
