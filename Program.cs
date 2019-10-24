using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise1 = new Exercise();
            Exercise exercise2 = new Exercise();
            Exercise exercise3 = new Exercise();
            Exercise exercise4 = new Exercise();

            exercise1.Name = "Chicken Monkey";
            exercise1.Language = "JavaScript";

            exercise2.Name = "Dollars to Cents";
            exercise2.Language = "JavaScript";

            exercise3.Name = "Plan Your Heist";
            exercise3.Language = "C Sharp";

            exercise4.Name = "Calculator";
            exercise4.Language = "C Sharp";

            Cohort cohort1 = new Cohort();
            Cohort cohort2 = new Cohort();
            Cohort cohort3 = new Cohort();

            cohort1.Name = "C34";
            cohort2.Name = "C36";
            cohort3.Name = "E9";

            Student student1 = new Student(cohort1);
            Student student2 = new Student(cohort2);
            Student student3 = new Student(cohort2);
            Student student4 = new Student(cohort3);

            student1.FirstName = "Michael";
            student1.LastName = "Stiles";

            student2.FirstName = "Bobby";
            student2.LastName = "Brady";

            student3.FirstName = "Bennett";
            student3.LastName = "Foster";

            student4.FirstName = "Haroon";
            student4.LastName = "Iqbal";

            Instructor instructor1 = new Instructor();
            Instructor instructor2 = new Instructor();
            Instructor instructor3 = new Instructor();
            Instructor instructor4 = new Instructor();
            Instructor instructor5 = new Instructor();

            instructor1.Cohort = cohort1;
            instructor2.Cohort = cohort3;
            instructor3.Cohort = cohort2;
            instructor4.Cohort = cohort3;
            instructor5.Cohort = cohort1;

            instructor1.FirstName = "Andy";
            instructor2.FirstName = "Steve";
            instructor3.FirstName = "Jenna";
            instructor4.FirstName = "Bryan";
            instructor5.FirstName = "Adam";

            instructor1.LastName = "Collins";
            instructor2.LastName = "Brownlee";
            instructor3.LastName = "Solis";
            instructor4.LastName = "Nilsen";
            instructor5.LastName = "Sheaffer";


            instructor1.AssignExercise(student1, exercise1);
            instructor1.AssignExercise(student1, exercise2);
            instructor2.AssignExercise(student3, exercise3);
            instructor2.AssignExercise(student4, exercise4);
            instructor3.AssignExercise(student4, exercise2);
            instructor3.AssignExercise(student3, exercise4);
            instructor3.AssignExercise(student3, exercise1);
            instructor3.AssignExercise(student3, exercise2);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            foreach (Student student in students)
            {
                foreach (Exercise studentExercise in student.Exercises)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {studentExercise.Name}");
                }
            }

            Console.WriteLine("----------------------");



            List<Exercise> exercises = new List<Exercise>() {
                exercise1,
                exercise2,
                exercise3,
                exercise4,
            };

            List<Exercise> javascriptExercises = exercises.Where(e => e.Language == "JavaScript").ToList();

            foreach (Exercise exercise in javascriptExercises)
            {
                Console.WriteLine(exercise.Name);
            }

            Console.WriteLine("----------------------");

            List<Student> cohort36Students = students.Where(s => s.Cohort.Name == "C36").ToList();

            foreach (Student student in cohort36Students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is in Cohort 36");
            }

            Console.WriteLine("----------------------");

            List<Instructor> instructors = new List<Instructor>()
            {
                instructor1,
                instructor2,
                instructor3,
                instructor4,
                instructor5,
            };

            List<Instructor> cohortE9Instructors = instructors.Where(i => i.Cohort.Name == "E9").ToList();

            foreach (Instructor instructor in cohortE9Instructors)
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName} is an instructor of the E9 cohort");
            }

            Console.WriteLine("----------------------");

            List<Student> studentsByLastName = students.OrderBy(s => s.LastName).ToList();

            foreach (Student student in studentsByLastName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine("----------------------");

            List<Student> slackerStudents = students.Where(s => s.Exercises.Count == 0).ToList();

            foreach (Student student in slackerStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is a slacker");
            }

            Console.WriteLine("----------------------");

            List<Student> studentsByNumberOfExercises = students.OrderByDescending(s => s.Exercises.Count).ToList();

            Student overachieverStudent = studentsByNumberOfExercises[0];

            Console.WriteLine($"{overachieverStudent.FirstName} {overachieverStudent.LastName} is doing the most exercises");

            Console.WriteLine("----------------------");

            var groupedByCohort = students
                .GroupBy(s => s.Cohort)
                .Select(s => new { cohort = s.Key, count = s.Count() });

            foreach (var grouped in groupedByCohort)
            {
                Console.WriteLine($"{grouped.cohort.Name}: {grouped.count}");
            }

            Console.WriteLine("----------------------");

        }
    }
}
