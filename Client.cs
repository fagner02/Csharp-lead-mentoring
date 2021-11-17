using System;

namespace ParkLib
{
    public class Client
    {
        public int age;
        public string name;
        public float money;

        public Client()
        {
            int.TryParse(Console.ReadLine(), out int age);
            string name = Console.ReadLine();
            float.TryParse(Console.ReadLine(), out float money);
            this.age = age;
            this.name = name;
            this.money = money;
        }
    }
}