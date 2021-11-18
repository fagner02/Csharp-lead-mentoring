using System;
using System.Collections.Generic;
using SchoolLib;

namespace school
{
    class Program
    {
        static void Help(){
            Console.WriteLine("add-student - adds a student to the school");
            Console.WriteLine("show-students - shows all students");
            Console.WriteLine("add-professor - adds a professor to the school");
            Console.WriteLine("show-professors - shows all professors");
            Console.WriteLine("add-classroom - adds a classroom to the school");
            Console.WriteLine("show-classrooms - shows all classrooms");
            Console.WriteLine("add-subject - adds a subject to the school");
            Console.WriteLine("show-subjects - shows all subjects");
            Console.WriteLine("add-schedule - adds a schedule to the school");
            Console.WriteLine("exit - exits the program");
        } 
        static void Main(string[] args)
        {
            School school = new School();
            string[] commands = new string[]{ "add-student", "show-students","add-professor", "show-professors", "add-classroom", "show-classrooms", "add-subject", "show-subjects", "add-schedule", "exit", "help" };
            string cmd = "";

            while (cmd != "exit")
            {
                Console.WriteLine("Enter command:");
                cmd = Console.ReadLine();
                if (cmd == commands[0])
                {
                    school.AddStudent();
                    continue;
                }
                if (cmd == commands[1])
                {
                    school.ShowStudents();
                    continue;
                }
                if (cmd == commands[2])
                {
                    school.AddProfessor();
                    continue;
                }
                if (cmd == commands[3])
                {
                    school.ShowProfessors();
                    continue;    
                }
                if (cmd == commands[4])
                {
                    school.AddClassroom();
                    continue;
                }
                if (cmd == commands[5])
                {
                    school.ShowClassrooms();
                    continue;
                }
                if (cmd == commands[6])
                {
                    school.AddSubject();
                    continue;
                }
                if (cmd == commands[7])
                {
                    school.ShowSubjects();
                    continue;
                }
                if(cmd == commands[8])
                {
                    school.AddStudentSchedule();
                    continue;
                }
                if (cmd == commands[9])
                {
                    break;
                }
                if (cmd == commands[10])
                {
                    Help();
                    continue;
                }
                Console.WriteLine("Invalid command, run the command 'help' for more info");
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
