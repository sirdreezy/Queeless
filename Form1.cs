using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Queeless
{
    public partial class frmQueueLessOrderingSystem : Form
    {
        public frmQueueLessOrderingSystem()
        {
            InitializeComponent();
        }
        List<Store> stores = new List<Store>();
        List<MenuItem> menuItems = new List<MenuItem>();

        List<OrderItem> currentOrder = new List<OrderItem>();

        private void frmQueueLessOrderingSystem_Load(object sender, EventArgs e)
        {
            //Vida , Fish and chips,Halal kitchen , "Best Sushie, X-Presso, 
            stores.Add(new Store("APK", "Vida"));
            stores.Add(new Store("APK", "Fish and chips"));
            stores.Add(new Store("APK", "Halal Kitchen"));
            stores.Add(new Store("APK", "Best Sushie"));

            stores.Add(new Store("APB", "Halal Kitchen"));
            stores.Add(new Store("APB", "Best Sushie"));
            stores.Add(new Store("APB", "Fish and chips"));
            stores.Add(new Store("APB", "X-Presso"));

            stores.Add(new Store("DFC", "Vida"));
            stores.Add(new Store("DFC", "X-Presso"));
            stores.Add(new Store("DFC", "Fish and chips"));

            stores.Add(new Store("Soweto", "Vida"));
            stores.Add(new Store("Soweto", "Halal Kitchen"));
            stores.Add(new Store("Soweto", "Best Sushie"));

            //VIDA FOOD 
            menuItems.Add(new MenuItem("Chicken Mayo Toastie", 35.00m, "Food", 15, "Vida"));
            menuItems.Add(new MenuItem("Cheese & Tomato Toastie", 30.00m, "Food", 15, "Vida"));
            menuItems.Add(new MenuItem("Ham & Cheese Panini", 38.00m, "Food", 12, "Vida"));
            menuItems.Add(new MenuItem("Bacon & Egg Toastie", 36.00m, "Food", 12, "Vida"));
            menuItems.Add(new MenuItem("Chicken Schnitzel Wrap", 42.00m, "Food", 10, "Vida"));
            menuItems.Add(new MenuItem("Beef Pie", 28.00m, "Food", 20, "Vida"));
            menuItems.Add(new MenuItem("Chicken Pie", 28.00m, "Food", 20, "Vida"));

            //VIDA DRINKS 
            menuItems.Add(new MenuItem("Cappuccino", 22.00m, "Drinks", 25, "Vida"));
            menuItems.Add(new MenuItem("Latte", 22.00m, "Drinks", 25, "Vida"));
            menuItems.Add(new MenuItem("Red Bull", 28.00m, "Drinks", 15, "Vida"));
            menuItems.Add(new MenuItem("Iced Coffee", 25.00m, "Drinks", 15, "Vida"));
            menuItems.Add(new MenuItem("Orange Juice", 18.00m, "Drinks", 15, "Vida"));
            // VIDA DESSERTS
            menuItems.Add(new MenuItem("Blueberry Muffin", 20.00m, "Desserts", 15, "Vida"));
            menuItems.Add(new MenuItem("Chocolate Muffin", 20.00m, "Desserts", 15, "Vida"));
            menuItems.Add(new MenuItem("Vanilla Cupcake", 18.00m, "Desserts", 12, "Vida"));
            menuItems.Add(new MenuItem("Chocolate Brownie", 22.00m, "Desserts", 12, "Vida"));


            // FISH AND CHIPS FOOD
            menuItems.Add(new MenuItem("Regular Fish and Chips", 45.00m, "Food", 15, "Fish and chips"));
            menuItems.Add(new MenuItem("Large Fish and Chips", 55.00m, "Food", 10, "Fish and chips"));
            menuItems.Add(new MenuItem("Fat Cake and Chips", 50.00m, "Food", 10, "Fish and chips"));
            menuItems.Add(new MenuItem("Quarter Kota", 25.00m, "Food", 18, "Fish and chips"));
            menuItems.Add(new MenuItem("Full Kota", 55.00m, "Food", 10, "Fish and chips"));
            menuItems.Add(new MenuItem("Chicken Kota", 42.00m, "Food", 12, "Fish and chips"));
            menuItems.Add(new MenuItem("Russian and Chips", 30.00m, "Food", 16, "Fish and chips"));

            // DRINKS 
            menuItems.Add(new MenuItem("Coke", 15.00m, "Drinks", 25, "Fish and chips"));
            menuItems.Add(new MenuItem("Sprite", 15.00m, "Drinks", 25, "Fish and chips"));
            menuItems.Add(new MenuItem("Fanta", 15.00m, "Drinks", 25, "Fish and chips"));
            menuItems.Add(new MenuItem("Water", 12.00m, "Drinks", 30, "Fish and chips"));
            /// DESSERTS
            menuItems.Add(new MenuItem("SIMBA", 18.00m, "Desserts", 15, "Fish and chips"));
            menuItems.Add(new MenuItem("Doughnut", 15.00m, "Desserts", 18, "Fish and chips"));
            menuItems.Add(new MenuItem("DORITOS", 20.00m, "Desserts", 12, "Fish and chips"));
            menuItems.Add(new MenuItem("Vanilla Ice Cream", 20.00m, "Desserts", 10, "Fish and chips"));
            menuItems.Add(new MenuItem("Chocolate Ice Cream", 20.00m, "Desserts", 10, "Fish and chips"));


            //HALAL KITCHEN;
            //FOOD
            menuItems.Add(new MenuItem("Chicken Biryani", 50.00m, "Food", 12, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Mutton Biryani", 60.00m, "Food", 8, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Butter Chicken", 48.00m, "Food", 10, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Chicken Curry", 42.00m, "Food", 12, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Chicken Tikka Wrap", 38.00m, "Food", 14, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Samoosas (4pc)", 25.00m, "Food", 18, "Halal Kitchen"));
            // DRINKS
            menuItems.Add(new MenuItem("Mango Lassi", 22.00m, "Drinks", 15, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Rooh Afza", 20.00m, "Drinks", 15, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Coke", 15.00m, "Drinks", 25, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Iced Tea", 18.00m, "Drinks", 15, "Halal Kitchen"));

            // DESSRETS
            menuItems.Add(new MenuItem("Gulab Jamun (3pc)", 20.00m, "Desserts", 15, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Falooda", 25.00m, "Desserts", 10, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Baklava (2pc)", 22.00m, "Desserts", 12, "Halal Kitchen"));
            menuItems.Add(new MenuItem("Kulfi", 20.00m, "Desserts", 10, "Halal Kitchen"));


            //Best Sushie,
            //Food
            menuItems.Add(new MenuItem("California Roll (6pc)", 45.00m, "Food", 12, "Best Sushie"));
            menuItems.Add(new MenuItem("Salmon Roll (6pc)", 55.00m, "Food", 10, "Best Sushie"));
            menuItems.Add(new MenuItem("Chicken Katsu Roll", 42.00m, "Food", 12, "Best Sushie"));
            menuItems.Add(new MenuItem("Vegetable Roll", 35.00m, "Food", 14, "Best Sushie"));
            menuItems.Add(new MenuItem("Prawn Tempura Roll", 50.00m, "Food", 8, "Best Sushie"));
            menuItems.Add(new MenuItem("Sushi Platter (12pc)", 85.00m, "Food", 6, "Best Sushie"));
            // drinks 
            menuItems.Add(new MenuItem("Water", 18.00m, "Drinks", 15, "Best Sushie"));
            menuItems.Add(new MenuItem("Coke", 15.00m, "Drinks", 25, "Best Sushie"));
            menuItems.Add(new MenuItem("Sprite", 15.00m, "Drinks", 25, "Best Sushie"));
            menuItems.Add(new MenuItem("Iced Tea", 18.00m, "Drinks", 15, "Best Sushie"));
            //desserts
            menuItems.Add(new MenuItem("Mochi Ice Cream (3pc)", 25.00m, "Desserts", 12, "Best Sushie"));
            menuItems.Add(new MenuItem("Dorayaki", 20.00m, "Desserts", 12, "Best Sushie"));
            menuItems.Add(new MenuItem("Fruit Salad", 22.00m, "Desserts", 12, "Best Sushie"));

            //X-Presso
            //food
            menuItems.Add(new MenuItem("Chicken Mayo Sandwich", 14.00m, "Food", 50, "X-Presso"));
            menuItems.Add(new MenuItem("Egg Mayo Sandwich", 14.00m, "Food", 50, "X-Presso"));
            menuItems.Add(new MenuItem("Bacon Toastie", 14.00m, "Food", 50, "X-Presso"));
            menuItems.Add(new MenuItem("Cheese Toastie", 14.00m, "Food", 50, "X-Presso"));
            menuItems.Add(new MenuItem("Beef Pie", 14.00m, "Food", 25, "X-Presso"));
            menuItems.Add(new MenuItem("Chicken Pie", 14.00m, "Food", 20, "X-Presso"));
            //drinks
            menuItems.Add(new MenuItem("Cappuccino", 14.00m, "Drinks", 25, "X-Presso"));
            menuItems.Add(new MenuItem("Espresso", 14.00m, "Drinks", 25, "X-Presso"));
            menuItems.Add(new MenuItem("Iced Coffee", 14.00m, "Drinks", 15, "X-Presso"));
            menuItems.Add(new MenuItem("Hot Chocolate", 14.00m, "Drinks", 15, "X-Presso"));
            // desserts
            menuItems.Add(new MenuItem("Chocolate Muffin", 14.00m, "Desserts", 15, "X-Presso"));
            menuItems.Add(new MenuItem("Blueberry Muffin", 14.00m, "Desserts", 15, "X-Presso"));
            menuItems.Add(new MenuItem("Chocolate Brownie", 14.00m, "Desserts", 12, "X-Presso"));
            menuItems.Add(new MenuItem("Vanilla Cupcake", 14.00m, "Desserts", 12, "X-Presso"));
        }

        private void cmbCampuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStore.Items.Clear();
            cmbMenu.Items.Clear();

            lblPrice.Text = "R0.00";

           

            if (cmbCampuses.SelectedIndex == -1)
            {
                return;
            }

            string selectedCampus = cmbCampuses.SelectedItem.ToString();

            foreach (Store store in stores)
            {
                if (store.CampusName == selectedCampus)
                {
                    cmbStore.Items.Add(store.Name);
                }
            }
        }

        private void PopulateMenuItems()
        {

            cmbMenu.Items.Clear();
            lblPrice.Text = "R0.00";


            if (cmbStore.SelectedItem == null)
            {
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                return;
            }

            string selectedStore = cmbStore.SelectedItem.ToString();
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            foreach (MenuItem item in menuItems)
            {
                if (item.StoreName == selectedStore &&
                    item.Category == selectedCategory)
                {
                    cmbMenu.Items.Add(item);
                }
            }
        } 

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            errP_Error.SetError(cmbStore, "");
            errP_Error.SetError(cmbMenu, "");

            PopulateMenuItems();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            errP_Error.SetError(cmbCategory, "");
            errP_Error.SetError(cmbMenu, "");

            PopulateMenuItems();
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenu.SelectedItem == null)
            {
                lblPrice.Text = "R0.00";
                return;
            }

            errP_Error.SetError(cmbMenu, "");

            MenuItem selectedItem = (MenuItem)cmbMenu.SelectedItem;
            lblPrice.Text = selectedItem.Price.ToString("C");
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            errP_Error.Clear();

            bool isValid = true;

            // UNIVERSITY
            if (cmbUniversity.SelectedItem == null)
            {
                errP_Error.SetError(cmbUniversity, "Please select a university");
                isValid = false;
            }

            // CAMPUS
            if (cmbCampuses.SelectedItem == null)
            {
                errP_Error.SetError(cmbCampuses, "Please select a campus");
                isValid = false;
            }

            // STORE
            if (cmbStore.SelectedItem == null)
            {
                errP_Error.SetError(cmbStore, "Please select a store");
                isValid = false;
            }

            // CATEGORY
            if (cmbCategory.SelectedItem == null)
            {
                errP_Error.SetError(cmbCategory, "Please select a category");
                isValid = false;
            }

            // MENU ITEM
            if (cmbMenu.SelectedItem == null)
            {
                errP_Error.SetError(cmbMenu, "Please select a menu item");
                isValid = false;
            }

           
            if (!isValid)
            {
                return;
            }


            MenuItem selectedItem = (MenuItem)cmbMenu.SelectedItem;
            int quantity = (int)nudQuantity.Value;

            //QUANTITY
            if (quantity < 1 || quantity > 20)
            {
                errP_Error.SetError(nudQuantity, "You cannot order less than 1 or more than 20 of the same item");
                isValid = false;
            }

            //STOCK
            if (!selectedItem.isAvailable())
            {
                errP_Error.SetError(cmbMenu, "This item is out of stock");
                isValid = false;
            }

            if (quantity > selectedItem.StockQuantity)
            {
                errP_Error.SetError(nudQuantity, "Only " + selectedItem.StockQuantity + " left in stock");
                isValid = false;
            }

            if (isValid == false)
            {
                return;
            }

            OrderItem newItem = new OrderItem( selectedItem, quantity);

            currentOrder.Add(newItem);


            selectedItem.StockQuantity -= quantity;


            dgvOrderSummary.Rows.Clear();

            foreach (OrderItem item in currentOrder)
            {
                dgvOrderSummary.Rows.Add(item.ItemName, item.Quantity, item.CalculateItemsTotal().ToString("C"));
            }

            cmbMenu.SelectedIndex = -1;
            nudQuantity.Value = 1;
            lblPrice.Text = "R0.00";

           

        }

        public void RefreshOrderSummary()
        {
            errP_Error.Clear();

            
            cmbUniversity.SelectedIndex = -1;
            cmbUniversity.Text = "";

            
            cmbCampuses.SelectedIndex = -1;
            cmbCampuses.Text = "";

            cmbStore.Items.Clear();
            cmbStore.SelectedIndex = -1;
            cmbStore.Text = "";

            
            cmbCategory.SelectedIndex = -1;
            cmbCategory.Text = "";

            cmbMenu.Items.Clear();
            cmbMenu.SelectedIndex = -1;
            cmbMenu.Text = "";

            nudQuantity.Value = 1;
            lblPrice.Text = "R0.00";

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            errP_Error.Clear();

            if (dgvOrderSummary.SelectedRows.Count == 0)
            {
                errP_Error.SetError(
                    dgvOrderSummary,
                    "Please select an item in the Order Summary to remove."
                );

                return;
            }

            int selectedRowIndex = dgvOrderSummary.SelectedRows[0].Index;

            
            OrderItem removedItem = currentOrder[selectedRowIndex];

            
            removedItem.OrderedMenuItem.StockQuantity += removedItem.Quantity;

           
            currentOrder.RemoveAt(selectedRowIndex);

           
            dgvOrderSummary.Rows.Clear();

            foreach (OrderItem item in currentOrder)
            {
                dgvOrderSummary.Rows.Add(
                    item.ItemName,
                    item.Quantity,
                    item.CalculateItemsTotal().ToString("C")
                );
            }

            
            RefreshOrderSummary();

        }

       

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            errP_Error.Clear();


            if (currentOrder.Count == 0)
            {
                MessageBox.Show("Your order is empty. Please add at least one item before placing your order.");
                return;
            }


            if (!rbCollection.Checked && !rbDelivery.Checked)
            {
                errP_Error.SetError(rbCollection, "Please select Collection or Delivery");
                return;
            }

            string orderType = rbCollection.Checked ? "Collection" : "Delivery";
            string deliveryAddress = "";
            if (orderType == "Delivery")
            {
                deliveryAddress = txtDeliveryAddress.Text.Trim();
                if (deliveryAddress == "")
                {
                    errP_Error.SetError(txtDeliveryAddress, "Please enter a delivery address");
                    return;
                }
            }


            decimal orderTotal = 0;
            foreach (OrderItem item in currentOrder)
            {
                orderTotal += item.CalculateItemsTotal();
            }

            
            Order newOrder = new Order(orderType, deliveryAddress);
            newOrder.OrderTotal = orderTotal;



            SaveOrderToFile(newOrder);

            string itemsList = "";

            foreach (OrderItem item in currentOrder)
            {
                itemsList += "- " + item.ItemName + " x" + item.Quantity + "\n";
            }

            string confirmationMessage = "Your order has been successfully placed!\n\n" +
                "Order Number: " + newOrder.OrderNumberDisplay + "\n" +
                "Date: " + newOrder.DateCreated.ToString("dd MMM yyyy, HH:mm") + "\n" +
                "Items Ordered:\n" + itemsList +
                "Order Type: " + newOrder.OrderType + "\n";

            if (newOrder.OrderType == "Delivery")
            {
                confirmationMessage += "Delivery Address: " + newOrder.DeliveryAddress + "\n";
            }

            confirmationMessage += "Total: " + newOrder.OrderTotal.ToString("C");

            MessageBox.Show(confirmationMessage, "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvOrderSummary.Rows.Clear();
            currentOrder.Clear();

           

            RefreshOrderSummary();
            
            rbCollection.Checked = false;
            rbDelivery.Checked = false;
            txtDeliveryAddress.Clear(); ;

        }

        private void SaveOrderToFile(Order order)
        {
            List<string> lines = new List<string>();

            lines.Add("Order Number: " + order.OrderNumberDisplay);
            lines.Add("Date: " + order.DateCreated.ToString("dd MMM yyyy, HH:mm"));
            lines.Add("Items Ordered:");

            foreach (OrderItem item in currentOrder)
            {
                lines.Add(" - " + item.ItemName + " x" + item.Quantity + " = " + item.CalculateItemsTotal().ToString("C"));
            }

            lines.Add("Order Type: " + order.OrderType);

            if (order.OrderType == "Delivery")
            {
                lines.Add("Delivery Address: " + order.DeliveryAddress);
            }

            lines.Add("Total: " + order.OrderTotal.ToString("C"));
            lines.Add("------------------------------");

            File.AppendAllLines("orders.txt", lines);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                 "Confirm Exit",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
