using System;

namespace lab_8_inheritance
{
    class ColorPhone : ColorelessPhone
    {
        public int AmountOfColors { get; set; }
        public bool HasThoSIM { get; set; }
        public string twoPhoneNumber { get; set; }

        public void sendMMS()
        {
            Console.WriteLine("I'm sending a MMS!!!");
        }
        public void getMMS()
        {
            Console.WriteLine("I'm getting a MMS!!!");
        }
        public void call(bool callFromFirstSIM = true)
        {
            if (callFromFirstSIM) base.call(); else Console.WriteLine("I'm calling from seconde SIM!!!");
        }
    }
}
