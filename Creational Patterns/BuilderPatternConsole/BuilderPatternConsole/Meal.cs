using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternConsole
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public double GetCost()
        {
            double cost = 0.0f;

            foreach(var item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {

            foreach(Item item in items)
            {
                Console.Write("Item : " + item.Name());
                Console.Write(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }

    }
}
