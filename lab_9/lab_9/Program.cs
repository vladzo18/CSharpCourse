using System;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1.1
            var square = new Square("mySquare");
            square.showInfo();

            Console.WriteLine();
            var circle = new Circle("myCircle");
            circle.showInfo();

            Console.WriteLine();
            var triangle = new Triangle("myTriangle");
            triangle.showInfo();

            // Завдання 2
            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            var pct = new Picture();
            pct.addNewShape("mySquare 2", 's');
            pct.addNewShape("myCircle 2", 'c');
            pct.addNewShape("myTriangle 2", 't');
            
            for(var i = 0; i < pct.AmountOfShapes; i++)
            {
                pct[i].showInfo();
                Console.WriteLine();
            }

            // Завдання 3
            Console.WriteLine(new string('*', 30));
            square.Draw();
            Console.WriteLine();
            circle.Draw();
            Console.WriteLine();
            triangle.Draw();
            Console.WriteLine(new string('-', 30));
            pct.Draw();
            pct.deleteShape("myCircle 2");
            Console.WriteLine();
            pct.Draw();

            Console.WriteLine(new string('#', 70));
            Painter.Draw(square);
            Painter.Draw(circle);
            Painter.Draw(triangle);

            //Delay
            Console.ReadKey(); 
        }
    }
}
