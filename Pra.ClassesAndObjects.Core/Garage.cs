using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.ClassesAndObjects.Core
{
    public class Garage
    {
        private List<Car> cars;
        private List<CarType> carTypes;

        public List<CarType> CarTypes
        {
            get { return new List<CarType>(carTypes); }
        }

        public List<Car> Cars
        {
            get { return new List<Car>(cars); }
        }

        public Garage(bool createTestData)
        {
            SeedCartypes();
            if (createTestData)
                SeedCars();
            else
                cars = new List<Car>();
        }

        void SeedCartypes()
        {
            carTypes = new List<CarType>
            {
                new CarType("Sedan", false),
                new CarType("Break", false),
                new CarType("SUV", false),
                new CarType("SUV", true),
                new CarType("Van", true)
            };
        }

        void SeedCars()
        {
            cars = new List<Car>
            {
                new Car
                {
                    Brand = "Ford",
                    CarType = carTypes[0],
                    Color = "wit",
                    Price = 27000M,
                    TopSpeed = 200
                },
                new Car
                {
                    Brand = "Dacia",
                    CarType = carTypes[1],
                    Color = "groen",
                    Price = 17000M,
                    TopSpeed = 150
                },
                new Car
                {
                    Brand = "Bentley",
                    CarType = carTypes[3],
                    Color = "grijs",
                    Price = 350000M,
                    TopSpeed = 280
                }
            };
        }

        public void AddCar(Car car)
        {
            if (car != null)
                cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }


    }

}
