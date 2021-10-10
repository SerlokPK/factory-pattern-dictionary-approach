using Domain.Models.CarParts;
using Domain.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Factories
{
    /// <summary>
    /// Factory that creates instance of a car based on cars name
    /// </summary>
    public class CarFactory
    {
        private readonly Dictionary<string, Func<Car>> cars;

        /// <summary>
        /// Constructor
        /// </summary>
        public CarFactory()
        {
            cars = new Dictionary<string, Func<Car>>();

            AddType("Audi", () => new Audi(new Manual(), new Seat()));
            AddType("Mercedes", () => new Mercedes(new Automatic()));
        }

        /// <summary>
        /// Indexer used for getting instance of a specific car
        /// </summary>
        /// <param name="carType">Key used to retrieve a car</param>
        /// <returns>Car object</returns>
        public Car this[string carType] => CreateCar(carType);

        /// <summary>
        /// Get instance of a specific car
        /// </summary>
        /// <param name="carType">Key used to retrieve a car</param>
        /// <returns>Car object</returns>
        public Car CreateCar(string carType) => cars[carType]();

        /// <summary>
        /// Get all available car types
        /// </summary>
        public IEnumerable<string> AvailableTypes => cars.Keys.ToList();

        private void AddType(string carType, Func<Car> factoryMethod)
        {
            if (string.IsNullOrEmpty(carType) || factoryMethod is null)
            {
                return;
            }

            cars[carType] = factoryMethod;
        }
    }
}
