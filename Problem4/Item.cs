﻿/*
 * I, Andrew Panko, student number [000394436], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 4th, 2019.
 */

using System;

namespace Problem4
{
    /// <summary>
    /// Represents an abstract item to be put into auction
    /// </summary>
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
