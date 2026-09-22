using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queeless
{
    internal class Order
    {
        private Guid orderNumber;

        public Guid OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public string OrderNumberDisplay
        {
            get { return orderNumber.ToString().Substring(0, 3).ToUpper(); }
        }

        private string orderType;

        public string OrderType
        {
            get { return orderType; }
            set
            {
                if (value == "Collection" || value == "Delivery")
                {
                    orderType = value;
                }
                else
                {
                    orderType = "Collection";
                }
            }
        }

        private string deliveryAddress;

        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }

        }

        private decimal orderTotal;

        public decimal OrderTotal
        {
            get { return orderTotal; }
            set { orderTotal = value; }
        }

        private DateTime dateCreated;

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public Order(string orderType, string deliveryAddress)
        {
            orderNumber = Guid.NewGuid();
            OrderType = orderType;
            DeliveryAddress = deliveryAddress;
            dateCreated = DateTime.Now;
        }
    }
}
