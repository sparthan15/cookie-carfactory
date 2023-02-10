using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCarFactory.Model
{
    internal sealed class SchoolCar : Car
    {
        public SchoolCar():base(true, SpeedLimit.Fifthy) { }
      
    }
}
