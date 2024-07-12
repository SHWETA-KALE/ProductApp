using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.models
{
    internal class Product
    {
        int _id;
        string _name;
        double _price;
        double _discountPercentage;

        //getters method
        public int GetId() { return _id; }
        public string GetName() { return _name; }

        public double GetPrice() { return _price; }
        public double GetDiscountPercentage() { return _discountPercentage; }

        //setters method
        public void SetId(int id) { _id = id; }
        public void SetName(string name) { _name = name; }

        public void SetPrice(double price) { _price = price; }
        public void SetDiscountPercentage(double discountPercentage) { _discountPercentage = discountPercentage; }


        public double CostAfterDiscount()
        {
            return _price * (1 - _discountPercentage/100);
        }
    }
}


