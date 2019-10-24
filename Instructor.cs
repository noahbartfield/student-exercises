namespace StudentExercises
{
    public class Instructor : Person
    {
        // public Instructor(Cohort cohort)
        // {
        //     Cohort = cohort;
        // }


        public string Speciality { get; set; }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
    }
}