using System;
using System.Collections.Generic;
using SchoolLib;

namespace SchoolLib
{
    public class Classroom {
        public int number;
        public int capacity = 45;
        public Dictionary<TimeSpan, Subject> schedule = new Dictionary<TimeSpan, Subject>();
        public List<Student> students = new List<Student>();
        public Professor professor = null;

        public Classroom(int number) {
            this.number = number;
        }

        public void ShowClass(){
            if(professor == null){
                Console.WriteLine("This class has no professor");
                return;
            }
            Console.WriteLine("Classroom: "+number);
            Console.WriteLine(professor.name+": "+professor.subject.name);
            Console.WriteLine("Students: ");
            
            foreach(Student student in students){
                Console.WriteLine("\t"+student.name);
            }
        }
    }
}