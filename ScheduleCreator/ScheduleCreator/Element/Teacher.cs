using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
   
    internal class Teacher : Element
    {
        public list<string> subgect;
        bool IsFree(int day, int lesson)
        {
            if (day >= 0 and day<6 && lesson >= 0 and lesson<7){
                if (workload[day][lesson] == true)
                    return true;
                else return false;
            }
            else Console.WriteLine("Ничеси!!Ошибка ввода даты или номера пары");
            return false;
        }
    }
}
