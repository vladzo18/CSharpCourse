using System;

namespace lab_9
{
    class Square : Shape, IDraw
    {
        private int amountOfVertices = 4;

        public override string Color { get ; set; }
        public override int AmountOfVertices { get => amountOfVertices; }
        public override string Name { get; }
        public float LeghtOfSide { get; set; }

        public Square(string name) 
        {
            Name = name;
            LeghtOfSide = RandomValue.randomLeght();
            Color = RandomValue.randomColor();
        }
        public Square(string name, int lgh) : this(name) => LeghtOfSide = lgh;
        public Square(string name, int lgh, string color) : this(name, lgh) => Color = color;

        public override float calculateArea() => LeghtOfSide * LeghtOfSide;
        public override float calculatePrimeter() => LeghtOfSide * AmountOfVertices;
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
                case  "Red":
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
