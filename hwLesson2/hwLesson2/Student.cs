using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwLesson1
{
    internal class Student
    {
        private string name;
        private string track;
        List<string> courses = new List<string>();
        Dictionary<string, int> listCourseMarks = new Dictionary<string, int>();
        public Student(string name, string track)
        {
            this.name = name;
            this.track = track;

        }

        public string Name
        {
            get { return $"Mrs. {name}"; }
            set { name = value; }
        }

        public string Track
        {
            get { return track; }
            set { track = value; }
        }

        public List<string> Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public void showCourses()
        {
            Console.WriteLine("The courses of " + this.Name + ": ");
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses registered.");
            }
            else
            {
                foreach (var course in courses)
                {
                    Console.WriteLine(course);
                }
            }
            Console.WriteLine();
        }
        public void addCourse()
        {

            String course = Console.ReadLine();
            while (!course.Equals("0"))
            {
                courses.Add(course);
                course = Console.ReadLine();
            }

        }
        public void showScores()
        {
            Console.WriteLine(this.Name + ": ");
            foreach (var mark in listCourseMarks)
            {
                Console.WriteLine("subject :" + mark.Key);
                Console.WriteLine("score :" + mark.Value);
            }
        }
        public void addCourseWithMarks(string course,int mark)
        {
            listCourseMarks.Add(course,mark);


        }

        public void showStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students in the list");
                return;
            }
            foreach (var student in students)
            {
                Console.WriteLine("Student: " + student.Name);
                Console.WriteLine("Track: " + student.Track);

                student.showCourses();
                student.showScores();
            }
        }
        public void startWithLetter(List<Student> list)
        {
            Console.WriteLine("enter a letter");
            string let = Console.ReadLine();
            List<Student> students = list.Where(s => s.Name.StartsWith(let)).ToList();
            Console.WriteLine($"the students that start with letter {let} :");
            showStudents(students);
        }
        public void showStudentsByTrack(List<Student> list)
        {
            Console.WriteLine("enter a track");
            string track = Console.ReadLine();
            List<Student> students = list.Where(s => s.track.Equals(track)).ToList();
            Console.WriteLine($"the students that learn {track} :");
            showStudents(students);
        }
        public void moreThanOne(List<Student> list)
        {
            List<Student> students = list.Where(s => s.courses.Count() > 1).ToList();
            Console.WriteLine("the students that have 2 cours and more :");
            showStudents(students);

        }
        public void lowScores(List<Student> list, int scoreThreshold)
        {
            List<Student> students = list.Where(s => s.listCourseMarks.Values.Any(m => m < scoreThreshold)).ToList();
            Console.WriteLine($"The students with scores lower than {scoreThreshold}:");
            showStudents(students);
        }

    }

}