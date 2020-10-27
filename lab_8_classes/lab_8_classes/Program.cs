using System;

namespace lab_8_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageOfSheikh sheikh = new GarageOfSheikh();
            CarFactory factory = new CarFactory();
            /////////////////////////////////////////////////////////////////
            // Тести
            /*
            Car car1 = new Car();
            car1.Name = "Honda";
            car1.Color = "red";

            Car car2 = new Car();
            car2.Name = "BMW";
            car2.MadeIn = 1995;

            sheikh.buyCar(ref car1);
            sheikh.buyCar(ref car2);

            sheikh.rideCar("Honda","red");
            sheikh.rideCar("VAZ");
            sheikh.rideCar("BMW", madeIn: 1995);

          
            sheikh.buyCar(ref factory.createCar("VAZ", spead: 95));
            sheikh.buyCar(ref factory.createCar("NIVA"));
            sheikh.rideCar("VAZ");
            sheikh.throwCar("VAZ");
            sheikh.rideCar("VAZ");
            */
            ////////////////////////////////////////////////////////////////

            sheikh.buyCar(ref factory.createCar("VAZ"));
            sheikh.buyCar(ref factory.createCar("NIVA", "white"));
            sheikh.buyCar(ref factory.createCar("Honda", "dark", 120, 2010));
            sheikh.buyCar(ref factory.createCar("BMW", "dark", 85, 2005));

            sbyte choice = 0;
            string[] infoAboutCar = new string[4];
            bool exist = true;

            Console.WriteLine("You're a sheikh!!!, What would you like to do?");
            while (exist)
            {
                Console.WriteLine("1 - bay a new car");
                Console.WriteLine("2 - throw a car");
                Console.WriteLine("3 - ride on a car");
                Console.WriteLine("0 - go away from my garage");

                try
                {
                    choice = sbyte.Parse(Console.ReadLine());
                }
                catch { }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Garage closed. Have a nice day!");
                        exist = false;
                        break;
                    case 1:
                        Console.WriteLine("Enter how called your car");
                        enterInfoAboutCar(ref infoAboutCar);
                        sheikh.buyCar(ref factory.createCar(infoAboutCar[0], infoAboutCar[1], Convert.ToInt32(infoAboutCar[2]), Convert.ToInt32(infoAboutCar[3])));
                        break;
                    case 2:
                        Console.WriteLine("Enter how called your car");
                        enterInfoAboutCar(ref infoAboutCar);
                        sheikh.throwCar(infoAboutCar[0]);
                        break;
                    case 3:
                        Console.WriteLine("Enter how called your car,a lso you can call another propertis");
                        enterInfoAboutCar(ref infoAboutCar);
                        sheikh.rideCar(infoAboutCar[0], infoAboutCar[1], Convert.ToInt32(infoAboutCar[2]), Convert.ToInt32(infoAboutCar[3]));
                        break;
                    default:
                        Console.WriteLine("INCORRECT OPTION!");
                        break;
                }
            }

            Console.ReadKey();
        }
        private static void enterInfoAboutCar(ref string[] info)
        {
            Console.WriteLine("Enter proterty of car, if you don't know enter>> \"-\" ");
            Console.Write("Name>> ");
            info[0] = Console.ReadLine();
            Console.Write("Color>> ");
            info[1] = Console.ReadLine();
            Console.Write("Spead>> ");
            info[2] = Console.ReadLine();
            Console.Write("What year of made>> ");
            info[3] = Console.ReadLine();
            Console.WriteLine();
            for (var i = 0; i < info.Length; i++) if (info[i] == "-") info[i] = "0";
        }
    }
}
