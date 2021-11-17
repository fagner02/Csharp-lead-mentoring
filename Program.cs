using System;
using ParkLib;

namespace parque
{
    class Program
    {
        static void Main(string[] args)
        {
            Park park = new Park();
            string[] commands = new string[] { "add-client", "add-car", "print-clients", "print-cars", "ride-cars", "exit" };
            string cmd = "";
            while (cmd != "exit")
            {
                Console.WriteLine("Enter command");
                cmd = Console.ReadLine();
                if(cmd == commands[0]){
                    park.AddClient();
                }
                if(cmd == commands[1]){
                    park.AddCar();
                }
                if(cmd == commands[2]){
                    park.PrintClients();
                }
                if(cmd == commands[3]){
                    park.PrintCars();
                }
                if(cmd == commands[4]){
                    park.RideCars();
                }
                if(cmd == commands[5]){
                    Console.WriteLine("Bye!");
                }
            }
        }
    }
}
