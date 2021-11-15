using System;
using System.Collections.Generic;

namespace SchoolLib
{
    public class Professor
    {
        public TimeSpan time = new TimeSpan(0, 0, 0);
        public string name;
        public int age;
        public Subject subject = new Subject("");
        public Classroom classroom = null;
        public Dictionary<TimeSpan, Classroom> schedule = new Dictionary<TimeSpan, Classroom>();

        public Professor(string name, Subject subject, Dictionary<TimeSpan, Classroom> schedule)
        {
            this.schedule = schedule;
            this.subject = subject;
            this.name = name;
        }

        public void goToClass() {
            if(classroom != null){
                classroom.professor = null;
            }
            if(!schedule.ContainsKey(time)) {
                classroom = null;
                return;
            }
            classroom = schedule[time];
            classroom.professor = this;
        }        

        public void updateTime(TimeSpan classDuration){
            time += classDuration;
            goToClass();
        }

        public void showSchedule() {
            foreach(KeyValuePair<TimeSpan, Classroom> entry in schedule) {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value.number);
            }
        }
    }
}