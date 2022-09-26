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

        public bool IsFree(int day, int lesson)
        {
            if (day >= 0 and day<6 and lesson >= 0 and lesson<7)
                return isFree(day, lesson)
            else Console.WriteLine("Ошибка ввода даты или номера пары");
            return false;
        }
        protected bool isFree(int day, int lesson)
        {
            if (Cell[day][lesson] == true) ;
            return true
                else return false;
        }
    }

}
