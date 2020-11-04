using System;

namespace lab_9
{
    class Circle : Shape, IDraw
    {
        private int amountOfVertices = 0;

        public override string Color { get; set; }
        public override int AmountOfVertices { get => amountOfVertices; }
        public override string Name { get; }
        public float Radius { get; set; }

        public Circle(string name)
        {
            Name = name;
            Radius = RandomValue.randomLeght();
            Color = RandomValue.randomColor();
        }
        public Circle(string name, int rad) : this(name) => Radius = rad;
        public Circle(string name, int rad, string color) : this(name, rad) => Color = color;

        public override float calculateArea() => (float)Math.PI * Radius*Radius;
        public override float calculatePrimeter() => 2 * (float)Math.PI * Radius;
        public override void showInfo()
        {
            Console.WriteLine($"Name - {Name}");
            Console.WriteLine($"Color - {Color}");
            Console.WriteLine($"AmountOfVertices - {AmountOfVertices}");
            Console.WriteLine($"Area = {calculateArea()}");
            Console.WriteLine($"Primeter = {calculatePrimeter()}");
        }
        public void Draw()
        {
            switch (Color)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
            Console.WriteLine($"Name - {Name}");
            Console.WriteLine($"Area = {calculateArea()}");
            Console.WriteLine($"Primeter = {calculatePrimeter()}");
            Console.ResetColor();
        }
    }
}
