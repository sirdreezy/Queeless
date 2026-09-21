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
    public partial class frmLoginPage : Form
    {
        private LoginPage user;
        private bool showingRegister = false;
        private int slideSpeed = 20;

        public frmLoginPage()
        {
            
            InitializeComponent();
            pnlRegister.Parent = pnlMain;
            pnlRegister.Location = new Point(1020, 50);
            pnlRegister.BringToFront();
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

            if (!user.IsValidStudentEmail())
            {
                lblRegisterEmailError.Text = "Please use a valid student email.";
                return;
            }
            else if (!user.IsValidLecturerEmail())
            {
                lblRegisterEmailError.Text = "Please use a valid lecturer email.";
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
    }
    
}
