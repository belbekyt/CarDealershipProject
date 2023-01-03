using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie
{
    internal class Car
    {
        public int id;
        public string name;
        public string brand;
        public string[] engine;
        public float price;
        public int dealer;

        public Car(int carId, string carName, string carBrand, string[] carEngine, float carPrice, int carDealer)
        {
            id = carId;
            name = carName;
            brand = carBrand;
            engine = carEngine;
            price = carPrice;
            dealer = carDealer;
        }
    }
}
