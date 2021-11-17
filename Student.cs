using System.Collections.Generic;
using System;
using SchoolLib;

namespace SchoolLib {    
    public class Student {
        public Classroom classroom = null;
        public string name;
        public int age;
        public Dictionary<TimeSpan, Subject> schedule;

        public Student(string name, int age, Classroom classroom, Dictionary<TimeSpan, Subject> schedule) {
            this.schedule = schedule;
            this.classroom = classroom;
            this.name = name;
            this.age = age;
        }

        public void ShowSchedule() {
            foreach (KeyValuePair<TimeSpan, Subject> entry in schedule) {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value.name);
            }
        }
    }
}