using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queeless
{
    internal class OrderItem
    {
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal unitPrice;

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public MenuItem OrderedMenuItem { get; set; }

        //public OrderItem(string itemName, int quantity, decimal unitPrice)
        //{
        //    OrderedMenuItem = menuItem;
        //    this.itemName = itemName;
        //    this.quantity = quantity;
        //    this.unitPrice = unitPrice;
        //}

        public OrderItem(MenuItem menuItem, int quantity)
        {
            OrderedMenuItem = menuItem;
            itemName = menuItem.Name;
            unitPrice = menuItem.Price;
            this.quantity = quantity;
        }

       
        public decimal CalculateItemsTotal()
        {
            decimal total = unitPrice * quantity;
            return total;
        }
    }
}
