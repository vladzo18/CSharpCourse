using System;

namespace lab_8_inheritance
{
    class PushButtonPhone : DiskPhone
    {
        public new string avalibleSymbols = "0123456789*#";

        public override void getCall()
        {
            Console.WriteLine("I'm getting call from +380 *********!!!");
        }
    }
}
