using System;

namespace lab_8_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskPhone dikPhone = new DiskPhone();
            dikPhone.call();
            dikPhone.getCall();

            Console.WriteLine("**********");
            PushButtonPhone pushButtonPhone = new PushButtonPhone();
            pushButtonPhone.getCall();

            Console.WriteLine("**********");
            ColorelessPhone colorelessPhone = new ColorelessPhone();
            colorelessPhone.sendSMS();
            colorelessPhone.getSMS();

            Console.WriteLine("**********");
            ColorPhone colorPhone = new ColorPhone();
            colorPhone.sendMMS();
            colorPhone.getMMS();
            colorPhone.call(false);

            Console.WriteLine("**********");
            Smartphone smartphone = new Smartphone();
            smartphone.takePicture(1);
            smartphone.takeVideo(2);

            Console.ReadKey();
        }
    }
}
