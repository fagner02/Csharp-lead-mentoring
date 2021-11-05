using System;
using StudentClass;

namespace SolverClass {
    public class Solver{
        Student[] students = new Student[0];
        float passingGrade = 7; 

        public void setPassingGrade(){
            Console.WriteLine("Enter the passing grade: ");
            try{
                this.passingGrade = float.Parse(Console.ReadLine());
            }  catch {
                Console.WriteLine("Invalid input");
            }
        }
        public void addStudent(){
            Student student = new Student();
            Student[] temp = new Student[students.Length + 1];
            students.CopyTo(temp, 0);
            temp[students.Length] = student;
            students = temp;
        }

        public void removeStudent(){
            if(students.Length == 0){
                Console.WriteLine("There are no students");
                return;
            }
            string name;
            name = Console.ReadLine();
            Student[] temp = new Student[students.Length - 1];
            int i = 0, j = 0;
            for (i = 0; i < students.Length; i++) {
                if(students[i].name != name){
                    if(j == temp.Length){
                        Console.WriteLine("Student not found");
                        return;
                    }
                    temp[j] = students[i];
                    j++;
                    
                }
            }
            students = temp;
            Console.WriteLine($"Student {name} removed");
            
        }

        public void showStudents() {
            if(students.Length == 0){
                Console.WriteLine("There are no students");
                return;
            }
            foreach (Student student in students) {
                Console.Write($"{student.name}: [ ");

                foreach (int mark in student.marks) {
                    Console.Write($"{mark} ");
                }

                Console.WriteLine("]");
            }
        }

        public void showClassAverage(){
            if(students.Length == 0){
                Console.WriteLine("There are no students");
                return;
            }
            float sum = 0;
            foreach (Student student in students) {
                sum += average(student);
            }
            Console.WriteLine($"Class average: {sum / students.Length}");
        }
        public void showAverage() {
            if(students.Length == 0){
                Console.WriteLine("There are no students");
                return;
            }
            foreach (Student student in students) {
                Console.WriteLine($"{student.name}: {average(student)}");
            }
        }

        public void showClassification() {
            if(students.Length == 0){
                Console.WriteLine("There are no students");
                return;
            }
            foreach (Student student in students) {
                student.approved = (average(student) >= passingGrade);
                Console.WriteLine($"{student.name}: {((student.approved) ? "approved" : "reproved")}");
            }
        } 

        public float average(Student student) {
            Console.Read();
            float sum = 0;
            for(int j = 0; j < student.marks.Length; j++) {
                sum += student.marks[j];
            }

            return sum / 3;
        }


    }
}