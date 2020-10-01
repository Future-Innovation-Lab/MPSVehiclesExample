using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
               Car honda = new Car(2003,"Jazz",0);
            Car vw = new Car(2020,"Polo",10);
            vw.DriveFaster(45);
            vw.Make = "Golf";
           // Console.WriteLine("CAR 1: " + vw.Speed);
            Console.WriteLine("CAR 1: " + vw.Make);

            Car bmw = new Car(2019,"M3",0);
            bmw.DriveFaster(160);
            bmw.DriveSlower(70);

           // Console.WriteLine("CAR 2: " + bmw.Speed);
            Console.WriteLine("CAR 2: " + bmw.Make);

            Car rollsRoyce = new Car(2019,"Phantom",0);
            rollsRoyce.DriveFaster(23);

            Car mazda = new Car(1989,"323",0);
            mazda.DriveFaster(2);

            Car toyota = new Car(1973,"Cresida",0);
            toyota.DriveFaster(180);

         
            honda.DriveFaster(1);

              Console.WriteLine("CAR 3: " + rollsRoyce.Make);
              Console.WriteLine("CAR 4: " + mazda.Make);
              Console.WriteLine("CAR 5: " + toyota.Make);
              Console.WriteLine("CAR 6: " + honda.Make);

        }
    }
}
