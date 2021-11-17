using System;
using System.Collections.Generic;
using SchoolLib;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            string[] commands = new string[]{ "add-student", "show-students","add-professor", "show-professors", "add-classroom", "show-classrooms", "add-subject", "show-subjects", "exit" };
            string cmd = "";
            while (cmd != "exit")
            {
                Console.WriteLine("Enter command:");
                cmd = Console.ReadLine();
                if (cmd == commands[0])
                {
                    school.AddStudent();
                }
                if (cmd == commands[1])
                {
                    school.ShowStudents();
                }
                if (cmd == commands[2])
                {
                    school.AddProfessor();
                }
                if (cmd == commands[3])
                {
                    school.ShowProfessors();
                }
                if (cmd == commands[4])
                {
                    school.AddClassroom();
                }
                if (cmd == commands[5])
                {
                    school.ShowClassrooms();
                }
                if (cmd == commands[6])
                {
                    school.AddSubject();
                }
                if (cmd == commands[7])
                {
                    school.ShowSubjects();
                }
                if (cmd == commands[8])
                {
                    break;
                }

            }
            // Classroom class1 = new Classroom(0);
            // Classroom class2 = new Classroom(1);
            // Classroom class3 = new Classroom(2);
            // Dictionary<TimeSpan, Classroom> ssch = new Dictionary<TimeSpan, Classroom>(){
            //     {new TimeSpan(0, 0, 0), class1},
            //     {new TimeSpan(0, 30, 0), class2},
            //     {new TimeSpan(1, 0, 0), class3}
            // };

            // Dictionary<TimeSpan, Subject> subjects = new Dictionary<TimeSpan, Subject>(){
            //     {new TimeSpan(0, 0, 0), new Subject("Math")},
            //     {new TimeSpan(0, 30, 0), new Subject("English")},
            //     {new TimeSpan(1, 0, 0), new Subject("Physics")}
            // };


            // school.classrooms.Add(class1);
            // school.classrooms.Add(class2);
            // school.classrooms.Add(class3);
            // Student s0 = new Student("jon", 3, class1, subjects);
            // Student s1 = new Student("jane", 2, class2, subjects);
            // Student s2 = new Student("joe", 1, class3, subjects);
            // school.students.Add(s0);
            // school.students.Add(s1);
            // school.students.Add(s2);
            // Console.WriteLine("Hello World!");
            // Professor p = new Professor("no", new Subject("hist"), ssch);
            // school.professors.Add(p);
        }
    }
}
