using System;
using System.Collections.Generic;

namespace SchoolLib
{
    public class School{
        public List<Student> students = new List<Student>();
        public List<Professor> professors = new List<Professor>();
        public List<Classroom> classrooms = new List<Classroom>();
        public TimeSpan classDuration = new TimeSpan(0, 30, 0);
        public TimeSpan endTime = new TimeSpan(1, 30, 0);
        public List<Subject> subjects = new List<Subject>();
        public List<Dictionary<TimeSpan, Subject>> studentSchedules = new List<Dictionary<TimeSpan, Subject>>();

        public void AddStudent()
        {
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter classroom number:");
            Classroom temp = null;
            int.TryParse(Console.ReadLine(), out int num);
            if (!classrooms.Exists(x => x.number == num))
            {
                Console.WriteLine("Classroom doesn't exist");
                return;
            }

            temp = classrooms.Find(x => x.number == num);
            Console.WriteLine(temp + " " + temp.number);
            if (temp.students.Count >= temp.capacity)
            {
                Console.WriteLine("Classroom is full");
                return;
            }
            Student stdt = new Student(name, age, temp, temp.schedule);
            students.Add(stdt);
        }

        public void AddProfessor(){
            Console.WriteLine("Enter professor name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter professor age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Select a subject");
            string subjectName = "";
            while(!subjects.Exists(x => x.name == subjectName)){
                ShowSubjects();
                Console.WriteLine("Enter subject name:");
                subjectName = Console.ReadLine();
            }
            Subject subject = subjects.Find(x => x.name == subjectName);
            
            Console.WriteLine("Enter schedule:");
            Dictionary<TimeSpan, Classroom> temp = new Dictionary<TimeSpan, Classroom>();
            TimeSpan time = new TimeSpan(0, 0, 0);
            for(int i = 0; i < 3; i++){
                Console.WriteLine($"{time}: Enter classroom number");
                int.TryParse(Console.ReadLine(), out int num);
                Classroom cls = classrooms.Find(x => x.number == num);
                temp.Add(time, cls);
                time += classDuration;
            }
            Professor prof = new Professor(name, subject, temp);
        }

        public void AddClassroom(){
            Console.WriteLine("Enter classroom number:");
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine("Enter classroom capacity:");
            int cap = int.Parse(Console.ReadLine());
            Classroom cls = new Classroom(num)
            {
                capacity = cap
            };
            bool unselected = true;
            while(unselected){
                Console.WriteLine("Select a schedule");
                ShowStudentSchedules();
                int.TryParse(Console.ReadLine(), out int input);
                if(input < studentSchedules.Count){
                    cls.schedule = studentSchedules[input];
                    unselected = false;
                }
            }
            classrooms.Add(cls);
        }
        

        public void ShowStudentSchedules(){
            int i = 0;
            foreach(var x in studentSchedules){
                Console.WriteLine(i + ":");
                foreach(var y in x){
                    Console.WriteLine(y.Key + " - " + y.Value);
                }
                i++;
                Console.WriteLine("");
            }
        }

        public void ShowStudents(){
            foreach(Student s in students){
                Console.WriteLine(s.name + " - " + s.age + " - " + s.classroom.number);
            }
        }

        public void ShowProfessors(){
            foreach(Professor p in professors){
                Console.WriteLine(p.name + " - " + p.age);
            }
        }

        public void ShowClassrooms(){
            Console.WriteLine("Number - Capacity");
            foreach(Classroom c in classrooms){
                
                Console.WriteLine(c.number + " - " + c.capacity);
            }
        }

        public void ShowSubjects(){
            foreach(Subject s in subjects){
                Console.WriteLine(s.name);
            }
        }
        public void AddStudentSchedule(){
            Dictionary<TimeSpan, Subject> temp = new Dictionary<TimeSpan, Subject>();
            TimeSpan time = new TimeSpan(0, 0, 0);
            for(int i = 0; i < 3; i++){
                Console.WriteLine(time);
                string subjectName = "";
                while(!subjects.Exists(x => x.name == subjectName)){
                    ShowSubjects();
                    Console.WriteLine("Select a subject:");
                    subjectName = Console.ReadLine();
                }
                temp.Add(time, subjects.Find(x => x.name == subjectName));
                time += classDuration;
            }
            studentSchedules.Add(temp);
        }

        public void AddSubject(){
            Console.WriteLine("Enter subject name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter subject description:");
            string description = Console.ReadLine();
            Subject subject = new Subject(name)
            {
                description = description
            };
            subjects.Add(subject);
        }
    }
}