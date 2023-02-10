using CookieCarFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCarFactory.Test
{
    public class CarFactoryTest
    {
        private CarFactory carFactory = new CarFactory();

        [Fact]
        void canCreateCarFactory()
        {
            Assert.NotNull(carFactory);
        }

        [Fact]
        void canBuildOneCar()
        {
            carFactory.Build(Car.CarType.RACINGCAR);
            Assert.Single(carFactory.BuiltCars());
        }

        [Fact]
        void canBuildManyCars()
        {
            var modelsToBuild = new List<Car.CarType>(){
                Car.CarType.RACINGCAR,
                Car.CarType.SCHOOLCAR
            };
            
            carFactory.MakeManyCars(modelsToBuild);
            Assert.Equal(2, carFactory.BuiltCars().Count());
        }

    }
}
