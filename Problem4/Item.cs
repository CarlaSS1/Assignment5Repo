using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    public abstract class Item
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Item"/> class
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="price">The price.</param>
        /// <param name="yearOfCreation">The Year of Creation</param>
        /// <param name="isNew">Flag for new item or not.</param>
        public Item(string name, double price, DateTimeOffset yearOfCreation, bool isNew)
        {
            this.Name = name;
            this.Price = price;
            this.IsNew = isNew;
            this.YearOfCreation = yearOfCreation;
        }

        /// <summary>
        /// Gets or sets the name of the item
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price of an item
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets flag for an item if its new.
        /// </summary>
        /// <value>Flag for item: True (New), false (not new)</value>
        public bool IsNew { get; set; }

        /// <summary>
        /// Gets or sets the year of the item.
        /// </summary>
        /// <value>The year of creation</value>
        public DateTimeOffset YearOfCreation { get; set; }

        /// <summary>
        /// Notifies all bidders.
        /// </summary>
        public abstract void Notify();
    }
}
