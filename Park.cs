using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ParkLib {
    public class Park
    {
        public List<Car> cars = new List<Car>();
        public float price;
        public int rideTime;
        public int rideDecrement;

        public void AddCar()
        {
            Console.WriteLine("Enter car color: ");
            string color = Console.ReadLine();
            Car car = new Car(color);
            cars.Add(car);
        }

        public void AddClient()
        {
            if(cars.Count == 0)
            {
                Console.WriteLine("No cars in the park");
                return;
            }
            Client client = new Client();
            if (client.money < price)
            {
                Console.WriteLine("Insufficient money");
                return;
            }
            Car car = cars.Find(x => x.client == null);
            car.client = client;
            client.money -= price;
            Console.WriteLine(client.name + " has entered the " + car.color + " car");
        }

        public void RemoveClient(Client client)
        {
            cars.Find(x => x.client == client).client = null;
            Console.WriteLine(client.name + " has left the park");
        }

        public void RideCars()
        {
            foreach (Car car in cars)
            {
                if (car.client == null)
                {
                    continue;
                }
                car.time -= rideTime;
                if (car.time > 0)
                {
                    continue;
                }
                Console.WriteLine(car.client.name + "'s ride on " + car.color + " car has ended");
                if (car.client.money >= price)
                {
                    Console.WriteLine(car.client.name + " bought more time in the car");
                    car.client.money -= price;
                    car.time = rideTime;
                }
                else
                {
                    Console.WriteLine(car.client.name + " doesn't have sufficient money");
                    car.time = 0;
                    RemoveClient(car.client);
                }

            }
        }

        public void PrintCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.color + " car");
            }
        }

        public void PrintClients()
        {
            foreach (Car car in cars)
            {
                if (car.client != null)
                {
                    Console.WriteLine(car.client.name + " in the " + car.color + " car");
                }
            }
        }
    }
}