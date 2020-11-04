namespace lab_9
{
    abstract class Shape
    {
        abstract public string Color { get; set; }
        abstract public int AmountOfVertices { get; }
        abstract public string Name { get; }

        abstract public float calculateArea(); 
        abstract public float calculatePrimeter();
        abstract public void showInfo();
    }
}
