using System;
using System.Collections.Generic;
using SchoolLib;

namespace SchoolLib
{
    public class Classroom {
        public int number { get; set; }
        public int capacity { get; set; } = 45;
        public List<Student> students { get; set; } = new List<Student>();
        public Professor professor { get; set; } = null;

        public Classroom(int number) {
            this.number = number;
        }

        public void showClass(){
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