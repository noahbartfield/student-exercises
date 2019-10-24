using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : Person
    {
        public Student(Cohort cohort)
        {
            Cohort = cohort;
            Exercises = new List<Exercise>();
        }
        public List<Exercise> Exercises { get; set; }

    }
}