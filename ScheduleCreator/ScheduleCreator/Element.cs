using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Element
    {
        protected string name;//фамилия преподавателя/номер группы/номер аудитории(для дочерних элементов)
        protected Cell[] Workload;//массив 6 на 7 (6 дней и каждый день максимум 7 пар)

    }
}
