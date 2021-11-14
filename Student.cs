using System.Collections.Generic;
using System;
using SchoolLib;

namespace SchoolLib {    
    public class Student {
        public Classroom classroom = null;
        public TimeSpan time = new TimeSpan(0, 0, 0);
        public string name;
        public int age;
        public Dictionary<TimeSpan, Subject> schedule = new Dictionary<TimeSpan, Subject>();

        public Student(string name, int age, Classroom classroom, Dictionary<TimeSpan, Subject> schedule) {
            this.schedule = schedule;
            this.classroom = classroom;
            this.name = name;
            this.age = age;
        }
        public void updateTime(TimeSpan classDuration) {
            time += classDuration;
            // if(classroom != null){
            //     classroom.students.Remove(this);
            // }
            // if(!schedule.ContainsKey(time)){
            //     classroom = null;
            //     return;
            // }
            // classroom = schedule[time];
            // classroom.students.Add(this);
        }

        public void showSchedule() {
            foreach (KeyValuePair<TimeSpan, Subject> entry in schedule) {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value.name);
            }
        }
    }
}