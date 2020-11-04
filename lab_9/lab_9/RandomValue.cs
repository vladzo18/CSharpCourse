using System;

namespace lab_9
{
    public static class RandomValue
    {
        private static Random rand = new Random();
        private static string[] colors = { "Red", "Green", "Blue", "Yellow", "Magenta" };
        public static int randomLeght() => rand.Next(1, 10);
        public static string randomColor() => colors[rand.Next(0, 4)]; 
    }
}
