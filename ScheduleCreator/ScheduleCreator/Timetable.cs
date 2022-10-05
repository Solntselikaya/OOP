using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    internal class Timetable
    {
        private Study[6,7] timetable;

        private void GenerateTimetable(List<StudyPlan> studyPlanList)
        {
            for(int i = 0; i < studyPlanList.Count; i++)
            {
                for(int k = 0; k < MainActivity.InputTeachers; k++)
                {
                    if (MainActivity.InputTeachers[k] == studyPlanList[i].listOfLessons.Item1.teacher)
                    {
                        FindPlaceInTable(MainActivity.InputTeachers[k], studyPlanList[i].listOfLessons);
                        break;
                    }
                }
            }
        }

        private int FindPlaceInTable(Teacher teacher, List<Tuple<Lesson, LType>> lessonsList)
        {
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (teacher.IsFree(x, y))
                    {
                        for(int i = 0; i < MainActivity.InputClassrooms.Count; i++)
                        {
                            if (MainActivity.InputClassrooms[i].IsFree(x, y))
                            {
                                MainActivity.InputClassrooms[i].DoBusy(x, y);
                                teacher.DoBusy(x, y); 
                                timetable[x, y].name = lessonsList.Item1.lesson.name;
                                timetable[x, y].classrom = MainActivity.InputClassrooms[i].name;
                                timetable[x, y].teacher = teacher.name;
                                timetable[x, y].lessonType = lessonsList.Item2;
                                return 0;
                            }
                        }
                    }
                }
            }
        }
    }
}