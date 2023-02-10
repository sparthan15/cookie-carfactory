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

        protected Car(bool hasBabyChair, int maxSpeed)
        {
            _hasBabyChair = hasBabyChair;
            _maxSpeed = maxSpeed;   
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
