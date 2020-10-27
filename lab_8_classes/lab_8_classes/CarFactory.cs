using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8_classes
{
    class CarFactory
    {
        Car newCar;
        public ref Car createCar(string name, string color = null, int spead = 0, int madeIn = 0)
        {
            newCar = new Car();
            newCar.Name = name;
            newCar.Color = color;
            newCar.Spead = spead;
            newCar.MadeIn = madeIn;

            return ref newCar;
        }
    }
}
