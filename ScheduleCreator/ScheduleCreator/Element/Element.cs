using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    abstract class Element: IAmFree
    {
        protected string name;//фамилия преподавателя/номер группы/номер аудитории(для дочерних элементов)
        protected bool Cell[6][7] Workload;//массив 6 на 7 (6 дней и каждый день максимум 7 пар)

        public void DoBusy(int day, int lesson)
        {
            if (day >= 0 and day<6 and lesson >=0 and lesson<7)
                doBusy(day, lesson)
            else Console.WriteLine("Ошибка ввода даты или номера пары");
        }
        protected void doBusy(int day, int lesson)
        {
            Cell[day][lesson] = true;
        }
    }
}
