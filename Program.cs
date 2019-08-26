using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace lab_17
{
    class Car
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Bob's Motor Mall");
            Console.WriteLine("Enter the number of new cars you want to input.");
            int quantity = int.Parse(Console.ReadLine());

            List<Car> amount = new List<Car>(quantity);


            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Please input the car model");
                string model = Console.ReadLine().Trim();

                Console.WriteLine("Please input a vehicle make");
                string make = Console.ReadLine().Trim();

                Console.WriteLine("Please input vehicle year.");
                string w = Console.ReadLine().Trim();
                int year = Convert.ToInt32(w);

                Console.WriteLine("Please input vehicle price.");
                string x = Console.ReadLine().Trim();
                double price = Convert.ToDouble(x);

                Car input = new Car(year, make, model, price);
                amount.Add(new Car(year, make, model, price));
            }

            Console.WriteLine("Current Inventory:");
            for (int i = 0; i < amount.Count; i++)
            {
                int v = i + 1;
                Car full = amount[i];
                Console.WriteLine(full.Model + " " + full.Make + " " + full.Year + " " + full.Price.ToString("C2", CultureInfo.CurrentCulture));
            }
        

            Console.WriteLine("Enter the number of used cars you want to input.");
            int quantity1 = int.Parse(Console.ReadLine());

            List<Car> amount1 = new List<Car>(quantity1);


            for (int i = 0; i < quantity1; i++)
            {
                Console.WriteLine("Please input the used car model");
                string usedmodel = Console.ReadLine().Trim();

                Console.WriteLine("Please input a used vehicle make");
                string usedmake = Console.ReadLine().Trim();

                Console.WriteLine("Please input used vehicle year.");
                string z1 = Console.ReadLine().Trim();
                int usedyear = Convert.ToInt32(z1);


                Console.WriteLine("Please input used vehicle price.");
                string x1 = Console.ReadLine().Trim();
                double usedprice = Convert.ToDouble(x1);

                Console.WriteLine("Please input used mileage");
                string y1 = Console.ReadLine().Trim();
                double usedmileage = Convert.ToDouble(y1);

                usedcars input1 = new usedcars(usedyear, usedmake, usedmodel, usedprice, usedmileage);
                amount1.Add(new usedcars(usedyear, usedmake, usedmodel, usedprice, usedmileage));
            }

            Console.WriteLine("Current Inventory:");
            for (int i = 0; i < amount1.Count; i++)
            {
                int v = i + 1;
                usedCars full = amount[i];
                Console.WriteLine(full.usedModel + " " + full.usedMake + " " + full.usedYear + " " + full.usedPrice.ToString("C2", CultureInfo.CurrentCulture) + " " + full.usedMileage.ToString("C3",CultureInfo.CurrentCulture));
            }
        }
     
    }
}
