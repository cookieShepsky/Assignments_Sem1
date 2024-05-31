//by Rody Jansen
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class SnackBar
    {
        private string name;
        private double revenue;
        private List<Snack> snacks;

        public SnackBar(string name)
        {
            this.name = name;
            this.snacks = new List<Snack>();
        }

        public List<Snack> GetSnacks()
        {
            return this.snacks;
        }

        public void AddSnack(string name, int initStock, double price)
        {
            // Add a snack to the list

            foreach (Snack snack in snacks)     /// I feel like there's a better way of iterating through object properties...
            {
                // Ensures the snack doesn't exist already so it can be searched for by name.
                if (snack.GetName() == name)
                {
                    return;
                }
            }

            Snack newSnack = new Snack(name, initStock, price);
            snacks.Add(newSnack);
        }


        public void RemoveSnack(string name)
        {
            // Remove a snack from the list (by name)
            foreach (Snack snack in snacks)
            {
                if (snack.GetName() == name)
                {
                    snacks.Remove(snack);
                }
            }
        }

        /// <summary>
        /// Returns the total price of the ordered items and decrements songs.
        /// </
        public void ProcessOrder(int countSnack1, int countSnack2, int countSnack3)
            //return the total price of the orderered items and remove from stock
        {

        }

        public void UpdateRevenue(double price)
        {

            this.revenue += price;
        }

        public double GetRevenue()
        {
            return Math.Round(this.revenue, 2);
        }

        public override string ToString()
        {
            return this.name;
        }

        public void AddDefaultSnacks()
        {
            this.AddSnack("Kroket", 20, 1.5);
            this.AddSnack("Bamischijf", 15, 2.2);
            this.AddSnack("Knoepert", 12, 3.10);
        }
    }
}
