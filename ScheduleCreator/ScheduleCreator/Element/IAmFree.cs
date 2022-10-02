using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    interface IAmFree
    {
        void IsFree(int day, int lesson);
    }
}
