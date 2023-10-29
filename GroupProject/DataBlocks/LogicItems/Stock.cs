using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBlocks.LogicItems
{
    public class Stock
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Amount { get; private set; }
        public string Description { get; private set; }
        public Stock()
        {
            
        }

        public Stock(int id, string name, decimal price, int amount, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id}: {Name} - Price {Price:f2} - Quantity: {Amount} ({Description})";
        }

        public void UpdateAmount(int newAmount)
        {
            Amount = newAmount;
        }
    }
}
