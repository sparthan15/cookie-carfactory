using CookieCarFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCarFactory.Test.Model
{
    public class RacingCarTest
    {
        private readonly Car racingCar = Car.Build(Car.CarType.RACINGCAR);

        [Fact]
        void canCreateRacingCar()
        {            
            Assert.NotNull(racingCar);  
        }

        [Fact]
        void racingCarCanReach300MilesPerHour()
        {
            Assert.Equal(Car.SpeedLimit.ThreeHundred, racingCar.MaxSpeed());
        }

        [Fact]
        void racingCarHasNoBabyChair()
        {
            Assert.False(racingCar.HasBabyChair());
        }
    }
}
