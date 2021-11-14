using System;
using System.Collections.Generic;

namespace SchoolLib
{
    public class School{
        public List<Student> students = new List<Student>();
        public List<Professor> professors = new List<Professor>();
        public List<Classroom> classrooms = new List<Classroom>();
        TimeSpan time = new TimeSpan(0, 0, 0);
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
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            if (!classrooms.Exists(x => x.number == num))
            {
                Console.WriteLine("Classroom doesn't exist");
                return;
            }

            temp = classrooms.Find(x => x.number == num);

            if (temp.students.Count >= temp.capacity)
            {
                Console.WriteLine("Classroom is full");
                return;
            }
            Console.WriteLine("Choose one student schedule");
            int schPos = 0;
            int.TryParse(Console.ReadLine(), out schPos);
            Student stdt = new Student(name, age, temp, studentSchedules[schPos]);
            students.Add(stdt);
        }

        public void AddProfessor(){
            Console.WriteLine("Enter professor name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter professor age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter subject");
            Subject subj = new Subject(Console.ReadLine());
            Console.WriteLine("Enter schedule:");
            Dictionary<TimeSpan, Classroom> temp = new Dictionary<TimeSpan, Classroom>();
            TimeSpan time = new TimeSpan(0, 0, 0);
            for(int i = 0; i < 3; i++){
                Console.WriteLine($"{time}: Enter classroom number");
                int num = 0;
                int.TryParse(Console.ReadLine(), out num);
                Classroom cls = classrooms.Find(x => x.number == num);
                temp.Add(time, cls);
                time += classDuration;
            }
            Professor prof = new Professor(name, subj, temp);
        }
        public void updateTime()
        {
            time += classDuration;
            Console.WriteLine(time);
            foreach (Student s in students)
            {
                s.updateTime(classDuration);
            }
            foreach (Professor p in professors)
            {
                p.updateTime(classDuration);
            }
        }

        public void showStudentSchedules(){
            int i = 0;
            foreach(var x in studentSchedules){
                Console.WriteLine(i);
                foreach(var y in x){
                    Console.WriteLine(y.Key + " - " + y.Value);
                }
                i++;
                Console.WriteLine("");
            }
        }

        public void showStudents(){
            foreach(Student s in students){
                Console.WriteLine(s.name + " - " + s.age + " - " + s.classroom.number);
            }
        }

        public void showProfessors(){
            foreach(Professor p in professors){
                Console.WriteLine(p.name + " - " + p.age + " - " + p.classroom.number);
            }
        }

        public void showClassrooms(){
            foreach(Classroom c in classrooms){
                Console.WriteLine(c.number + " - " + c.capacity);
            }
        }
        public Dictionary<TimeSpan, Subject> addStudentSchedule(){
            Dictionary<TimeSpan, Subject> temp = new Dictionary<TimeSpan, Subject>();
            TimeSpan time = new TimeSpan(0, 0, 0);
            for(int i = 0; i < 3; i++){
                Console.WriteLine(time);
                Console.WriteLine("Enter subject name:");
                string name = Console.ReadLine();
                temp.Add(time, new Subject(name));
                time += classDuration;
            }
            studentSchedules.Add(temp);
            return temp;
        }
    }
}