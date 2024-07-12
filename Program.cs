using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.models;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Prod1 = new Product();
            Product Prod2 = new Product();

            Prod1.SetId(1);
            Prod1.SetName("Computer");
            Prod1.SetPrice(50000);
            Prod1.SetDiscountPercentage(20);

            Prod2.SetId(2);
            Prod2.SetName("Laptop");
            Prod2.SetPrice(40000);
            Prod2.SetDiscountPercentage(30);


            // Displaying details and cost after discount
            Console.WriteLine($"Product ID: {Prod1.GetId()}\n" +
                $"Name: {Prod1.GetName()}\n" +
                $"Price: {Prod1.GetPrice()} \n" +
                $"Discount: {Prod1.GetDiscountPercentage()} \n" +
                $"CostAfterDiscount: {Prod1.CostAfterDiscount()} \n");

            //Console.WriteLine($"Product ID: {Prod2.GetId()}, Name: {Prod2.GetName()}, Price: {Prod2.GetPrice()}, Discount: {Prod2.GetDiscountPercentage()}%, Cost after discount: {Prod2.CostAfterDiscount()}"));
            Console.WriteLine($"Product ID: {Prod2.GetId()}\n" +
                $"Name: {Prod2.GetName()}\n" +
                $"Price: {Prod2.GetPrice()}\n" +
                $"Discount: {Prod2.GetDiscountPercentage()}\n" +
                $"CostAfterDiscount: {Prod2.CostAfterDiscount()}\n");
                



        }
    }
}
