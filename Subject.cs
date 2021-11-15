namespace SchoolLib
{
    public class Subject
    {
        public string name { get; set; }
        public string ClassTeacher { get; set; }
        public int ClassNumber { get; set; }
        public int ClassCapacity { get; set; }

        public Subject(string name)
        {
            this.name = name;
        }
    }
}