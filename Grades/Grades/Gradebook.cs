using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        // My constructor to set the grades to be a new list
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();
            

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;

            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        // Takes the values passed into it by grade and adds them to the grades list

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        // Saves the list

        List<float> grades;
    }
}
