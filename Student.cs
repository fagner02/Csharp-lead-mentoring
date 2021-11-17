using System;

namespace StudentClass {
    public class Student {

        public bool approved;
        public float[] marks = new float[3];
        public string name;

        public Student() {
            Console.WriteLine("Enter the name of student: ");
            this.name = Console.ReadLine();
            setMarks();
        }

        public void setMarks() {
            Console.WriteLine("Enter the marks of three subjects: ");
            for(int i = 0; i < marks.Length; i++) {
                try{
                    marks[i] = float.Parse(Console.ReadLine());
                } catch {
                    Console.WriteLine("Invalid input");
                    i--;
                }
            }
        }
    }
}