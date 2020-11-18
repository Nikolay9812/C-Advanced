using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, Engine engines, Cargo cargos, Tire tires)
        {
            this.Model = model;
            this.Engines = engines;
            this.Cargos = cargos;
            this.Tires = tires;
        }

        public string Model { get; set; }

        public Engine Engines { get; set; }

        public Cargo Cargos { get; set; }

        public Tire Tires { get; set; }
    }
}
