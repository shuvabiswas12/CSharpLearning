using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OOPs
{
    class OopClass_1
    {
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; private set; }

        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(int id, string name) : this()
        {
            this.Id = id;
            this.Name = name;
        }

        public void OrderDetail()
        {
            Console.WriteLine("Customer Name = {0}, Customer Id = {1}", this.Name, this.Id);
            Console.WriteLine("====================================");
            for (int i = 0; i < Orders.Count; i++)
            {
                this.Orders[i].ProductDetails();
            }
        }


    }

    public class Order
    {
        // private fields should always starts with "_" underscore sign.

        private readonly string _productName;
        private readonly int _productId;
        private readonly double _price;

        public Order(string productName, int productId, double price)
        {
            this._productName = productName;
            this._productId = productId;
            this._price = price;
        }

        public void ProductDetails()
        {
            Console.WriteLine("Product Name = {0}, Product Id = {1}, _price = {2}", this._productName, this._productId, this._price);
        }
    }
}
