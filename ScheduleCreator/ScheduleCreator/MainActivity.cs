using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    public class  MainActivity{

        private Scheddule scheddule;
        public List<StudyPlan> inputStudyPlans;
        public List<ClassRoom> inputClassrooms;
        public List<Teacher> inputTeachers;

        public void GetTeachers(List<Teacher> inputTeachers)
        {
            inputTeachers.Add(Console.ReadLine);
            
        }

        public void GetClassRooms(List<ClassRoom> inputClassrooms)
        {
            inputClassrooms.Add(Console.ReadLine);
        }

        public void GetStudyPlans(List<StudyPlan> inputStudyPlans)
        {
            inputStudyPlans.Add(Console.ReadLine);
        }
 
    }
}