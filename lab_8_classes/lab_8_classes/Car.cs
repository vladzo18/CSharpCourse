using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8_classes
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Spead { get; set; }
        public int MadeIn { get; set; }
        public void showInfo()
        {
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"color: {Color}");
            Console.WriteLine($"spead: {Spead}");
            Console.WriteLine($"made in: {MadeIn}");
        }
    }
}
