using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queeless
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        
        private void pictureBoxBurger_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBoxBurger.Width, pictureBoxBurger.Height);
            pictureBoxBurger.Region = new Region(path);
        }
        private void SelectDeliverToRoom() 
        {
            pnlDeliver.BackColor = Color.FromArgb(20, 50, 40);
            pnlPreOrder.BackColor = Color.FromArgb(30, 35, 45);

        }
        private void SelectPreOrder() 
        {
            pnlPreOrder.BackColor = Color.FromArgb(20, 50, 40);
            pnlDeliver.BackColor = Color.FromArgb(30, 35, 45);
        }
        private void lblDeliverToRoom_Click(object sender, EventArgs e)
        {
            SelectDeliverToRoom();
        }

        private void lblPreOrderAndCollect_Click(object sender, EventArgs e)
        {
            SelectPreOrder();
        }
    }
}
