using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public Cohort()
        {
            Students = new List<Student>();
        }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}