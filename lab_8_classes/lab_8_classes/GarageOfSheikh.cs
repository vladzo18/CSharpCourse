using System;
using System.Collections.Generic;

namespace lab_8_classes
{
    class GarageOfSheikh
    {
        private List<Car> garage = new List<Car>();
        public void buyCar(ref Car newCar)
        {
            garage.Add(newCar);
        }
        public void throwCar(string name)
        {
            bool carIsFind = false;
            for (var i = 0; i < garage.Count; i++)
            {
                if (garage[i].Name == name)
                {
                    garage.RemoveAt(i);
                    carIsFind = true;
                } else if(garage.Count - 1 == i && !carIsFind) Console.WriteLine("Sorry, I cant't that car!!!");
            }
        }
        public void rideCar(string name, string color = null, int spead = 0, int madeIn = 0)
        {
            bool carIsFind = false;
            for (int i = 0; i < garage.Count; i++)
            {
                if (garage[i].Name == name || (garage[i].Name == name && (garage[i].Color == color || garage[i].Spead == spead || garage[i].MadeIn == madeIn)))
                {
                    Console.WriteLine("That was a great rideing!!!");
                    carIsFind = true;
                } else if (garage.Count - 1 == i && !carIsFind) Console.WriteLine("Sorry, I can't find this car in my garage!!!");
            }
            showInfo();
        }
        private void showInfo()
        {
            Console.WriteLine("I have this cars: ");
            foreach (Car car in garage) {
                car.showInfo();
                Console.WriteLine();
            }
        }
    }
}
