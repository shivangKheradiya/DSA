using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics_T066
{
    internal class Cars
    {
        private List<Car> cars = new List<Car>();

        public Cars() {
            cars.Add(new Car() { ID=1, Name="A"});
            cars.Add(new Car() { ID=2, Name="B"});
            cars.Add(new Car() { ID=3, Name="C", Wheels = 8 });
            cars.Add(new Car() { ID=4, Name="D"});
            cars.Add(new Car() { ID=5, Name = "A", Wheels = 8 });
        }

        public string this[int idx]
        {
            get
            {
                return cars.FirstOrDefault(c=>c.ID == idx).Name;
            }
            set
            {
                cars.FirstOrDefault(c => c.ID == idx).Name = value;
            }
        }

        // Overloading
        public string this[string name]
        {
            get 
            {
                return cars.Count(c=> c.Name == name).ToString();
            }
            set
            {
                foreach (Car item in cars)
                {
                    if (item.Name == name)
                    {
                        item.Name = value;
                    }
                }
            }
        }
    }

    internal class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; } = 4;
    }
}
