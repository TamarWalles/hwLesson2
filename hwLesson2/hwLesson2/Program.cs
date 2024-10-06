using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter details for student {i}:");
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                Console.Write("Enter student track: ");
                string track = Console.ReadLine();

                Student student = new Student(name, track);
                students.Add(student);

                Console.WriteLine("Please add courses for the student (Enter '0' to stop):");
                student.addCourse();

                student.addCourseWithMarks("Math", 95);
                student.addCourseWithMarks("History", 88);
                 student.addCourseWithMarks("Computer Science", 100);

                Console.WriteLine("Courses and marks for " + student.Name + ":");
                student.showCourses();
                student.showScores();

                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}