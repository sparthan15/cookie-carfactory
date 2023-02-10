using CookieCarFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCarFactory
{
    public class CarFactory
    {
        private readonly List<Car> _builtCars =new List<Car>();

        public static CarFactory Create()
        {
            return new CarFactory();
        }

        public void Build(Car.CarType carType)
        {
            _builtCars.Add(Car.Build(carType));
        }
              

        public IEnumerable<Car> BuiltCars()
        {
            return _builtCars;
        }

        public void MakeManyCars(IEnumerable<Car.CarType> carTypes) { 
            foreach(var type in carTypes){
                _builtCars.Add(Car.Build(type));
            }
        }
    }
}
