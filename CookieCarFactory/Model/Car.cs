using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CookieCarFactory.Model
{
    public class Car
    {
        protected bool _hasBabyChair;
        protected int _maxSpeed;
        protected int _numberOfDoors;
        protected Car(bool hasBabyChair, int maxSpeed, int numberOfDoors)
        {
            _hasBabyChair = hasBabyChair;
            _maxSpeed = maxSpeed;   
            _numberOfDoors = numberOfDoors;
        }

        public static Car Build(CarType carType)
        {
            if (carType.Equals(CarType.SCHOOLCAR))
                return new SchoolCar();
            else
                return new RacingCar();
        }


        public bool HasBabyChair()
        {
            return _hasBabyChair;
        }

        public int MaxSpeed()
        {
            return _maxSpeed;
        }

        public int NumberOfDoors()
        {
            return _numberOfDoors;
        }

        public struct SpeedLimit
        {
            public const int Fifthy = 50;
            public const int ThreeHundred = 300;
        }

        public enum CarType{
            SCHOOLCAR, RACINGCAR
        }
    }

   

}
