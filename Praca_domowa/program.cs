using System;

namespace zadanie_domowe
{
    class Program
    {

        private String carName = "moj samochod";
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.carName);

            Car car1 = new Car(1999, "Lexus");
            Console.WriteLine(car1);

            Car car2 = new Car(2000, "Renault");
            Console.WriteLine(car2);

            car1 = car2;
            Console.WriteLine(car1);
        }
    }
}