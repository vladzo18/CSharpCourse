using System;

namespace lab_8_inheritance
{
    class Smartphone : ColorPhone
    {
        public bool HasTouchScreen { get; set; }
        public byte AmountOfTouch { get; set; }
        public byte AmountOfCameras { get; set; }

        public void takePicture(byte numberOfCamera)
        {
            Console.WriteLine($"I'm takeing a picture from {numberOfCamera} camera!!!");
        }
        public void takeVideo(byte numberOfCamera)
        {
            Console.WriteLine($"I'm takeing a video from {numberOfCamera} camera!!!");
        }
    }
}
