using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queeless
{
    internal class MenuItem
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private string catergory;

        public string Category
        {
            get { return catergory; }
            set { catergory = value; }
        }

        private int stockQuantity;

        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }

        private string storeName;

        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }
        public override string ToString()
        {
            return name;
        }


        public MenuItem(string name, decimal price, string catergory, int stockQuantity, string storeName)
        {
            this.name = name;
            this.price = price;
            this.catergory = catergory;
            this.stockQuantity = stockQuantity;
            this.storeName = storeName;
        }

        public bool isAvailable()
        {
            if (stockQuantity > 0)
            {
                return true;
            }
            return false;
        }
    }
}
