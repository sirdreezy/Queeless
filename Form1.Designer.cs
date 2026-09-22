namespace Queeless
{
    partial class frmQueueLessOrderingSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueueLessOrderingSystem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.grpOrderType = new System.Windows.Forms.GroupBox();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbCollection = new System.Windows.Forms.RadioButton();
            this.lblOrderTypeHeading = new System.Windows.Forms.Label();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.picOrderSummary = new System.Windows.Forms.PictureBox();
            this.dgvOrderSummary = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.grpPriceDisplay = new System.Windows.Forms.GroupBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceHeading = new System.Windows.Forms.Label();
            this.grpItemSelection = new System.Windows.Forms.GroupBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picCategory = new System.Windows.Forms.PictureBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpLocationSelection = new System.Windows.Forms.GroupBox();
            this.picStore = new System.Windows.Forms.PictureBox();
            this.picCampus = new System.Windows.Forms.PictureBox();
            this.picUniversity = new System.Windows.Forms.PictureBox();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.lblStore = new System.Windows.Forms.Label();
            this.cmbCampuses = new System.Windows.Forms.ComboBox();
            this.lblCampusHeading = new System.Windows.Forms.Label();
            this.cmbUniversity = new System.Windows.Forms.ComboBox();
            this.lblUniverisityHeading = new System.Windows.Forms.Label();
            this.grpSlogan = new System.Windows.Forms.GroupBox();
            this.lblSlo = new System.Windows.Forms.Label();
            this.lblPlaceYourOrder = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnTrackOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPlaceOrderTab = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.errP_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpOrderType.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrderSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).BeginInit();
            this.grpPriceDisplay.SuspendLayout();
            this.grpItemSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpLocationSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCampus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUniversity)).BeginInit();
            this.grpSlogan.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Navy;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(769, 798);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 44);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Green;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(229, 798);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(534, 44);
            this.btnPlaceOrder.TabIndex = 16;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // grpOrderType
            // 
            this.grpOrderType.Controls.Add(this.txtDeliveryAddress);
            this.grpOrderType.Controls.Add(this.lblDeliveryAddress);
            this.grpOrderType.Controls.Add(this.rbDelivery);
            this.grpOrderType.Controls.Add(this.rbCollection);
            this.grpOrderType.Controls.Add(this.lblOrderTypeHeading);
            this.grpOrderType.Location = new System.Drawing.Point(234, 629);
            this.grpOrderType.Name = "grpOrderType";
            this.grpOrderType.Size = new System.Drawing.Size(642, 134);
            this.grpOrderType.TabIndex = 15;
            this.grpOrderType.TabStop = false;
            this.grpOrderType.Text = "Order Type";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(347, 49);
            this.txtDeliveryAddress.Multiline = true;
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(241, 48);
            this.txtDeliveryAddress.TabIndex = 6;
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.Location = new System.Drawing.Point(342, 21);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(166, 25);
            this.lblDeliveryAddress.TabIndex = 5;
            this.lblDeliveryAddress.Text = "Delivery Address :";
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(12, 85);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(78, 20);
            this.rbDelivery.TabIndex = 4;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            // 
            // rbCollection
            // 
            this.rbCollection.AutoSize = true;
            this.rbCollection.Location = new System.Drawing.Point(12, 58);
            this.rbCollection.Name = "rbCollection";
            this.rbCollection.Size = new System.Drawing.Size(87, 20);
            this.rbCollection.TabIndex = 3;
            this.rbCollection.TabStop = true;
            this.rbCollection.Text = "Collection";
            this.rbCollection.UseVisualStyleBackColor = true;
            // 
            // lblOrderTypeHeading
            // 
            this.lblOrderTypeHeading.AutoSize = true;
            this.lblOrderTypeHeading.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTypeHeading.Location = new System.Drawing.Point(6, 21);
            this.lblOrderTypeHeading.Name = "lblOrderTypeHeading";
            this.lblOrderTypeHeading.Size = new System.Drawing.Size(107, 25);
            this.lblOrderTypeHeading.TabIndex = 2;
            this.lblOrderTypeHeading.Text = "Order Type";
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.Controls.Add(this.picOrderSummary);
            this.grpOrderSummary.Controls.Add(this.dgvOrderSummary);
            this.grpOrderSummary.Controls.Add(this.btnRemove);
            this.grpOrderSummary.Controls.Add(this.lblOrderSummary);
            this.grpOrderSummary.Location = new System.Drawing.Point(235, 428);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(641, 195);
            this.grpOrderSummary.TabIndex = 14;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = " Order Summary";
            // 
            // picOrderSummary
            // 
            this.picOrderSummary.Image = ((System.Drawing.Image)(resources.GetObject("picOrderSummary.Image")));
            this.picOrderSummary.Location = new System.Drawing.Point(12, 30);
            this.picOrderSummary.Name = "picOrderSummary";
            this.picOrderSummary.Size = new System.Drawing.Size(33, 31);
            this.picOrderSummary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrderSummary.TabIndex = 8;
            this.picOrderSummary.TabStop = false;
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.AllowUserToAddRows = false;
            this.dgvOrderSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderSummary.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvOrderSummary.EnableHeadersVisualStyles = false;
            this.dgvOrderSummary.GridColor = System.Drawing.Color.Green;
            this.dgvOrderSummary.Location = new System.Drawing.Point(11, 64);
            this.dgvOrderSummary.MultiSelect = false;
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.RowHeadersWidth = 51;
            this.dgvOrderSummary.RowTemplate.Height = 24;
            this.dgvOrderSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderSummary.Size = new System.Drawing.Size(603, 123);
            this.dgvOrderSummary.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Navy;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(446, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 34);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.ForeColor = System.Drawing.Color.Green;
            this.lblOrderSummary.Location = new System.Drawing.Point(51, 30);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(184, 31);
            this.lblOrderSummary.TabIndex = 1;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // grpPriceDisplay
            // 
            this.grpPriceDisplay.BackColor = System.Drawing.Color.Honeydew;
            this.grpPriceDisplay.Controls.Add(this.btnAddToOrder);
            this.grpPriceDisplay.Controls.Add(this.lblPrice);
            this.grpPriceDisplay.Controls.Add(this.lblPriceHeading);
            this.grpPriceDisplay.Location = new System.Drawing.Point(235, 335);
            this.grpPriceDisplay.Name = "grpPriceDisplay";
            this.grpPriceDisplay.Size = new System.Drawing.Size(641, 77);
            this.grpPriceDisplay.TabIndex = 13;
            this.grpPriceDisplay.TabStop = false;
            this.grpPriceDisplay.Text = "Price Display";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.Green;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Location = new System.Drawing.Point(405, 24);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(179, 34);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(110, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "R0.00";
            // 
            // lblPriceHeading
            // 
            this.lblPriceHeading.AutoSize = true;
            this.lblPriceHeading.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceHeading.Location = new System.Drawing.Point(6, 21);
            this.lblPriceHeading.Name = "lblPriceHeading";
            this.lblPriceHeading.Size = new System.Drawing.Size(98, 25);
            this.lblPriceHeading.TabIndex = 1;
            this.lblPriceHeading.Text = "Item Price";
            // 
            // grpItemSelection
            // 
            this.grpItemSelection.Controls.Add(this.picMenu);
            this.grpItemSelection.Controls.Add(this.picCategory);
            this.grpItemSelection.Controls.Add(this.nudQuantity);
            this.grpItemSelection.Controls.Add(this.cmbMenu);
            this.grpItemSelection.Controls.Add(this.cmbCategory);
            this.grpItemSelection.Controls.Add(this.lblQuantity);
            this.grpItemSelection.Controls.Add(this.lblMenuItem);
            this.grpItemSelection.Controls.Add(this.lblCategory);
            this.grpItemSelection.Location = new System.Drawing.Point(235, 219);
            this.grpItemSelection.Name = "grpItemSelection";
            this.grpItemSelection.Size = new System.Drawing.Size(641, 110);
            this.grpItemSelection.TabIndex = 12;
            this.grpItemSelection.TabStop = false;
            this.grpItemSelection.Text = "Item Selection";
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(223, 37);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(33, 31);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 9;
            this.picMenu.TabStop = false;
            // 
            // picCategory
            // 
            this.picCategory.Image = ((System.Drawing.Image)(resources.GetObject("picCategory.Image")));
            this.picCategory.Location = new System.Drawing.Point(12, 34);
            this.picCategory.Name = "picCategory";
            this.picCategory.Size = new System.Drawing.Size(33, 31);
            this.picCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCategory.TabIndex = 8;
            this.picCategory.TabStop = false;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(464, 73);
            this.nudQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 31);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbMenu
            // 
            this.cmbMenu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(234, 74);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(172, 33);
            this.cmbMenu.TabIndex = 6;
            this.cmbMenu.SelectedIndexChanged += new System.EventHandler(this.cmbMenu_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "Desserts",
            "Drinks"});
            this.cmbCategory.Location = new System.Drawing.Point(20, 74);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 33);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(471, 34);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(87, 25);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItem.Location = new System.Drawing.Point(262, 40);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(105, 25);
            this.lblMenuItem.TabIndex = 2;
            this.lblMenuItem.Text = "Menu Item\r\n";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(45, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 25);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // grpLocationSelection
            // 
            this.grpLocationSelection.Controls.Add(this.picStore);
            this.grpLocationSelection.Controls.Add(this.picCampus);
            this.grpLocationSelection.Controls.Add(this.picUniversity);
            this.grpLocationSelection.Controls.Add(this.cmbStore);
            this.grpLocationSelection.Controls.Add(this.lblStore);
            this.grpLocationSelection.Controls.Add(this.cmbCampuses);
            this.grpLocationSelection.Controls.Add(this.lblCampusHeading);
            this.grpLocationSelection.Controls.Add(this.cmbUniversity);
            this.grpLocationSelection.Controls.Add(this.lblUniverisityHeading);
            this.grpLocationSelection.Location = new System.Drawing.Point(234, 95);
            this.grpLocationSelection.Name = "grpLocationSelection";
            this.grpLocationSelection.Size = new System.Drawing.Size(642, 118);
            this.grpLocationSelection.TabIndex = 11;
            this.grpLocationSelection.TabStop = false;
            this.grpLocationSelection.Text = "Location Selection";
            // 
            // picStore
            // 
            this.picStore.Image = ((System.Drawing.Image)(resources.GetObject("picStore.Image")));
            this.picStore.Location = new System.Drawing.Point(432, 38);
            this.picStore.Name = "picStore";
            this.picStore.Size = new System.Drawing.Size(33, 31);
            this.picStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStore.TabIndex = 8;
            this.picStore.TabStop = false;
            // 
            // picCampus
            // 
            this.picCampus.Image = ((System.Drawing.Image)(resources.GetObject("picCampus.Image")));
            this.picCampus.Location = new System.Drawing.Point(214, 38);
            this.picCampus.Name = "picCampus";
            this.picCampus.Size = new System.Drawing.Size(33, 31);
            this.picCampus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCampus.TabIndex = 7;
            this.picCampus.TabStop = false;
            // 
            // picUniversity
            // 
            this.picUniversity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUniversity.BackgroundImage")));
            this.picUniversity.Image = ((System.Drawing.Image)(resources.GetObject("picUniversity.Image")));
            this.picUniversity.Location = new System.Drawing.Point(12, 38);
            this.picUniversity.Name = "picUniversity";
            this.picUniversity.Size = new System.Drawing.Size(33, 35);
            this.picUniversity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUniversity.TabIndex = 6;
            this.picUniversity.TabStop = false;
            // 
            // cmbStore
            // 
            this.cmbStore.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(432, 79);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(153, 33);
            this.cmbStore.TabIndex = 5;
            this.cmbStore.SelectedIndexChanged += new System.EventHandler(this.cmbStore_SelectedIndexChanged);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.Location = new System.Drawing.Point(472, 38);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(57, 25);
            this.lblStore.TabIndex = 4;
            this.lblStore.Text = "Store";
            // 
            // cmbCampuses
            // 
            this.cmbCampuses.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampuses.FormattingEnabled = true;
            this.cmbCampuses.Items.AddRange(new object[] {
            "APK",
            "APB",
            "DFC",
            "Soweto"});
            this.cmbCampuses.Location = new System.Drawing.Point(235, 79);
            this.cmbCampuses.Name = "cmbCampuses";
            this.cmbCampuses.Size = new System.Drawing.Size(151, 33);
            this.cmbCampuses.TabIndex = 3;
            this.cmbCampuses.SelectedIndexChanged += new System.EventHandler(this.cmbCampuses_SelectedIndexChanged);
            // 
            // lblCampusHeading
            // 
            this.lblCampusHeading.AutoSize = true;
            this.lblCampusHeading.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampusHeading.Location = new System.Drawing.Point(246, 38);
            this.lblCampusHeading.Name = "lblCampusHeading";
            this.lblCampusHeading.Size = new System.Drawing.Size(79, 25);
            this.lblCampusHeading.TabIndex = 2;
            this.lblCampusHeading.Text = "Campus\r\n";
            // 
            // cmbUniversity
            // 
            this.cmbUniversity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUniversity.FormattingEnabled = true;
            this.cmbUniversity.Items.AddRange(new object[] {
            "University of Johannesburg"});
            this.cmbUniversity.Location = new System.Drawing.Point(22, 79);
            this.cmbUniversity.Name = "cmbUniversity";
            this.cmbUniversity.Size = new System.Drawing.Size(157, 33);
            this.cmbUniversity.TabIndex = 1;
            // 
            // lblUniverisityHeading
            // 
            this.lblUniverisityHeading.AutoSize = true;
            this.lblUniverisityHeading.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniverisityHeading.Location = new System.Drawing.Point(46, 38);
            this.lblUniverisityHeading.Name = "lblUniverisityHeading";
            this.lblUniverisityHeading.Size = new System.Drawing.Size(98, 25);
            this.lblUniverisityHeading.TabIndex = 0;
            this.lblUniverisityHeading.Text = "University";
            // 
            // grpSlogan
            // 
            this.grpSlogan.Controls.Add(this.lblSlo);
            this.grpSlogan.Controls.Add(this.lblPlaceYourOrder);
            this.grpSlogan.Location = new System.Drawing.Point(233, 12);
            this.grpSlogan.Name = "grpSlogan";
            this.grpSlogan.Size = new System.Drawing.Size(643, 77);
            this.grpSlogan.TabIndex = 10;
            this.grpSlogan.TabStop = false;
            this.grpSlogan.Text = "Slogan";
            // 
            // lblSlo
            // 
            this.lblSlo.AutoSize = true;
            this.lblSlo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlo.Location = new System.Drawing.Point(18, 50);
            this.lblSlo.Name = "lblSlo";
            this.lblSlo.Size = new System.Drawing.Size(240, 23);
            this.lblSlo.TabIndex = 1;
            this.lblSlo.Text = "SKIP THE LINE .NOT THE MEAL\r\n";
            // 
            // lblPlaceYourOrder
            // 
            this.lblPlaceYourOrder.AutoSize = true;
            this.lblPlaceYourOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceYourOrder.ForeColor = System.Drawing.Color.Green;
            this.lblPlaceYourOrder.Location = new System.Drawing.Point(15, 19);
            this.lblPlaceYourOrder.Name = "lblPlaceYourOrder";
            this.lblPlaceYourOrder.Size = new System.Drawing.Size(233, 31);
            this.lblPlaceYourOrder.TabIndex = 0;
            this.lblPlaceYourOrder.Text = "PLACE YOUR ORDER";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlSidebar.Controls.Add(this.btnTrackOrders);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnLogOut);
            this.pnlSidebar.Controls.Add(this.btnProfile);
            this.pnlSidebar.Controls.Add(this.btnPlaceOrderTab);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(204, 889);
            this.pnlSidebar.TabIndex = 9;
            // 
            // btnTrackOrders
            // 
            this.btnTrackOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnTrackOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackOrders.ForeColor = System.Drawing.Color.Green;
            this.btnTrackOrders.Location = new System.Drawing.Point(25, 492);
            this.btnTrackOrders.Name = "btnTrackOrders";
            this.btnTrackOrders.Size = new System.Drawing.Size(126, 75);
            this.btnTrackOrders.TabIndex = 5;
            this.btnTrackOrders.Text = "Track Order";
            this.btnTrackOrders.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblSlogan);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 238);
            this.panel1.TabIndex = 4;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(11, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(179, 188);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(30, 203);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(120, 20);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "Order.Track.Enjoy";
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Green;
            this.btnLogOut.Location = new System.Drawing.Point(25, 687);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(126, 56);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Green;
            this.btnProfile.Location = new System.Drawing.Point(25, 602);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(126, 41);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrderTab
            // 
            this.btnPlaceOrderTab.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaceOrderTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrderTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrderTab.ForeColor = System.Drawing.Color.Green;
            this.btnPlaceOrderTab.Location = new System.Drawing.Point(25, 371);
            this.btnPlaceOrderTab.Name = "btnPlaceOrderTab";
            this.btnPlaceOrderTab.Size = new System.Drawing.Size(126, 73);
            this.btnPlaceOrderTab.TabIndex = 1;
            this.btnPlaceOrderTab.Text = " Place Order";
            this.btnPlaceOrderTab.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Green;
            this.btnHome.Location = new System.Drawing.Point(25, 282);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 51);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // errP_Error
            // 
            this.errP_Error.ContainerControl = this;
            // 
            // frmQueueLessOrderingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 889);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpOrderType);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.grpPriceDisplay);
            this.Controls.Add(this.grpItemSelection);
            this.Controls.Add(this.grpLocationSelection);
            this.Controls.Add(this.grpSlogan);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmQueueLessOrderingSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " QueueLess Ordering ";
            this.Load += new System.EventHandler(this.frmQueueLessOrderingSystem_Load);
            this.grpOrderType.ResumeLayout(false);
            this.grpOrderType.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrderSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).EndInit();
            this.grpPriceDisplay.ResumeLayout(false);
            this.grpPriceDisplay.PerformLayout();
            this.grpItemSelection.ResumeLayout(false);
            this.grpItemSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpLocationSelection.ResumeLayout(false);
            this.grpLocationSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCampus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUniversity)).EndInit();
            this.grpSlogan.ResumeLayout(false);
            this.grpSlogan.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP_Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox grpOrderType;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbCollection;
        private System.Windows.Forms.Label lblOrderTypeHeading;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.DataGridView dgvOrderSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.GroupBox grpPriceDisplay;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceHeading;
        private System.Windows.Forms.GroupBox grpItemSelection;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grpLocationSelection;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.ComboBox cmbCampuses;
        private System.Windows.Forms.Label lblCampusHeading;
        private System.Windows.Forms.ComboBox cmbUniversity;
        private System.Windows.Forms.Label lblUniverisityHeading;
        private System.Windows.Forms.GroupBox grpSlogan;
        private System.Windows.Forms.Label lblSlo;
        private System.Windows.Forms.Label lblPlaceYourOrder;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnTrackOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnPlaceOrderTab;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ErrorProvider errP_Error;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picCategory;
        private System.Windows.Forms.PictureBox picStore;
        private System.Windows.Forms.PictureBox picCampus;
        private System.Windows.Forms.PictureBox picUniversity;
        private System.Windows.Forms.PictureBox picOrderSummary;
        private System.Windows.Forms.PictureBox picMenu;
    }
}

