using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    public abstract class Item
    {
        public Item(string name, double price, DateTimeOffset yearOfCreation, bool isNew)
        {
            this.Name = name;
            this.Price = price;
            this.IsNew = isNew;
            this.YearOfCreation = yearOfCreation;
        }


        public string Name { get; set; }

        public double Price { get; set; }

        public bool IsNew { get; set; }

        public DateTimeOffset YearOfCreation { get; set; }

        public abstract void Notify();
    }
}
