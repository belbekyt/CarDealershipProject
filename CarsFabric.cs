using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie
{
    internal class CarsFabric
    {
        private static string[] engines1 = { "2.0 200HP", "3.2 275HP", "4.6 378HP" };
        private static string[] engines2 = { "1.2 60HP", "1.6 90HP", "1.9 125HP" };
        private static string[] engines3 = { "2.0 160HP", "2.2 200HP", "2.6 230HP" };
        private static string[] engines4 = { "1.6 100HP", "2.0 180HP", "2.2 210HP" };

        private static Car car1 = new Car(1, "X3", "BWM", engines1, 143000, 1);
        private static Car car2 = new Car(2, "AMG 200", "Mercedes", engines1, 160000, 2);
        private static Car car3 = new Car(3, "E-Class 2", "Mercedes", engines2, 125500, 3);
        private static Car car4 = new Car(4, "E36", "BWM", engines2, 35000, 2);
        private static Car car5 = new Car(5, "A4", "Audi", engines1, 40000, 1);
        private static Car car6 = new Car(6, "E90", "BWM", engines3, 110000, 3);
        private static Car car7 = new Car(7, "Prius", "Toyota", engines4, 30000, 2);
        private static Car car8 = new Car(8, "M3", "BWM", engines2, 121500, 3);
        private static Car car9 = new Car(9, "RS7", "Audi", engines3, 220000, 1);

        public static Car[] cars = { car1, car2, car3, car4, car5, car6, car7, car8, car9 };

        public static void ShowDealerCars(int dealerId)
        {
            float totalPrice = 0;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("--------------- Oto dostępne samochody u dealera: ---------------");

            List<int> carsToBuy = new List<int>();

            foreach (Car car in cars)
            {
                if(car.dealer == dealerId)
                {
                    Console.WriteLine("-------------------- " + car.id + " - " + car.brand + " " + car.name + " - " + car.price + " PLN");
                    carsToBuy.Add(car.id);
                }
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("---------------- Wybierz jedno z dostępnych aut -----------------");
            Console.Write("--------------------------- Twój wybór: ");
            String carID = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");

            int? choosenCar = null;
            String[] engines = engines1;

            foreach (int carToBuy in carsToBuy)
            {
                if(carID == carToBuy.ToString()){ choosenCar = carToBuy; }
            }

            if (String.IsNullOrEmpty(choosenCar.ToString()))
            {
                choosenCar = carsToBuy[0];
                Console.WriteLine("----------- Wybrano niepoprawny numer - wybrano domyślne model nr - "+choosenCar+" ----------");
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("------------------------ Wybierz silnik -------------------------");

            foreach (Car car in cars)
            {
                if(choosenCar == car.id)
                {
                    engines = car.engine;
                    totalPrice = car.price;
                }
            }

            int i = 1;
            int enginePrice = 0;

            foreach(String eng in engines)
            {
                Console.WriteLine("-------------------- "+i+" - "+eng+" - "+enginePrice+ " PLN");
                i++;
                enginePrice += 10000;
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("--------------------------- Twój wybór: ");
            String choosenEngine = Console.ReadLine();

            switch (choosenEngine)
            {
                case "1":
                    break;
                case "2":
                    totalPrice += 10000;
                    break;
                case "3":
                    totalPrice += 20000;
                    break;
                default:
                    Console.WriteLine("------------- Zły wybór - Wybrano najsłabszy silnik -------------");
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("---------- Ostateczna cena: "+totalPrice+" PLN ----------");
        }
    }
}
