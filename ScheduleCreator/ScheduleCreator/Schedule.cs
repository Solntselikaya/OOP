using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScheduleCreator
{ 
    internal class Schedule
    {
        private Dictionary<Group, ITimetable> schedule = new Dictionary<Group, ITimetable>();

        public void AddElement(Group group, Timetable timetable)
        {
            schedule.Add(group, timetable);
        }
        
        public ITimetable GetTimetable(Group group)
        {
            return schedule[group];
        }
    }
}