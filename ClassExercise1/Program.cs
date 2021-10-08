using System;
using System.Collections.Generic;

namespace ClassExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2020;

            var toyota = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2018,
            };

            var kia = new Car("Kia", "Soul", 2019);
           
            var carList = new List<Car>() { myCar, toyota, kia};

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        
        
        }   
    }
}
