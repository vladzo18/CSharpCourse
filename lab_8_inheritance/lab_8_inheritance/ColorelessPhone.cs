using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8_inheritance
{
    class ColorelessPhone : PushButtonPhone
    {
        public new string avalibleSymbols = "0123456789*#ABCDEFGHIKLMNOPQRSTVXYZ";
        public string ScrineSize { get; set; }
        public int ScreenResolution { get; set; }
        public string Color { get; set; }

        public void sendSMS()
        {
            Console.WriteLine("I'm sending a SMS!!!");
        }
        public void getSMS()
        {
            Console.WriteLine("I'm getting a SMS!!!");
        }
    }
}
