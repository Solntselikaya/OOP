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
            var name = Console.Readline();
            inputTeachers.Add(new Teacher(){
                Name = name,
            });
        }

        public void AssignClassrooms()
        {
            Console.Write("Введите  аудиторию: ");
            var classroom = Console.Readline();
             inputClassrooms.Add(new Classroom(){ Name = classroom});
            
        }

        public void AssignStudyPlans()
        {
             Console.Write("Введите StudyPlan: ");
              var tudyPlan = Console.Readline();
             inputStudyPlans.Add(new StudyPlan(){NumOfGroup = StudyPlan });
        }
        

    }
}