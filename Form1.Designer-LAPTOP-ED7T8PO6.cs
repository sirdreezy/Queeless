namespace Queeless
{
    partial class frmLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginPage));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblRegisterEmailError = new System.Windows.Forms.Label();
            this.lblPhoneNumberError = new System.Windows.Forms.Label();
            this.lblRegisterPasswordError = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAlreadyHaveAnAccount = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblJoin = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnLectureLogin = new System.Windows.Forms.Button();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLoginSub = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblRewards = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.lblEasyBooking = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.pnlLogin);
            this.pnlMain.Controls.Add(this.pnlBrand);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1182, 653);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.pnlRegister);
            this.pnlLogin.Controls.Add(this.lblPasswordError);
            this.pnlLogin.Controls.Add(this.lblEmailError);
            this.pnlLogin.Controls.Add(this.lblBack);
            this.pnlLogin.Controls.Add(this.lblSignUp);
            this.pnlLogin.Controls.Add(this.lblNoAccount);
            this.pnlLogin.Controls.Add(this.btnLectureLogin);
            this.pnlLogin.Controls.Add(this.btnStudentLogin);
            this.pnlLogin.Controls.Add(this.lblForgotPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtEmail);
            this.pnlLogin.Controls.Add(this.lblLoginSub);
            this.pnlLogin.Controls.Add(this.lblWelcome);
            this.pnlLogin.Location = new System.Drawing.Point(520, 50);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(500, 550);
            this.pnlLogin.TabIndex = 1;
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.White;
            this.pnlRegister.Controls.Add(this.lblFirstNameError);
            this.pnlRegister.Controls.Add(this.lblRegisterEmailError);
            this.pnlRegister.Controls.Add(this.lblPhoneNumberError);
            this.pnlRegister.Controls.Add(this.lblRegisterPasswordError);
            this.pnlRegister.Controls.Add(this.lblLogin);
            this.pnlRegister.Controls.Add(this.lblAlreadyHaveAnAccount);
            this.pnlRegister.Controls.Add(this.btnSignup);
            this.pnlRegister.Controls.Add(this.btnBack);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(this.txtPhoneNumber);
            this.pnlRegister.Controls.Add(this.txtRegisterEmail);
            this.pnlRegister.Controls.Add(this.lblCreateAccount);
            this.pnlRegister.Controls.Add(this.lblJoin);
            this.pnlRegister.Controls.Add(this.txtFullName);
            this.pnlRegister.Location = new System.Drawing.Point(1020, 50);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(500, 550);
            this.pnlRegister.TabIndex = 9;
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.AutoSize = true;
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(69, 190);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(0, 16);
            this.lblFirstNameError.TabIndex = 2;
            // 
            // lblRegisterEmailError
            // 
            this.lblRegisterEmailError.AutoSize = true;
            this.lblRegisterEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblRegisterEmailError.Location = new System.Drawing.Point(69, 256);
            this.lblRegisterEmailError.Name = "lblRegisterEmailError";
            this.lblRegisterEmailError.Size = new System.Drawing.Size(0, 16);
            this.lblRegisterEmailError.TabIndex = 3;
            // 
            // lblPhoneNumberError
            // 
            this.lblPhoneNumberError.AutoSize = true;
            this.lblPhoneNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberError.Location = new System.Drawing.Point(69, 321);
            this.lblPhoneNumberError.Name = "lblPhoneNumberError";
            this.lblPhoneNumberError.Size = new System.Drawing.Size(0, 16);
            this.lblPhoneNumberError.TabIndex = 4;
            // 
            // lblRegisterPasswordError
            // 
            this.lblRegisterPasswordError.AutoSize = true;
            this.lblRegisterPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblRegisterPasswordError.Location = new System.Drawing.Point(69, 398);
            this.lblRegisterPasswordError.Name = "lblRegisterPasswordError";
            this.lblRegisterPasswordError.Size = new System.Drawing.Size(0, 16);
            this.lblRegisterPasswordError.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(164, 516);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 16);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Login";
            // 
            // lblAlreadyHaveAnAccount
            // 
            this.lblAlreadyHaveAnAccount.AutoSize = true;
            this.lblAlreadyHaveAnAccount.Location = new System.Drawing.Point(117, 485);
            this.lblAlreadyHaveAnAccount.Name = "lblAlreadyHaveAnAccount";
            this.lblAlreadyHaveAnAccount.Size = new System.Drawing.Size(162, 16);
            this.lblAlreadyHaveAnAccount.TabIndex = 14;
            this.lblAlreadyHaveAnAccount.Text = "Already have an account?";
            this.lblAlreadyHaveAnAccount.Click += new System.EventHandler(this.lblAlreadyHaveAnAccount_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(61, 429);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(271, 43);
            this.btnSignup.TabIndex = 13;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(61, 373);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(338, 22);
            this.txtRegisterPassword.TabIndex = 10;
            this.txtRegisterPassword.Text = "Password";
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(61, 295);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(338, 22);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.Text = "Phone Number";
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Location = new System.Drawing.Point(61, 231);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(338, 22);
            this.txtRegisterEmail.TabIndex = 12;
            this.txtRegisterEmail.Text = "Email";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCreateAccount.Location = new System.Drawing.Point(74, 43);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(334, 59);
            this.lblCreateAccount.TabIndex = 0;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJoin
            // 
            this.lblJoin.AutoSize = true;
            this.lblJoin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblJoin.Location = new System.Drawing.Point(79, 114);
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.Size = new System.Drawing.Size(360, 28);
            this.lblJoin.TabIndex = 1;
            this.lblJoin.Text = "Join Queueless and enjoy fast orders";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(61, 165);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(338, 22);
            this.txtFullName.TabIndex = 9;
            this.txtFullName.Text = "Full Name";
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(59, 249);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordError.TabIndex = 11;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(56, 184);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 16);
            this.lblEmailError.TabIndex = 10;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBack.Location = new System.Drawing.Point(315, 31);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(135, 59);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "Back!";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(158)))), ((int)(((byte)(36)))));
            this.lblSignUp.Location = new System.Drawing.Point(234, 503);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(52, 16);
            this.lblSignUp.TabIndex = 8;
            this.lblSignUp.Text = "Sign up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Location = new System.Drawing.Point(196, 473);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(146, 16);
            this.lblNoAccount.TabIndex = 7;
            this.lblNoAccount.Text = "Don\'t have an account?";
            // 
            // btnLectureLogin
            // 
            this.btnLectureLogin.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnLectureLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectureLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectureLogin.Location = new System.Drawing.Point(70, 405);
            this.btnLectureLogin.Name = "btnLectureLogin";
            this.btnLectureLogin.Size = new System.Drawing.Size(400, 50);
            this.btnLectureLogin.TabIndex = 6;
            this.btnLectureLogin.Text = "Lecturer Login";
            this.btnLectureLogin.UseVisualStyleBackColor = true;
            this.btnLectureLogin.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(158)))), ((int)(((byte)(36)))));
            this.btnStudentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.Location = new System.Drawing.Point(70, 316);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(400, 50);
            this.btnStudentLogin.TabIndex = 5;
            this.btnStudentLogin.Text = "Student Login";
            this.btnStudentLogin.UseVisualStyleBackColor = false;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(158)))), ((int)(((byte)(36)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(205, 279);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(116, 16);
            this.lblForgotPassword.TabIndex = 4;
            this.lblForgotPassword.Text = "Forgot Password?";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // lblLoginSub
            // 
            this.lblLoginSub.AutoSize = true;
            this.lblLoginSub.Location = new System.Drawing.Point(152, 111);
            this.lblLoginSub.Name = "lblLoginSub";
            this.lblLoginSub.Size = new System.Drawing.Size(200, 16);
            this.lblLoginSub.TabIndex = 1;
            this.lblLoginSub.Text = "Login to continue to your account";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.lblWelcome.Location = new System.Drawing.Point(91, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(223, 59);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBrand
            // 
            this.pnlBrand.Controls.Add(this.lblRewards);
            this.pnlBrand.Controls.Add(this.lblWaiting);
            this.pnlBrand.Controls.Add(this.lblEasyBooking);
            this.pnlBrand.Controls.Add(this.lblSlogan);
            this.pnlBrand.Controls.Add(this.picLogo);
            this.pnlBrand.Location = new System.Drawing.Point(3, 3);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(500, 650);
            this.pnlBrand.TabIndex = 0;
            // 
            // lblRewards
            // 
            this.lblRewards.AutoSize = true;
            this.lblRewards.Location = new System.Drawing.Point(254, 423);
            this.lblRewards.Name = "lblRewards";
            this.lblRewards.Size = new System.Drawing.Size(246, 32);
            this.lblRewards.TabIndex = 4;
            this.lblRewards.Text = "Rewards and Offers\r\nEarn Points and Enjoy exclusive promos";
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Location = new System.Drawing.Point(251, 355);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(249, 32);
            this.lblWaiting.TabIndex = 3;
            this.lblWaiting.Text = "No more waiting in long queues\r\nReal-time updates and smart queue man";
            // 
            // lblEasyBooking
            // 
            this.lblEasyBooking.AutoSize = true;
            this.lblEasyBooking.Location = new System.Drawing.Point(251, 295);
            this.lblEasyBooking.Name = "lblEasyBooking";
            this.lblEasyBooking.Size = new System.Drawing.Size(181, 32);
            this.lblEasyBooking.TabIndex = 2;
            this.lblEasyBooking.Text = "Easy Bookings\r\nOrder food in just a few clicks.";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSlogan.Location = new System.Drawing.Point(79, 181);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(309, 76);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "Book.Relax.We\'ll take \r\n   care of the rest.";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Queeless.Properties.Resources.Navy_and_Green_Queueless_Wordmark;
            this.picLogo.Location = new System.Drawing.Point(43, 67);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(400, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 10;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUEUELESS";
            this.pnlMain.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblRewards;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Label lblEasyBooking;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLoginSub;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLectureLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblJoin;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblAlreadyHaveAnAccount;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblPhoneNumberError;
        private System.Windows.Forms.Label lblRegisterEmailError;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblRegisterPasswordError;
    }
}

