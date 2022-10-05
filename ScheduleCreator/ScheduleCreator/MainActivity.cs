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

        public List<Teacher> GetTeachers()
        {
            return inputTeachers;
        }

        public void GetClassRooms()
        {
            return inputClassrooms;
        }

        public void GetStudyPlans()
        {
            return inputStudyPlans;
        }
        
 
    }
}