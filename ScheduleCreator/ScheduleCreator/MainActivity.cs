using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    public class  MainActivity{

        private Scheddule scheddule;
       
        public void AssignTeachers()
        {

            Console.Write("Введите имя учителя: ");
            inputTeachers.Add(new Teacher());
        }

        public void AssignClassrooms()
        {
            Console.Write("Введите имя аудитории: ");
             inputClassrooms.Add(new Classroom());
            
        }

        public void AssignStudyPlans()
        {
             Console.Write("Введите имя StudyPlan: ");
             inputStudyPlans.Add(new StudyPlan());
        }
        

    }
}