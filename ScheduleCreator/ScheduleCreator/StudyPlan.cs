using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    internal struct StudyPlan
    {
        public string NumOfGroup { get; set; }
        public List<Tuple<Lesson, LType>> listOfLessons = new List<Tuple<Lesson, LType>>(42);
    }
}
