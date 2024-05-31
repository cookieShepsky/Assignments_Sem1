//by Rody Jansen
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Snack
    {
        string name;
        int stock;
        double price;

        public Snack(string name, int stock, double price)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
        }

        public bool DecrementStock(int amount)
        {
            if (stock >= amount)
            { 
                this.stock -= amount;
                return true;
            }
            else
            {
                MessageBox.Show("Not enough stock.");
                return false;
            }
        }

        public void IncrementStock(int amount)
        {
            this.stock += amount;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetStock()
        {
            return this.stock;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return $"{this.name} - Stock: {this.stock} - price: \u20AC {this.price}";
        }
    }
}
