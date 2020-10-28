using System;

namespace lab_8_inheritance
{
    class DiskPhone
    {
        public string phoneNumber { get; set; }
        public string avalibleSymbols = "0123456789";

        public virtual void call()
        {
            Console.WriteLine("I'm calling!!!");
        }
        public virtual void getCall()
        {
            Console.WriteLine("I'm geting call!!!");
        }
    }
}
