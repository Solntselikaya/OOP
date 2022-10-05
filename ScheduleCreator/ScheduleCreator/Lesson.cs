using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    internal class Lesson
    {
        private Teacher teacher;
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public void GetTeacher(string teacherName)
        {
            teacher = new Teacher();
            teacher.Name = teacherName;
        }
    }
}
