using CookieCarFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCarFactory.Test.Model
{
    public class SchooCarTest
    {
        private readonly Car schoolCar = Car.Build(Car.CarType.SCHOOLCAR);
        [Fact]
        void canCreateSchoolCar()
        {
            Assert.NotNull(schoolCar);
        }

        [Fact]
        void schoolCarHasBabyChair()
        {
            Assert.True(schoolCar.HasBabyChair());
        }
        
        [Fact]
        void schoolCarCanReachUpTo50MilesPerHour()
        {
            Assert.Equal(Car.SpeedLimit.Fifthy, schoolCar.MaxSpeed());
        }
    }
}
