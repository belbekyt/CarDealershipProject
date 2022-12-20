using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie
{
    internal class CarsFabric
    {
        private static string[] colors1 = { "Blue", "Red", "SkyBlue" };
        private static string[] colors2 = { "Red", "Green", "Yellow" };
        private static string[] colors3 = { "Blue", "Magenta", "Gray" };
        private static string[] colors4 = { "Cyan", "Black", "Purple" };

        private static string[] engines1 = { "2.0 200HP", "3.2 275HP", "4.6 378HP" };
        private static string[] engines2 = { "1.2 60HP", "1.6 90HP", "1.9 125HP" };
        private static string[] engines3 = { "2.0 160HP", "2.2 200HP", "2.6 230HP" };
        private static string[] engines4 = { "1.6 100HP", "2.0 180HP", "2.2 210HP" };

        private static Car car1 = new Car("X3", "BWM", colors1, engines1, 143000, 1);
        private static Car car2 = new Car("AMG 200", "Mercedes", colors2, engines1, 160000, 2);
        private static Car car3 = new Car("E-Class 2", "Mercedes", colors1, engines2, 125500, 3);
        private static Car car4 = new Car("E36", "BWM", colors3, engines2, 35000, 2);
        private static Car car5 = new Car("A4", "Audi", colors4, engines1, 40000, 1);
        private static Car car6 = new Car("E90", "BWM", colors4, engines3, 110000, 3);
        private static Car car7 = new Car("Prius", "Toyota", colors2, engines4, 30000, 2);
        private static Car car8 = new Car("M3", "BWM", colors1, engines2, 121500, 3);
        private static Car car9 = new Car("RS7", "Audi", colors3, engines3, 220000, 1);

        public static Car[] cars = { car1, car2, car3, car4, car5, car6, car7, car8, car9 };

        public static void ShowDealerCars(int dealerId)
        {
            foreach(Car car in cars)
            {
                if(car.dealer == dealerId)
                {
                    Console.WriteLine(car.brand + " " + car.name);
                }
            }
        }
    }
}
