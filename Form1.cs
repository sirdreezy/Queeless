using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Queeless
{
    public partial class FrmHome : Form
    public partial class frmLoginPage : Form
    {
        public FrmHome()
        private LoginPage user;
        private bool showingRegister = false;
        private int slideSpeed = 20;

        public frmLoginPage()
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
            pnlRegister.Parent = pnlMain;
            pnlRegister.Location = new Point(1020, 50);
            pnlRegister.BringToFront();
            pnlForgotPassword.Visible = false;
        }

        
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            showingRegister = true;
            slideTimer.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showingRegister = false;
            slideTimer.Start();
        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (showingRegister)
            {
                pnlLogin.Left -=slideSpeed;
                pnlRegister.Left -= slideSpeed;

                if (pnlLogin.Left<=20)
                {
                    pnlLogin.Left = 20;
                    pnlRegister.Left = 520;
                    slideTimer.Stop();
                }
               
            }
            else
            {
                pnlLogin.Left += slideSpeed;
                pnlRegister.Left += slideSpeed;

                if (pnlLogin.Left>=520)
                {
                    pnlLogin.Left = 520;
                    pnlRegister.Left = 1020;
                    slideTimer.Stop();
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            lblEmailError.Text = "";
            lblPasswordError.Text = "";

            if (!File.Exists("users.txt"))
            {
                lblEmailError.Text = "No accounts have been created yet.";
                return;
            }

            bool loginSuccessful = false;

            string[] users = File.ReadAllLines("users.txt");

            foreach (string user in users)
            {
                string[] details = user.Split('|');

                if (details[0] == email && details[1] == password)
                {
                    loginSuccessful = true;
                    break;
                }
                this.Hide();

                // Opens your Home form (Form1)
               
            }

            if (!loginSuccessful)
            {
                lblPasswordError.Text = "Email or password is incorrect.";
                return;
            }

            lblPasswordError.Text = "Login successful!";
        
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            LoginPage user = new LoginPage("", txtEmail.Text.Trim(), "", txtPassword.Text);
            lblEmailError.Text = "";
            lblPasswordError.Text = "";

            if (!user.IsValidLecturerEmail())
            {
                lblEmailError.Text = "Please use a valid lecturer email.";
                return;
            }

            if (!File.Exists("users.txt"))
            {
                lblEmailError.Text = "No accounts have been created yet.";
                return;
            }

            bool loginSuccessful = false;

            string[] users = File.ReadAllLines("users.txt");

            foreach (string account in users)
            {
                string[] details = account.Split('|');

                if (details[0] == txtEmail.Text && details[1] == txtPassword.Text)
                {
                    loginSuccessful = true;
                    break;
                }
            }

            if (!loginSuccessful)
            {
                lblPasswordError.Text = "Email or password is incorrect.";
                return;
            }


            MessageBox.Show( "Lecturer login successful!");
        
    }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            LoginPage user = new LoginPage(txtFullName.Text.Trim(), txtRegisterEmail.Text.Trim(), txtPhoneNumber.Text.Trim(), txtRegisterPassword.Text);
            if (!user.IsValidName())
            {
                lblFirstNameError.Text = "Please enter your name.";
                return;
            }

            if (!user.IsValidPhoneNumber())
            {
                lblPhoneNumberError.Text = "Phone number must be 10 digits.";
                return;
            }

            if (!user.IsValidStudentEmail() && !user.IsValidLecturerEmail())
            {
                lblRegisterEmailError.Text = "Please use a valid student or lecturer email.";
                return;
            }

            if (!user.IsValidPassword())
            {
                lblRegisterPasswordError.Text = "Password must be 13 characters, contain a number and a special character.";
                return;
            }
            File.AppendAllText("users.txt", user.GetEmail() + "|" + user.GetPassword() + Environment.NewLine);


            lblRegisterPasswordError.Text = "Account created successfully!";
        }

        private void lblAlreadyHaveAnAccount_Click(object sender, EventArgs e)
        {
            showingRegister = false;
            slideTimer.Start();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            
            pnlRegister.Visible = false;
     
            pnlForgotPassword.Visible = true;
            
            pnlForgotPassword.BringToFront();
        }

        private void lblBacktoLogin_Click(object sender, EventArgs e)
        {
            pnlForgotPassword.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = txtForgotEmail.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            
            if (string.IsNullOrWhiteSpace(email))
            {
                lblForgotPasswordError.Text = "Please enter your email.";
                return;
            }

            
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                lblForgotPasswordError.Text = "Please enter a new password.";
                return;
            }

           
            if (newPassword != confirmPassword)
            {
                lblForgotPasswordError.Text = "Passwords do not match.";
                return;
            }

           
            LoginPage user = new LoginPage("", email, "", newPassword);

            if (!user.IsValidPassword())
            {
                lblForgotPasswordError.Text =
                    "Password must be 13 characters, contain a number and a special character.";
                return;
            }

            
            if (!File.Exists("users.txt"))
            {
                lblForgotPasswordError.Text = "No accounts found.";
                return;
            }

            string[] users = File.ReadAllLines("users.txt");

            bool found = false;

            for (int i = 0; i < users.Length; i++)
            {
                string[] details = users[i].Split('|');

                if (details.Length >= 2 &&
                    details[0].Trim().Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    // Update password
                    users[i] = details[0] + "|" + newPassword;

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                lblForgotPasswordError.Text =
                    "No account was found with that email.";
                return;
            }

            // Save the updated information
            File.WriteAllLines("users.txt", users);

            lblForgotPasswordError.Text =
                "Password reset successfully!";

            // Clear fields
            txtForgotEmail.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
        }
    }
    
}
