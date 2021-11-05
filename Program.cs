using System;
using SolverClass;

namespace testApp {
    class Program {
        public static readonly string[] commands = { "add-student", "remove-student", "show-average", "show-students", "show-classification", "show-class-average", "set-passing-grade", "exit", "help" }; 
 
        public static void showCommands() {
            Console.WriteLine("Available commands:");
            foreach (string command in commands) {
                Console.WriteLine($"\t{command}");
            }
        }

        static void Main(string[] args) {
            Solver s = new Solver();
            string cmd = "";
            while (cmd != "exit") {
                Console.WriteLine("Enter command: ");
                cmd = Console.ReadLine();
                if (cmd == "exit") {
                    break;
                }
                if (cmd == "help") {
                    showCommands();
                    continue;
                }
                if (cmd == "add-student") {
                    s.addStudent();
                    continue;
                }
                if (cmd == "remove-student") {
                    s.removeStudent();
                    continue;
                }
                if(cmd == "show-average") {
                    s.showAverage();
                    continue;
                }
                if(cmd == "show-students") {
                    s.showStudents();
                    continue;
                }
                if(cmd == "show-classification") {
                    s.showClassification();
                    continue;
                }
                if(cmd == "show-class-average") {
                    s.showClassAverage();
                    continue;
                }
                if(cmd == "set-passing-grade") {
                    s.setPassingGrade();
                    continue;
                }
                Console.WriteLine("Invalid command, if need more information run the command \'help\'");
            }
        }
    }
}
