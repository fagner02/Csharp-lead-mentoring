using System;
using System.Collections.Generic;

namespace SchoolLib
{
    public class Professor
    {
        public string name;
        public int age;
        public Subject subject;
        public Dictionary<TimeSpan, Classroom> schedule;

        public Professor(string name, Subject subject, Dictionary<TimeSpan, Classroom> schedule)
        {
            this.schedule = schedule;
            this.subject = subject;
            this.name = name;
        }

        public void ShowSchedule() {
            foreach(KeyValuePair<TimeSpan, Classroom> entry in schedule) {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value.number);
            }
        }
    }
}