using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split();

                string model = element[0];
                int engineSpeed = int.Parse(element[1]);
                int enginePower = int.Parse(element[2]);
                int cargoWeight = int.Parse(element[3]);
                string cargoType = element[4];
                double tire1Pressure = double.Parse(element[5]);
                int tire1Age = int.Parse(element[6]);
                double tire2Pressure = double.Parse(element[7]);
                int tire2Age = int.Parse(element[8]);
                double tire3Pressure = double.Parse(element[9]);
                int tire3Age = int.Parse(element[10]);
                double tire4Pressure = double.Parse(element[11]);
                int tire4Age = int.Parse(element[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire tire = new Tire(tire1Pressure, tire1Age,
                    tire2Pressure, tire2Age,
                    tire3Pressure, tire3Age,
                    tire4Pressure, tire4Age);

                Car car = new Car(model, engine, cargo, tire);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    bool isAvaible = car.Tires.Tire1Pressure < 1 ||
                        car.Tires.Tire2Pressure < 1 ||
                        car.Tires.Tire3Pressure < 1 ||
                        car.Tires.Tire4Pressure < 1;

                    if (car.Cargos.CargoType == "fragile" && isAvaible)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargos.CargoType == "flamable" && car.Engines.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
