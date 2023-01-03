using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie
{
    internal class DealerCheck
    {
        public static int DealerIdCheck()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-----------------------Wybierz dealera aut:----------------------");
            Console.WriteLine("------------------------ 1 - Jacek Kowalski ---------------------");
            Console.WriteLine("------------------------ 2 - Bartek Polański --------------------");
            Console.WriteLine("------------------------ 3 - Kazimierz Cyfran -------------------");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("--------------------------- Twój wybór: ");

            string dealer = Console.ReadLine();

            if (dealer == "1" || dealer == "2" || dealer == "3") {
                return int.Parse(dealer);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór - wybrano domyślnie Dealera nr. 1.");
                return 1;
            }
        }
    }
}
