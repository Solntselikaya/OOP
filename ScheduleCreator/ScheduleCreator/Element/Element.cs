using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    abstract class Element: IAmFree
    {
        protected string name = "Undefined";
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        //private string name;//фамилия преподавателя/номер группы/номер аудитории(для дочерних элементов)
        abstract private bool[6][7] workload;//массив 6 на 7 (6 дней и каждый день максимум 7 пар)   

        abstract protected global::System.String Name { get => name; set => name = value; }

        abstract public void DoBusy(int day, int lesson)
        {
            if (day >= 0 and day<6 and lesson >=0 and lesson<7)
                workload[day][lesson] = true;
            else Console.WriteLine("Ошибка ввода даты или номера пары");
        }
    }
}
