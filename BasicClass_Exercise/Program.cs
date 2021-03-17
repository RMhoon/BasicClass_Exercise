using System;

namespace BasicClass_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Mercedes";
            car.Model = "350";
            car.Year = 2020;

            Console.WriteLine($"The car is for sale, Make({car.Make}), Model ({car.Model}) and Year({car.Year})");
        }
    }
}
