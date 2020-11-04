using System.Collections.Generic;

namespace lab_9
{
    class Picture : IDraw
    {
        private List<Shape> shapes = new List<Shape>();

        public int AmountOfShapes { get; private set; }

        public Picture () { }
        public Picture(int leght) { }

        public Shape this[int index] { get => shapes[index]; }

        public void addNewShape(string name, char typeShape)
        {
            switch (typeShape)
            {
                case 'c':
                    shapes.Add(new Circle(name));
                    break;
                case 't':
                    shapes.Add(new Triangle(name));
                    break;
                case 's':
                    shapes.Add(new Square(name));
                    break;
            }
            AmountOfShapes++;
        }
        public void deleteShape(string name)
        {
            for (var i = 0; i < shapes.Count; i++)
                if (shapes[i].Name == name)
                {
                    shapes.RemoveAt(i);
                    break;
                }
            AmountOfShapes--;
        }
        public void Draw()
        {
            for (var i = 0; i < shapes.Count ; i++)
            {
                if (shapes[i] is Circle)
                {
                    Circle c = (Circle)shapes[i];
                    c.Draw();
                }else if (shapes[i] is Square)
                {
                    Square s = (Square)shapes[i];
                    s.Draw();
                }else
                {
                    Triangle t = (Triangle)shapes[i];
                    t.Draw();
                } 
            }
        }
    }
}
