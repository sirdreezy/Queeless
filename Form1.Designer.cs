namespace Queeless
{
    partial class frmLoginPage
    partial class FrmHome
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
            this.pnlForgotPassword = new System.Windows.Forms.Panel();
            this.lblForgot = new System.Windows.Forms.Label();
            this.lblPasswordUpdate = new System.Windows.Forms.Label();
            this.txtForgotEmail = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblBacktoLogin = new System.Windows.Forms.Label();
            this.lblForgotPasswordError = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlForgotPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.pnlForgotPassword);
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
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
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
            this.lblBack.Location = new System.Drawing.Point(320, 31);
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
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
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
            // pnlForgotPassword
            // 
            this.pnlForgotPassword.BackColor = System.Drawing.Color.White;
            this.pnlForgotPassword.Controls.Add(this.lblForgotPasswordError);
            this.pnlForgotPassword.Controls.Add(this.lblBacktoLogin);
            this.pnlForgotPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlForgotPassword.Controls.Add(this.btnResetPassword);
            this.pnlForgotPassword.Controls.Add(this.pictureBox2);
            this.pnlForgotPassword.Controls.Add(this.pictureBox1);
            this.pnlForgotPassword.Controls.Add(this.txtNewPassword);
            this.pnlForgotPassword.Controls.Add(this.txtForgotEmail);
            this.pnlForgotPassword.Controls.Add(this.lblPasswordUpdate);
            this.pnlForgotPassword.Controls.Add(this.lblForgot);
            this.pnlForgotPassword.Location = new System.Drawing.Point(523, 47);
            this.pnlForgotPassword.Name = "pnlForgotPassword";
            this.pnlForgotPassword.Size = new System.Drawing.Size(500, 550);
            this.pnlForgotPassword.TabIndex = 5;
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblForgot.Location = new System.Drawing.Point(49, 108);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(164, 60);
            this.lblForgot.TabIndex = 0;
            this.lblForgot.Text = "Forgot";
            // 
            // lblPasswordUpdate
            // 
            this.lblPasswordUpdate.AutoSize = true;
            this.lblPasswordUpdate.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordUpdate.ForeColor = System.Drawing.Color.Green;
            this.lblPasswordUpdate.Location = new System.Drawing.Point(224, 108);
            this.lblPasswordUpdate.Name = "lblPasswordUpdate";
            this.lblPasswordUpdate.Size = new System.Drawing.Size(239, 60);
            this.lblPasswordUpdate.TabIndex = 1;
            this.lblPasswordUpdate.Text = "Password?";
            // 
            // txtForgotEmail
            // 
            this.txtForgotEmail.Location = new System.Drawing.Point(67, 212);
            this.txtForgotEmail.Name = "txtForgotEmail";
            this.txtForgotEmail.Size = new System.Drawing.Size(361, 22);
            this.txtForgotEmail.TabIndex = 2;
            this.txtForgotEmail.Text = "Email";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(67, 273);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(361, 22);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.Text = "New Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Queeless.Properties.Resources.Navy_and_Green_Queueless_Wordmark;
            this.pictureBox1.Location = new System.Drawing.Point(28, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Queeless.Properties.Resources.Navy_and_Green_Queueless_Wordmark;
            this.pictureBox2.Location = new System.Drawing.Point(289, 458);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Green;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(67, 422);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(185, 54);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(67, 331);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(361, 22);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblBacktoLogin
            // 
            this.lblBacktoLogin.AutoSize = true;
            this.lblBacktoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBacktoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBacktoLogin.Location = new System.Drawing.Point(67, 388);
            this.lblBacktoLogin.Name = "lblBacktoLogin";
            this.lblBacktoLogin.Size = new System.Drawing.Size(88, 16);
            this.lblBacktoLogin.TabIndex = 8;
            this.lblBacktoLogin.Text = "Back to Login";
            this.lblBacktoLogin.Click += new System.EventHandler(this.lblBacktoLogin_Click);
            // 
            // lblForgotPasswordError
            // 
            this.lblForgotPasswordError.AutoSize = true;
            this.lblForgotPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblForgotPasswordError.Location = new System.Drawing.Point(234, 370);
            this.lblForgotPasswordError.Name = "lblForgotPasswordError";
            this.lblForgotPasswordError.Size = new System.Drawing.Size(0, 16);
            this.lblForgotPasswordError.TabIndex = 9;
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnlQueueLessWorks = new System.Windows.Forms.Panel();
            this.pnlHowItWorks = new System.Windows.Forms.Panel();
            this.pnlPreorderCard = new System.Windows.Forms.Panel();
            this.lblThreeInfo = new System.Windows.Forms.Label();
            this.lblTwoInfo = new System.Windows.Forms.Label();
            this.lblOneInfo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblPreOrderAndCollcetInfo = new System.Windows.Forms.Label();
            this.lblCollect = new System.Windows.Forms.Label();
            this.pnlDeliverCard = new System.Windows.Forms.Panel();
            this.lblFoodArrivesAtYourSeat = new System.Windows.Forms.Label();
            this.lblPickYourCampusLocation = new System.Windows.Forms.Label();
            this.lblChooseYourOutletsItems = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblDeliverToMyLocationExplaination = new System.Windows.Forms.Label();
            this.lblDeliverToMyLocation = new System.Windows.Forms.Label();
            this.lblWorksSub = new System.Windows.Forms.Label();
            this.lblWorksTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpStatsRow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCampusOutlest = new System.Windows.Forms.Panel();
            this.lblCampusOutlets = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.pnlDeliveryTime = new System.Windows.Forms.Panel();
            this.lblAverageDeliveryTime = new System.Windows.Forms.Label();
            this.lbl8Min = new System.Windows.Forms.Label();
            this.pnlStudentsStaff = new System.Windows.Forms.Panel();
            this.lblstudentsAndStaff = new System.Windows.Forms.Label();
            this.lbl5000 = new System.Windows.Forms.Label();
            this.pnl0Queue = new System.Windows.Forms.Panel();
            this.lblPreOrder = new System.Windows.Forms.Label();
            this.lbl0Queue = new System.Windows.Forms.Label();
            this.pnlCampusFoodReimagined = new System.Windows.Forms.Panel();
            this.pnlPreOrder = new System.Windows.Forms.Panel();
            this.lblPreOrderAndCollectExplaination = new System.Windows.Forms.Label();
            this.lblPreOrderAndCollect = new System.Windows.Forms.Label();
            this.pictureBoxlighting = new System.Windows.Forms.PictureBox();
            this.pnlDeliver = new System.Windows.Forms.Panel();
            this.lblDeliverExplanation = new System.Windows.Forms.Label();
            this.lblDeliverToRoom = new System.Windows.Forms.Label();
            this.pictureBoxBuilding = new System.Windows.Forms.PictureBox();
            this.lblGetFood = new System.Windows.Forms.Label();
            this.pnl8MinWait = new System.Windows.Forms.Panel();
            this.lblMinWait = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.pnlOrderReady = new System.Windows.Forms.Panel();
            this.lblLectureRoomA101 = new System.Windows.Forms.Label();
            this.lblOrderReady = new System.Windows.Forms.Label();
            this.pictureBoxCheckMark = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxBurger = new System.Windows.Forms.PictureBox();
            this.btnFindFood = new System.Windows.Forms.Button();
            this.cmbSelectDeliveryLocation = new System.Windows.Forms.ComboBox();
            this.lblOrderFoodToLectureRoom = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblCampusFoodReimagined = new System.Windows.Forms.Label();
            this.pnl1Queueless = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOutlets = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.lblQueueLess = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPopular = new System.Windows.Forms.Panel();
            this.flpPopularItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlClassicSmashBurger = new System.Windows.Forms.Panel();
            this.btnplus = new System.Windows.Forms.Button();
            this.lblClassicSmashBurger = new System.Windows.Forms.Label();
            this.lbl89 = new System.Windows.Forms.Label();
            this.lblCampusGrill = new System.Windows.Forms.Label();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.pictureBoxSmashBurger = new System.Windows.Forms.PictureBox();
            this.pnlHarvestGrainBowl = new System.Windows.Forms.Panel();
            this.btnplus1 = new System.Windows.Forms.Button();
            this.lblHarvestGrainBowl = new System.Windows.Forms.Label();
            this.lbl65 = new System.Windows.Forms.Label();
            this.lblFreshAndGreen = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBoxHarvestGrainBowl = new System.Windows.Forms.PictureBox();
            this.pnlFlatWhiteCroissant = new System.Windows.Forms.Panel();
            this.btnplus2 = new System.Windows.Forms.Button();
            this.lblFlatWhiteCroissant = new System.Windows.Forms.Label();
            this.lbl48 = new System.Windows.Forms.Label();
            this.lblBrewAndBite = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.pictureBoxFlatWhiteAndCroissant = new System.Windows.Forms.PictureBox();
            this.pnlNoodleBox = new System.Windows.Forms.Panel();
            this.btnplus3 = new System.Windows.Forms.Button();
            this.lblNoodleBox = new System.Windows.Forms.Label();
            this.lbl75 = new System.Windows.Forms.Label();
            this.lblNoodleHouse = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.pictureBoxNoodleBox = new System.Windows.Forms.PictureBox();
            this.lblPopularRightNow = new System.Windows.Forms.Label();
            this.btnViewAllOutLets = new System.Windows.Forms.Button();
            this.pnlMainScroll = new System.Windows.Forms.Panel();
            this.pnlQueueLessWorks.SuspendLayout();
            this.pnlHowItWorks.SuspendLayout();
            this.pnlPreorderCard.SuspendLayout();
            this.pnlDeliverCard.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flpStatsRow.SuspendLayout();
            this.pnlCampusOutlest.SuspendLayout();
            this.pnlDeliveryTime.SuspendLayout();
            this.pnlStudentsStaff.SuspendLayout();
            this.pnl0Queue.SuspendLayout();
            this.pnlCampusFoodReimagined.SuspendLayout();
            this.pnlPreOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlighting)).BeginInit();
            this.pnlDeliver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).BeginInit();
            this.pnl8MinWait.SuspendLayout();
            this.pnlOrderReady.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBurger)).BeginInit();
            this.pnl1Queueless.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlPopular.SuspendLayout();
            this.flpPopularItems.SuspendLayout();
            this.pnlClassicSmashBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmashBurger)).BeginInit();
            this.pnlHarvestGrainBowl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarvestGrainBowl)).BeginInit();
            this.pnlFlatWhiteCroissant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlatWhiteAndCroissant)).BeginInit();
            this.pnlNoodleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoodleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQueueLessWorks
            // 
            this.pnlQueueLessWorks.Controls.Add(this.pnlHowItWorks);
            this.pnlQueueLessWorks.Location = new System.Drawing.Point(3, 631);
            this.pnlQueueLessWorks.Name = "pnlQueueLessWorks";
            this.pnlQueueLessWorks.Size = new System.Drawing.Size(1200, 380);
            this.pnlQueueLessWorks.TabIndex = 7;
            // 
            // pnlHowItWorks
            // 
            this.pnlHowItWorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlHowItWorks.Controls.Add(this.pnlPreorderCard);
            this.pnlHowItWorks.Controls.Add(this.pnlDeliverCard);
            this.pnlHowItWorks.Controls.Add(this.lblWorksSub);
            this.pnlHowItWorks.Controls.Add(this.lblWorksTitle);
            this.pnlHowItWorks.Location = new System.Drawing.Point(21, 21);
            this.pnlHowItWorks.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.pnlHowItWorks.Name = "pnlHowItWorks";
            this.pnlHowItWorks.Size = new System.Drawing.Size(1100, 350);
            this.pnlHowItWorks.TabIndex = 0;
            // 
            // pnlPreorderCard
            // 
            this.pnlPreorderCard.BackColor = System.Drawing.Color.White;
            this.pnlPreorderCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreorderCard.Controls.Add(this.lblThreeInfo);
            this.pnlPreorderCard.Controls.Add(this.lblTwoInfo);
            this.pnlPreorderCard.Controls.Add(this.lblOneInfo);
            this.pnlPreorderCard.Controls.Add(this.lblThree);
            this.pnlPreorderCard.Controls.Add(this.lblTwo);
            this.pnlPreorderCard.Controls.Add(this.lblOne);
            this.pnlPreorderCard.Controls.Add(this.lblPreOrderAndCollcetInfo);
            this.pnlPreorderCard.Controls.Add(this.lblCollect);
            this.pnlPreorderCard.Location = new System.Drawing.Point(550, 90);
            this.pnlPreorderCard.Name = "pnlPreorderCard";
            this.pnlPreorderCard.Size = new System.Drawing.Size(500, 230);
            this.pnlPreorderCard.TabIndex = 3;
            // 
            // lblThreeInfo
            // 
            this.lblThreeInfo.AutoSize = true;
            this.lblThreeInfo.Location = new System.Drawing.Point(64, 183);
            this.lblThreeInfo.Name = "lblThreeInfo";
            this.lblThreeInfo.Size = new System.Drawing.Size(202, 23);
            this.lblThreeInfo.TabIndex = 9;
            this.lblThreeInfo.Text = "Walk in, pick up, walk out";
            // 
            // lblTwoInfo
            // 
            this.lblTwoInfo.AutoSize = true;
            this.lblTwoInfo.Location = new System.Drawing.Point(64, 160);
            this.lblTwoInfo.Name = "lblTwoInfo";
            this.lblTwoInfo.Size = new System.Drawing.Size(190, 23);
            this.lblTwoInfo.TabIndex = 8;
            this.lblTwoInfo.Text = "Set your collection time";
            // 
            // lblOneInfo
            // 
            this.lblOneInfo.AutoSize = true;
            this.lblOneInfo.Location = new System.Drawing.Point(64, 137);
            this.lblOneInfo.Name = "lblOneInfo";
            this.lblOneInfo.Size = new System.Drawing.Size(267, 23);
            this.lblOneInfo.TabIndex = 7;
            this.lblOneInfo.Text = "Browse and order from any outlet";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Location = new System.Drawing.Point(32, 183);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(19, 23);
            this.lblThree.TabIndex = 6;
            this.lblThree.Text = "3";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(32, 160);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(19, 23);
            this.lblTwo.TabIndex = 5;
            this.lblTwo.Text = "2";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(32, 137);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(19, 23);
            this.lblOne.TabIndex = 3;
            this.lblOne.Text = "1";
            // 
            // lblPreOrderAndCollcetInfo
            // 
            this.lblPreOrderAndCollcetInfo.AutoSize = true;
            this.lblPreOrderAndCollcetInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPreOrderAndCollcetInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPreOrderAndCollcetInfo.Location = new System.Drawing.Point(32, 59);
            this.lblPreOrderAndCollcetInfo.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblPreOrderAndCollcetInfo.Name = "lblPreOrderAndCollcetInfo";
            this.lblPreOrderAndCollcetInfo.Size = new System.Drawing.Size(458, 69);
            this.lblPreOrderAndCollcetInfo.TabIndex = 1;
            this.lblPreOrderAndCollcetInfo.Text = "Order between classes, schedule a collection time, and walk straight to the count" +
    "er when your food is ready. Zero queue, guaranteed.";
            // 
            // lblCollect
            // 
            this.lblCollect.AutoSize = true;
            this.lblCollect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollect.Location = new System.Drawing.Point(31, 13);
            this.lblCollect.Name = "lblCollect";
            this.lblCollect.Size = new System.Drawing.Size(214, 28);
            this.lblCollect.TabIndex = 0;
            this.lblCollect.Text = "Pre-order and Collect";
            // 
            // pnlDeliverCard
            // 
            this.pnlDeliverCard.BackColor = System.Drawing.Color.White;
            this.pnlDeliverCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeliverCard.Controls.Add(this.lblFoodArrivesAtYourSeat);
            this.pnlDeliverCard.Controls.Add(this.lblPickYourCampusLocation);
            this.pnlDeliverCard.Controls.Add(this.lblChooseYourOutletsItems);
            this.pnlDeliverCard.Controls.Add(this.lbl2);
            this.pnlDeliverCard.Controls.Add(this.lbl3);
            this.pnlDeliverCard.Controls.Add(this.lbl1);
            this.pnlDeliverCard.Controls.Add(this.lblDeliverToMyLocationExplaination);
            this.pnlDeliverCard.Controls.Add(this.lblDeliverToMyLocation);
            this.pnlDeliverCard.Location = new System.Drawing.Point(30, 90);
            this.pnlDeliverCard.Name = "pnlDeliverCard";
            this.pnlDeliverCard.Size = new System.Drawing.Size(500, 230);
            this.pnlDeliverCard.TabIndex = 2;
            // 
            // lblFoodArrivesAtYourSeat
            // 
            this.lblFoodArrivesAtYourSeat.AutoSize = true;
            this.lblFoodArrivesAtYourSeat.Location = new System.Drawing.Point(61, 183);
            this.lblFoodArrivesAtYourSeat.Name = "lblFoodArrivesAtYourSeat";
            this.lblFoodArrivesAtYourSeat.Size = new System.Drawing.Size(197, 23);
            this.lblFoodArrivesAtYourSeat.TabIndex = 7;
            this.lblFoodArrivesAtYourSeat.Text = "Food arrives at your seat";
            // 
            // lblPickYourCampusLocation
            // 
            this.lblPickYourCampusLocation.AutoSize = true;
            this.lblPickYourCampusLocation.Location = new System.Drawing.Point(60, 160);
            this.lblPickYourCampusLocation.Name = "lblPickYourCampusLocation";
            this.lblPickYourCampusLocation.Size = new System.Drawing.Size(209, 23);
            this.lblPickYourCampusLocation.TabIndex = 6;
            this.lblPickYourCampusLocation.Text = "Pick your campus location";
            // 
            // lblChooseYourOutletsItems
            // 
            this.lblChooseYourOutletsItems.AutoSize = true;
            this.lblChooseYourOutletsItems.Location = new System.Drawing.Point(60, 137);
            this.lblChooseYourOutletsItems.Name = "lblChooseYourOutletsItems";
            this.lblChooseYourOutletsItems.Size = new System.Drawing.Size(207, 23);
            this.lblChooseYourOutletsItems.TabIndex = 5;
            this.lblChooseYourOutletsItems.Text = "Choose your outlet & items";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(25, 160);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 23);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(25, 183);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(19, 23);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "3";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(26, 137);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 23);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "1";
            // 
            // lblDeliverToMyLocationExplaination
            // 
            this.lblDeliverToMyLocationExplaination.AutoSize = true;
            this.lblDeliverToMyLocationExplaination.ForeColor = System.Drawing.Color.DimGray;
            this.lblDeliverToMyLocationExplaination.Location = new System.Drawing.Point(27, 59);
            this.lblDeliverToMyLocationExplaination.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblDeliverToMyLocationExplaination.Name = "lblDeliverToMyLocationExplaination";
            this.lblDeliverToMyLocationExplaination.Size = new System.Drawing.Size(455, 69);
            this.lblDeliverToMyLocationExplaination.TabIndex = 1;
            this.lblDeliverToMyLocationExplaination.Text = "Select your lecture room,library desk, or any campus spot. We deliver straight to" +
    " you - hot and on time, even mid-lecture";
            // 
            // lblDeliverToMyLocation
            // 
            this.lblDeliverToMyLocation.AutoSize = true;
            this.lblDeliverToMyLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverToMyLocation.Location = new System.Drawing.Point(25, 13);
            this.lblDeliverToMyLocation.Name = "lblDeliverToMyLocation";
            this.lblDeliverToMyLocation.Size = new System.Drawing.Size(229, 28);
            this.lblDeliverToMyLocation.TabIndex = 0;
            this.lblDeliverToMyLocation.Text = "Deliver to My Location";
            // 
            // lblWorksSub
            // 
            this.lblWorksSub.AutoSize = true;
            this.lblWorksSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorksSub.ForeColor = System.Drawing.Color.Gray;
            this.lblWorksSub.Location = new System.Drawing.Point(30, 55);
            this.lblWorksSub.Name = "lblWorksSub";
            this.lblWorksSub.Size = new System.Drawing.Size(375, 20);
            this.lblWorksSub.TabIndex = 1;
            this.lblWorksSub.Text = "\"Two ways to get your campus food - no queuing,ever.\"";
            // 
            // lblWorksTitle
            // 
            this.lblWorksTitle.AutoSize = true;
            this.lblWorksTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorksTitle.Location = new System.Drawing.Point(30, 20);
            this.lblWorksTitle.Name = "lblWorksTitle";
            this.lblWorksTitle.Size = new System.Drawing.Size(336, 41);
            this.lblWorksTitle.TabIndex = 0;
            this.lblWorksTitle.Text = "How QueueLess Works";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1920, 90);
            this.panel3.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.flpStatsRow);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1920, 90);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // flpStatsRow
            // 
            this.flpStatsRow.Controls.Add(this.pnlCampusOutlest);
            this.flpStatsRow.Controls.Add(this.pnlDeliveryTime);
            this.flpStatsRow.Controls.Add(this.pnlStudentsStaff);
            this.flpStatsRow.Controls.Add(this.pnl0Queue);
            this.flpStatsRow.Location = new System.Drawing.Point(3, 3);
            this.flpStatsRow.Name = "flpStatsRow";
            this.flpStatsRow.Size = new System.Drawing.Size(1745, 90);
            this.flpStatsRow.TabIndex = 11;
            this.flpStatsRow.WrapContents = false;
            // 
            // pnlCampusOutlest
            // 
            this.pnlCampusOutlest.BackColor = System.Drawing.Color.White;
            this.pnlCampusOutlest.Controls.Add(this.lblCampusOutlets);
            this.pnlCampusOutlest.Controls.Add(this.lbl6);
            this.pnlCampusOutlest.Location = new System.Drawing.Point(10, 10);
            this.pnlCampusOutlest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlCampusOutlest.Name = "pnlCampusOutlest";
            this.pnlCampusOutlest.Size = new System.Drawing.Size(240, 70);
            this.pnlCampusOutlest.TabIndex = 8;
            // 
            // lblCampusOutlets
            // 
            this.lblCampusOutlets.AutoSize = true;
            this.lblCampusOutlets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampusOutlets.ForeColor = System.Drawing.Color.Gray;
            this.lblCampusOutlets.Location = new System.Drawing.Point(38, 40);
            this.lblCampusOutlets.Name = "lblCampusOutlets";
            this.lblCampusOutlets.Size = new System.Drawing.Size(113, 20);
            this.lblCampusOutlets.TabIndex = 8;
            this.lblCampusOutlets.Text = "Campus Outlets";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(76, 9);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(27, 31);
            this.lbl6.TabIndex = 7;
            this.lbl6.Text = "6";
            // 
            // pnlDeliveryTime
            // 
            this.pnlDeliveryTime.BackColor = System.Drawing.Color.White;
            this.pnlDeliveryTime.Controls.Add(this.lblAverageDeliveryTime);
            this.pnlDeliveryTime.Controls.Add(this.lbl8Min);
            this.pnlDeliveryTime.Location = new System.Drawing.Point(270, 10);
            this.pnlDeliveryTime.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDeliveryTime.Name = "pnlDeliveryTime";
            this.pnlDeliveryTime.Size = new System.Drawing.Size(240, 70);
            this.pnlDeliveryTime.TabIndex = 9;
            // 
            // lblAverageDeliveryTime
            // 
            this.lblAverageDeliveryTime.AutoSize = true;
            this.lblAverageDeliveryTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageDeliveryTime.ForeColor = System.Drawing.Color.Gray;
            this.lblAverageDeliveryTime.Location = new System.Drawing.Point(71, 38);
            this.lblAverageDeliveryTime.Name = "lblAverageDeliveryTime";
            this.lblAverageDeliveryTime.Size = new System.Drawing.Size(132, 20);
            this.lblAverageDeliveryTime.TabIndex = 1;
            this.lblAverageDeliveryTime.Text = "Avg.  delivery time";
            // 
            // lbl8Min
            // 
            this.lbl8Min.AutoSize = true;
            this.lbl8Min.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8Min.Location = new System.Drawing.Point(71, 9);
            this.lbl8Min.Name = "lbl8Min";
            this.lbl8Min.Size = new System.Drawing.Size(75, 31);
            this.lbl8Min.TabIndex = 0;
            this.lbl8Min.Text = "8 min";
            // 
            // pnlStudentsStaff
            // 
            this.pnlStudentsStaff.BackColor = System.Drawing.Color.White;
            this.pnlStudentsStaff.Controls.Add(this.lblstudentsAndStaff);
            this.pnlStudentsStaff.Controls.Add(this.lbl5000);
            this.pnlStudentsStaff.Location = new System.Drawing.Point(530, 10);
            this.pnlStudentsStaff.Margin = new System.Windows.Forms.Padding(10);
            this.pnlStudentsStaff.Name = "pnlStudentsStaff";
            this.pnlStudentsStaff.Size = new System.Drawing.Size(240, 70);
            this.pnlStudentsStaff.TabIndex = 10;
            // 
            // lblstudentsAndStaff
            // 
            this.lblstudentsAndStaff.AutoSize = true;
            this.lblstudentsAndStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentsAndStaff.ForeColor = System.Drawing.Color.Gray;
            this.lblstudentsAndStaff.Location = new System.Drawing.Point(83, 35);
            this.lblstudentsAndStaff.Name = "lblstudentsAndStaff";
            this.lblstudentsAndStaff.Size = new System.Drawing.Size(130, 20);
            this.lblstudentsAndStaff.TabIndex = 3;
            this.lblstudentsAndStaff.Text = "Students and Staff";
            // 
            // lbl5000
            // 
            this.lbl5000.AutoSize = true;
            this.lbl5000.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5000.Location = new System.Drawing.Point(83, 9);
            this.lbl5000.Name = "lbl5000";
            this.lbl5000.Size = new System.Drawing.Size(88, 31);
            this.lbl5000.TabIndex = 2;
            this.lbl5000.Text = "5,000+";
            // 
            // pnl0Queue
            // 
            this.pnl0Queue.BackColor = System.Drawing.Color.White;
            this.pnl0Queue.Controls.Add(this.lblPreOrder);
            this.pnl0Queue.Controls.Add(this.lbl0Queue);
            this.pnl0Queue.Location = new System.Drawing.Point(790, 10);
            this.pnl0Queue.Margin = new System.Windows.Forms.Padding(10);
            this.pnl0Queue.Name = "pnl0Queue";
            this.pnl0Queue.Size = new System.Drawing.Size(240, 70);
            this.pnl0Queue.TabIndex = 12;
            // 
            // lblPreOrder
            // 
            this.lblPreOrder.AutoSize = true;
            this.lblPreOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrder.ForeColor = System.Drawing.Color.Gray;
            this.lblPreOrder.Location = new System.Drawing.Point(59, 40);
            this.lblPreOrder.Name = "lblPreOrder";
            this.lblPreOrder.Size = new System.Drawing.Size(143, 20);
            this.lblPreOrder.TabIndex = 1;
            this.lblPreOrder.Text = "Pre-order guarantee";
            // 
            // lbl0Queue
            // 
            this.lbl0Queue.AutoSize = true;
            this.lbl0Queue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Queue.Location = new System.Drawing.Point(72, 9);
            this.lbl0Queue.Name = "lbl0Queue";
            this.lbl0Queue.Size = new System.Drawing.Size(99, 31);
            this.lbl0Queue.TabIndex = 0;
            this.lbl0Queue.Text = "0 queue";
            // 
            // pnlCampusFoodReimagined
            // 
            this.pnlCampusFoodReimagined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.pnlCampusFoodReimagined.Controls.Add(this.pnlPreOrder);
            this.pnlCampusFoodReimagined.Controls.Add(this.pnlDeliver);
            this.pnlCampusFoodReimagined.Controls.Add(this.lblGetFood);
            this.pnlCampusFoodReimagined.Controls.Add(this.pnl8MinWait);
            this.pnlCampusFoodReimagined.Controls.Add(this.pnlOrderReady);
            this.pnlCampusFoodReimagined.Controls.Add(this.flowLayoutPanel2);
            this.pnlCampusFoodReimagined.Controls.Add(this.pictureBoxBurger);
            this.pnlCampusFoodReimagined.Controls.Add(this.btnFindFood);
            this.pnlCampusFoodReimagined.Controls.Add(this.cmbSelectDeliveryLocation);
            this.pnlCampusFoodReimagined.Controls.Add(this.lblOrderFoodToLectureRoom);
            this.pnlCampusFoodReimagined.Controls.Add(this.panel10);
            this.pnlCampusFoodReimagined.Controls.Add(this.lblCampusFoodReimagined);
            this.pnlCampusFoodReimagined.Location = new System.Drawing.Point(3, 79);
            this.pnlCampusFoodReimagined.Name = "pnlCampusFoodReimagined";
            this.pnlCampusFoodReimagined.Size = new System.Drawing.Size(1920, 450);
            this.pnlCampusFoodReimagined.TabIndex = 2;
            // 
            // pnlPreOrder
            // 
            this.pnlPreOrder.Controls.Add(this.lblPreOrderAndCollectExplaination);
            this.pnlPreOrder.Controls.Add(this.lblPreOrderAndCollect);
            this.pnlPreOrder.Controls.Add(this.pictureBoxlighting);
            this.pnlPreOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPreOrder.Location = new System.Drawing.Point(431, 215);
            this.pnlPreOrder.Name = "pnlPreOrder";
            this.pnlPreOrder.Size = new System.Drawing.Size(395, 113);
            this.pnlPreOrder.TabIndex = 17;
            this.pnlPreOrder.Click += new System.EventHandler(this.lblPreOrderAndCollect_Click);
            // 
            // lblPreOrderAndCollectExplaination
            // 
            this.lblPreOrderAndCollectExplaination.AutoSize = true;
            this.lblPreOrderAndCollectExplaination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreOrderAndCollectExplaination.ForeColor = System.Drawing.Color.LightGray;
            this.lblPreOrderAndCollectExplaination.Location = new System.Drawing.Point(6, 78);
            this.lblPreOrderAndCollectExplaination.Name = "lblPreOrderAndCollectExplaination";
            this.lblPreOrderAndCollectExplaination.Size = new System.Drawing.Size(373, 23);
            this.lblPreOrderAndCollectExplaination.TabIndex = 2;
            this.lblPreOrderAndCollectExplaination.Text = "Order ahead ,skip the queue,collect when ready";
            this.lblPreOrderAndCollectExplaination.Click += new System.EventHandler(this.lblPreOrderAndCollect_Click);
            // 
            // lblPreOrderAndCollect
            // 
            this.lblPreOrderAndCollect.AutoSize = true;
            this.lblPreOrderAndCollect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreOrderAndCollect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrderAndCollect.ForeColor = System.Drawing.Color.White;
            this.lblPreOrderAndCollect.Location = new System.Drawing.Point(6, 54);
            this.lblPreOrderAndCollect.Name = "lblPreOrderAndCollect";
            this.lblPreOrderAndCollect.Size = new System.Drawing.Size(182, 23);
            this.lblPreOrderAndCollect.TabIndex = 1;
            this.lblPreOrderAndCollect.Text = "Pre-order and Collect";
            this.lblPreOrderAndCollect.Click += new System.EventHandler(this.lblPreOrderAndCollect_Click);
            // 
            // pictureBoxlighting
            // 
            this.pictureBoxlighting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxlighting.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxlighting.Image")));
            this.pictureBoxlighting.Location = new System.Drawing.Point(10, 8);
            this.pictureBoxlighting.Name = "pictureBoxlighting";
            this.pictureBoxlighting.Size = new System.Drawing.Size(38, 35);
            this.pictureBoxlighting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlighting.TabIndex = 0;
            this.pictureBoxlighting.TabStop = false;
            this.pictureBoxlighting.Click += new System.EventHandler(this.lblPreOrderAndCollect_Click);
            // 
            // pnlDeliver
            // 
            this.pnlDeliver.Controls.Add(this.lblDeliverExplanation);
            this.pnlDeliver.Controls.Add(this.lblDeliverToRoom);
            this.pnlDeliver.Controls.Add(this.pictureBoxBuilding);
            this.pnlDeliver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDeliver.Location = new System.Drawing.Point(48, 215);
            this.pnlDeliver.Name = "pnlDeliver";
            this.pnlDeliver.Size = new System.Drawing.Size(357, 113);
            this.pnlDeliver.TabIndex = 16;
            this.pnlDeliver.Click += new System.EventHandler(this.lblDeliverToRoom_Click);
            // 
            // lblDeliverExplanation
            // 
            this.lblDeliverExplanation.AutoSize = true;
            this.lblDeliverExplanation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeliverExplanation.ForeColor = System.Drawing.Color.LightGray;
            this.lblDeliverExplanation.Location = new System.Drawing.Point(4, 78);
            this.lblDeliverExplanation.Name = "lblDeliverExplanation";
            this.lblDeliverExplanation.Size = new System.Drawing.Size(350, 23);
            this.lblDeliverExplanation.TabIndex = 2;
            this.lblDeliverExplanation.Text = "We bring it to your lecturer room or location";
            this.lblDeliverExplanation.Click += new System.EventHandler(this.lblDeliverToRoom_Click);
            // 
            // lblDeliverToRoom
            // 
            this.lblDeliverToRoom.AutoSize = true;
            this.lblDeliverToRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeliverToRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverToRoom.ForeColor = System.Drawing.Color.White;
            this.lblDeliverToRoom.Location = new System.Drawing.Point(6, 54);
            this.lblDeliverToRoom.Name = "lblDeliverToRoom";
            this.lblDeliverToRoom.Size = new System.Drawing.Size(141, 23);
            this.lblDeliverToRoom.TabIndex = 1;
            this.lblDeliverToRoom.Text = "Deliver to Room";
            this.lblDeliverToRoom.Click += new System.EventHandler(this.lblDeliverToRoom_Click);
            // 
            // pictureBoxBuilding
            // 
            this.pictureBoxBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBoxBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBuilding.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBuilding.Image")));
            this.pictureBoxBuilding.Location = new System.Drawing.Point(10, 3);
            this.pictureBoxBuilding.Name = "pictureBoxBuilding";
            this.pictureBoxBuilding.Size = new System.Drawing.Size(53, 38);
            this.pictureBoxBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBuilding.TabIndex = 0;
            this.pictureBoxBuilding.TabStop = false;
            this.pictureBoxBuilding.Click += new System.EventHandler(this.lblDeliverToRoom_Click);
            // 
            // lblGetFood
            // 
            this.lblGetFood.AutoSize = true;
            this.lblGetFood.ForeColor = System.Drawing.Color.LightGray;
            this.lblGetFood.Location = new System.Drawing.Point(30, 129);
            this.lblGetFood.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblGetFood.Name = "lblGetFood";
            this.lblGetFood.Size = new System.Drawing.Size(396, 69);
            this.lblGetFood.TabIndex = 15;
            this.lblGetFood.Text = "Get food delivered straight to your seat, or pre-order from campus outlets and co" +
    "llect without queuing.";
            // 
            // pnl8MinWait
            // 
            this.pnl8MinWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnl8MinWait.Controls.Add(this.lblMinWait);
            this.pnl8MinWait.Controls.Add(this.lbl8);
            this.pnl8MinWait.Location = new System.Drawing.Point(1365, 29);
            this.pnl8MinWait.Name = "pnl8MinWait";
            this.pnl8MinWait.Size = new System.Drawing.Size(101, 100);
            this.pnl8MinWait.TabIndex = 14;
            // 
            // lblMinWait
            // 
            this.lblMinWait.AutoSize = true;
            this.lblMinWait.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinWait.ForeColor = System.Drawing.Color.DimGray;
            this.lblMinWait.Location = new System.Drawing.Point(26, 65);
            this.lblMinWait.Name = "lblMinWait";
            this.lblMinWait.Size = new System.Drawing.Size(60, 17);
            this.lblMinWait.TabIndex = 1;
            this.lblMinWait.Text = "min wait ";
            this.lblMinWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl8.Location = new System.Drawing.Point(38, 10);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(39, 45);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "8";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOrderReady
            // 
            this.pnlOrderReady.BackColor = System.Drawing.Color.White;
            this.pnlOrderReady.Controls.Add(this.lblLectureRoomA101);
            this.pnlOrderReady.Controls.Add(this.lblOrderReady);
            this.pnlOrderReady.Controls.Add(this.pictureBoxCheckMark);
            this.pnlOrderReady.Location = new System.Drawing.Point(906, 218);
            this.pnlOrderReady.Name = "pnlOrderReady";
            this.pnlOrderReady.Size = new System.Drawing.Size(200, 98);
            this.pnlOrderReady.TabIndex = 13;
            // 
            // lblLectureRoomA101
            // 
            this.lblLectureRoomA101.AutoSize = true;
            this.lblLectureRoomA101.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureRoomA101.ForeColor = System.Drawing.Color.Black;
            this.lblLectureRoomA101.Location = new System.Drawing.Point(48, 72);
            this.lblLectureRoomA101.Name = "lblLectureRoomA101";
            this.lblLectureRoomA101.Size = new System.Drawing.Size(149, 20);
            this.lblLectureRoomA101.TabIndex = 15;
            this.lblLectureRoomA101.Text = "Lecture Room A101";
            // 
            // lblOrderReady
            // 
            this.lblOrderReady.AutoSize = true;
            this.lblOrderReady.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderReady.ForeColor = System.Drawing.Color.Gray;
            this.lblOrderReady.Location = new System.Drawing.Point(76, 10);
            this.lblOrderReady.Name = "lblOrderReady";
            this.lblOrderReady.Size = new System.Drawing.Size(80, 17);
            this.lblOrderReady.TabIndex = 14;
            this.lblOrderReady.Text = "Order ready";
            // 
            // pictureBoxCheckMark
            // 
            this.pictureBoxCheckMark.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxCheckMark.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckMark.Image")));
            this.pictureBoxCheckMark.Location = new System.Drawing.Point(3, 23);
            this.pictureBoxCheckMark.Name = "pictureBoxCheckMark";
            this.pictureBoxCheckMark.Size = new System.Drawing.Size(51, 46);
            this.pictureBoxCheckMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheckMark.TabIndex = 0;
            this.pictureBoxCheckMark.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(494, 543);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(126, 81);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxBurger
            // 
            this.pictureBoxBurger.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBurger.Image")));
            this.pictureBoxBurger.Location = new System.Drawing.Point(1071, 67);
            this.pictureBoxBurger.Name = "pictureBoxBurger";
            this.pictureBoxBurger.Size = new System.Drawing.Size(236, 182);
            this.pictureBoxBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBurger.TabIndex = 12;
            this.pictureBoxBurger.TabStop = false;
            // 
            // btnFindFood
            // 
            this.btnFindFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFindFood.ForeColor = System.Drawing.Color.White;
            this.btnFindFood.Location = new System.Drawing.Point(321, 365);
            this.btnFindFood.Name = "btnFindFood";
            this.btnFindFood.Size = new System.Drawing.Size(120, 28);
            this.btnFindFood.TabIndex = 3;
            this.btnFindFood.Text = "Find Food ";
            this.btnFindFood.UseVisualStyleBackColor = false;
            // 
            // cmbSelectDeliveryLocation
            // 
            this.cmbSelectDeliveryLocation.FormattingEnabled = true;
            this.cmbSelectDeliveryLocation.Items.AddRange(new object[] {
            "Lecture Room A101",
            "Lecture Room A102",
            "Lecture Room B201",
            "Lecture Room B202",
            "Lecture Room C301",
            "Tutorial Room 1",
            "Tutorial Room 2",
            "Library - Study Zone",
            "Engineering Lab 1",
            "Science Lab 2",
            "Staff Room - Block A",
            "Staff Room - Block B",
            "Outdoor Quad",
            "Sports Pavillion",
            "Tutorial Room 2"});
            this.cmbSelectDeliveryLocation.Location = new System.Drawing.Point(58, 362);
            this.cmbSelectDeliveryLocation.Name = "cmbSelectDeliveryLocation";
            this.cmbSelectDeliveryLocation.Size = new System.Drawing.Size(214, 31);
            this.cmbSelectDeliveryLocation.TabIndex = 2;
            this.cmbSelectDeliveryLocation.Text = "Select delivery location...";
            // 
            // lblOrderFoodToLectureRoom
            // 
            this.lblOrderFoodToLectureRoom.AutoSize = true;
            this.lblOrderFoodToLectureRoom.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderFoodToLectureRoom.ForeColor = System.Drawing.Color.White;
            this.lblOrderFoodToLectureRoom.Location = new System.Drawing.Point(14, 67);
            this.lblOrderFoodToLectureRoom.Name = "lblOrderFoodToLectureRoom";
            this.lblOrderFoodToLectureRoom.Size = new System.Drawing.Size(757, 62);
            this.lblOrderFoodToLectureRoom.TabIndex = 1;
            this.lblOrderFoodToLectureRoom.Text = "Order food to your lecture room.";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(267, 456);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 60);
            this.panel10.TabIndex = 1;
            // 
            // lblCampusFoodReimagined
            // 
            this.lblCampusFoodReimagined.AutoSize = true;
            this.lblCampusFoodReimagined.ForeColor = System.Drawing.Color.Lime;
            this.lblCampusFoodReimagined.Location = new System.Drawing.Point(21, 35);
            this.lblCampusFoodReimagined.Name = "lblCampusFoodReimagined";
            this.lblCampusFoodReimagined.Size = new System.Drawing.Size(239, 23);
            this.lblCampusFoodReimagined.TabIndex = 0;
            this.lblCampusFoodReimagined.Text = "CAMPUS FOOD. REIMAGINED";
            // 
            // pnl1Queueless
            // 
            this.pnl1Queueless.Controls.Add(this.btnCart);
            this.pnl1Queueless.Controls.Add(this.btnHome);
            this.pnl1Queueless.Controls.Add(this.btnOutlets);
            this.pnl1Queueless.Controls.Add(this.btnAdmin);
            this.pnl1Queueless.Controls.Add(this.btnTrackOrder);
            this.pnl1Queueless.Controls.Add(this.lblQueueLess);
            this.pnl1Queueless.Location = new System.Drawing.Point(3, 3);
            this.pnl1Queueless.Name = "pnl1Queueless";
            this.pnl1Queueless.Size = new System.Drawing.Size(1748, 70);
            this.pnl1Queueless.TabIndex = 1;
            // 
            // btnCart
            // 
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Location = new System.Drawing.Point(1450, 20);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(75, 31);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(996, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 31);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnOutlets
            // 
            this.btnOutlets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlets.Location = new System.Drawing.Point(1096, 20);
            this.btnOutlets.Name = "btnOutlets";
            this.btnOutlets.Size = new System.Drawing.Size(75, 31);
            this.btnOutlets.TabIndex = 3;
            this.btnOutlets.Text = "Outlets";
            this.btnOutlets.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Location = new System.Drawing.Point(1349, 20);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 31);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackOrder.Location = new System.Drawing.Point(1207, 20);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(111, 31);
            this.btnTrackOrder.TabIndex = 4;
            this.btnTrackOrder.Text = "Track Order";
            this.btnTrackOrder.UseVisualStyleBackColor = true;
            // 
            // lblQueueLess
            // 
            this.lblQueueLess.AutoSize = true;
            this.lblQueueLess.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueLess.Location = new System.Drawing.Point(3, 6);
            this.lblQueueLess.Name = "lblQueueLess";
            this.lblQueueLess.Size = new System.Drawing.Size(139, 31);
            this.lblQueueLess.TabIndex = 2;
            this.lblQueueLess.Text = "QUEUELESS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnl1Queueless);
            this.flowLayoutPanel1.Controls.Add(this.pnlCampusFoodReimagined);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.pnlQueueLessWorks);
            this.flowLayoutPanel1.Controls.Add(this.pnlPopular);
            this.flowLayoutPanel1.Controls.Add(this.pnlMainScroll);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1779, 1055);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pnlPopular
            // 
            this.pnlPopular.BackColor = System.Drawing.Color.White;
            this.pnlPopular.Controls.Add(this.flpPopularItems);
            this.pnlPopular.Controls.Add(this.lblPopularRightNow);
            this.pnlPopular.Controls.Add(this.btnViewAllOutLets);
            this.pnlPopular.Location = new System.Drawing.Point(3, 1017);
            this.pnlPopular.Name = "pnlPopular";
            this.pnlPopular.Size = new System.Drawing.Size(1200, 320);
            this.pnlPopular.TabIndex = 8;
            // 
            // flpPopularItems
            // 
            this.flpPopularItems.Controls.Add(this.pnlClassicSmashBurger);
            this.flpPopularItems.Controls.Add(this.pnlHarvestGrainBowl);
            this.flpPopularItems.Controls.Add(this.pnlFlatWhiteCroissant);
            this.flpPopularItems.Controls.Add(this.pnlNoodleBox);
            this.flpPopularItems.Location = new System.Drawing.Point(20, 55);
            this.flpPopularItems.Name = "flpPopularItems";
            this.flpPopularItems.Size = new System.Drawing.Size(1000, 250);
            this.flpPopularItems.TabIndex = 1;
            this.flpPopularItems.WrapContents = false;
            // 
            // pnlClassicSmashBurger
            // 
            this.pnlClassicSmashBurger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClassicSmashBurger.Controls.Add(this.btnplus);
            this.pnlClassicSmashBurger.Controls.Add(this.lblClassicSmashBurger);
            this.pnlClassicSmashBurger.Controls.Add(this.lbl89);
            this.pnlClassicSmashBurger.Controls.Add(this.lblCampusGrill);
            this.pnlClassicSmashBurger.Controls.Add(this.lblItemTitle);
            this.pnlClassicSmashBurger.Controls.Add(this.pictureBoxSmashBurger);
            this.pnlClassicSmashBurger.Location = new System.Drawing.Point(0, 0);
            this.pnlClassicSmashBurger.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlClassicSmashBurger.Name = "pnlClassicSmashBurger";
            this.pnlClassicSmashBurger.Size = new System.Drawing.Size(220, 220);
            this.pnlClassicSmashBurger.TabIndex = 0;
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Lime;
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.Color.White;
            this.btnplus.Location = new System.Drawing.Point(168, 180);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(35, 35);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            // 
            // lblClassicSmashBurger
            // 
            this.lblClassicSmashBurger.AutoSize = true;
            this.lblClassicSmashBurger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassicSmashBurger.Location = new System.Drawing.Point(9, 150);
            this.lblClassicSmashBurger.Name = "lblClassicSmashBurger";
            this.lblClassicSmashBurger.Size = new System.Drawing.Size(179, 23);
            this.lblClassicSmashBurger.TabIndex = 2;
            this.lblClassicSmashBurger.Text = "Classic Smash Burger";
            // 
            // lbl89
            // 
            this.lbl89.AutoSize = true;
            this.lbl89.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl89.Location = new System.Drawing.Point(9, 185);
            this.lbl89.Name = "lbl89";
            this.lbl89.Size = new System.Drawing.Size(66, 23);
            this.lbl89.TabIndex = 1;
            this.lbl89.Text = "R89.00";
            // 
            // lblCampusGrill
            // 
            this.lblCampusGrill.AutoSize = true;
            this.lblCampusGrill.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampusGrill.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblCampusGrill.Location = new System.Drawing.Point(45, 132);
            this.lblCampusGrill.Name = "lblCampusGrill";
            this.lblCampusGrill.Size = new System.Drawing.Size(107, 17);
            this.lblCampusGrill.TabIndex = 1;
            this.lblCampusGrill.Text = "The Campus Grill";
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Location = new System.Drawing.Point(4, 132);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(0, 23);
            this.lblItemTitle.TabIndex = 1;
            // 
            // pictureBoxSmashBurger
            // 
            this.pictureBoxSmashBurger.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSmashBurger.Image")));
            this.pictureBoxSmashBurger.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxSmashBurger.Name = "pictureBoxSmashBurger";
            this.pictureBoxSmashBurger.Size = new System.Drawing.Size(220, 120);
            this.pictureBoxSmashBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSmashBurger.TabIndex = 0;
            this.pictureBoxSmashBurger.TabStop = false;
            // 
            // pnlHarvestGrainBowl
            // 
            this.pnlHarvestGrainBowl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHarvestGrainBowl.Controls.Add(this.btnplus1);
            this.pnlHarvestGrainBowl.Controls.Add(this.lblHarvestGrainBowl);
            this.pnlHarvestGrainBowl.Controls.Add(this.lbl65);
            this.pnlHarvestGrainBowl.Controls.Add(this.lblFreshAndGreen);
            this.pnlHarvestGrainBowl.Controls.Add(this.label33);
            this.pnlHarvestGrainBowl.Controls.Add(this.pictureBoxHarvestGrainBowl);
            this.pnlHarvestGrainBowl.Location = new System.Drawing.Point(235, 0);
            this.pnlHarvestGrainBowl.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlHarvestGrainBowl.Name = "pnlHarvestGrainBowl";
            this.pnlHarvestGrainBowl.Size = new System.Drawing.Size(220, 220);
            this.pnlHarvestGrainBowl.TabIndex = 1;
            // 
            // btnplus1
            // 
            this.btnplus1.BackColor = System.Drawing.Color.Lime;
            this.btnplus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus1.ForeColor = System.Drawing.Color.White;
            this.btnplus1.Location = new System.Drawing.Point(175, 180);
            this.btnplus1.Name = "btnplus1";
            this.btnplus1.Size = new System.Drawing.Size(35, 35);
            this.btnplus1.TabIndex = 3;
            this.btnplus1.Text = "+";
            this.btnplus1.UseVisualStyleBackColor = false;
            // 
            // lblHarvestGrainBowl
            // 
            this.lblHarvestGrainBowl.AutoSize = true;
            this.lblHarvestGrainBowl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarvestGrainBowl.Location = new System.Drawing.Point(9, 150);
            this.lblHarvestGrainBowl.Name = "lblHarvestGrainBowl";
            this.lblHarvestGrainBowl.Size = new System.Drawing.Size(165, 23);
            this.lblHarvestGrainBowl.TabIndex = 2;
            this.lblHarvestGrainBowl.Text = "Harvest Grain Bowl";
            // 
            // lbl65
            // 
            this.lbl65.AutoSize = true;
            this.lbl65.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl65.Location = new System.Drawing.Point(9, 185);
            this.lbl65.Name = "lbl65";
            this.lbl65.Size = new System.Drawing.Size(66, 23);
            this.lbl65.TabIndex = 1;
            this.lbl65.Text = "R65.00";
            // 
            // lblFreshAndGreen
            // 
            this.lblFreshAndGreen.AutoSize = true;
            this.lblFreshAndGreen.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreshAndGreen.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblFreshAndGreen.Location = new System.Drawing.Point(45, 132);
            this.lblFreshAndGreen.Name = "lblFreshAndGreen";
            this.lblFreshAndGreen.Size = new System.Drawing.Size(104, 17);
            this.lblFreshAndGreen.TabIndex = 1;
            this.lblFreshAndGreen.Text = "Fresh and Green";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 132);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 23);
            this.label33.TabIndex = 1;
            // 
            // pictureBoxHarvestGrainBowl
            // 
            this.pictureBoxHarvestGrainBowl.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHarvestGrainBowl.Image")));
            this.pictureBoxHarvestGrainBowl.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxHarvestGrainBowl.Name = "pictureBoxHarvestGrainBowl";
            this.pictureBoxHarvestGrainBowl.Size = new System.Drawing.Size(220, 120);
            this.pictureBoxHarvestGrainBowl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHarvestGrainBowl.TabIndex = 0;
            this.pictureBoxHarvestGrainBowl.TabStop = false;
            // 
            // pnlFlatWhiteCroissant
            // 
            this.pnlFlatWhiteCroissant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFlatWhiteCroissant.Controls.Add(this.btnplus2);
            this.pnlFlatWhiteCroissant.Controls.Add(this.lblFlatWhiteCroissant);
            this.pnlFlatWhiteCroissant.Controls.Add(this.lbl48);
            this.pnlFlatWhiteCroissant.Controls.Add(this.lblBrewAndBite);
            this.pnlFlatWhiteCroissant.Controls.Add(this.label37);
            this.pnlFlatWhiteCroissant.Controls.Add(this.pictureBoxFlatWhiteAndCroissant);
            this.pnlFlatWhiteCroissant.Location = new System.Drawing.Point(470, 0);
            this.pnlFlatWhiteCroissant.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlFlatWhiteCroissant.Name = "pnlFlatWhiteCroissant";
            this.pnlFlatWhiteCroissant.Size = new System.Drawing.Size(220, 220);
            this.pnlFlatWhiteCroissant.TabIndex = 2;
            // 
            // btnplus2
            // 
            this.btnplus2.BackColor = System.Drawing.Color.Lime;
            this.btnplus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus2.ForeColor = System.Drawing.Color.White;
            this.btnplus2.Location = new System.Drawing.Point(178, 177);
            this.btnplus2.Name = "btnplus2";
            this.btnplus2.Size = new System.Drawing.Size(35, 35);
            this.btnplus2.TabIndex = 3;
            this.btnplus2.Text = "+";
            this.btnplus2.UseVisualStyleBackColor = false;
            // 
            // lblFlatWhiteCroissant
            // 
            this.lblFlatWhiteCroissant.AutoSize = true;
            this.lblFlatWhiteCroissant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatWhiteCroissant.Location = new System.Drawing.Point(9, 150);
            this.lblFlatWhiteCroissant.Name = "lblFlatWhiteCroissant";
            this.lblFlatWhiteCroissant.Size = new System.Drawing.Size(206, 23);
            this.lblFlatWhiteCroissant.TabIndex = 2;
            this.lblFlatWhiteCroissant.Text = "Flat White and Croissant";
            // 
            // lbl48
            // 
            this.lbl48.AutoSize = true;
            this.lbl48.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl48.Location = new System.Drawing.Point(9, 185);
            this.lbl48.Name = "lbl48";
            this.lbl48.Size = new System.Drawing.Size(66, 23);
            this.lbl48.TabIndex = 1;
            this.lbl48.Text = "R48.00";
            // 
            // lblBrewAndBite
            // 
            this.lblBrewAndBite.AutoSize = true;
            this.lblBrewAndBite.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrewAndBite.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblBrewAndBite.Location = new System.Drawing.Point(45, 132);
            this.lblBrewAndBite.Name = "lblBrewAndBite";
            this.lblBrewAndBite.Size = new System.Drawing.Size(87, 17);
            this.lblBrewAndBite.TabIndex = 1;
            this.lblBrewAndBite.Text = "Brew and Bite";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 132);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(0, 23);
            this.label37.TabIndex = 1;
            // 
            // pictureBoxFlatWhiteAndCroissant
            // 
            this.pictureBoxFlatWhiteAndCroissant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlatWhiteAndCroissant.Image")));
            this.pictureBoxFlatWhiteAndCroissant.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxFlatWhiteAndCroissant.Name = "pictureBoxFlatWhiteAndCroissant";
            this.pictureBoxFlatWhiteAndCroissant.Size = new System.Drawing.Size(220, 120);
            this.pictureBoxFlatWhiteAndCroissant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlatWhiteAndCroissant.TabIndex = 0;
            this.pictureBoxFlatWhiteAndCroissant.TabStop = false;
            // 
            // pnlNoodleBox
            // 
            this.pnlNoodleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNoodleBox.Controls.Add(this.btnplus3);
            this.pnlNoodleBox.Controls.Add(this.lblNoodleBox);
            this.pnlNoodleBox.Controls.Add(this.lbl75);
            this.pnlNoodleBox.Controls.Add(this.lblNoodleHouse);
            this.pnlNoodleBox.Controls.Add(this.label41);
            this.pnlNoodleBox.Controls.Add(this.pictureBoxNoodleBox);
            this.pnlNoodleBox.Location = new System.Drawing.Point(705, 0);
            this.pnlNoodleBox.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlNoodleBox.Name = "pnlNoodleBox";
            this.pnlNoodleBox.Size = new System.Drawing.Size(220, 220);
            this.pnlNoodleBox.TabIndex = 3;
            // 
            // btnplus3
            // 
            this.btnplus3.BackColor = System.Drawing.Color.Lime;
            this.btnplus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus3.ForeColor = System.Drawing.Color.White;
            this.btnplus3.Location = new System.Drawing.Point(180, 180);
            this.btnplus3.Name = "btnplus3";
            this.btnplus3.Size = new System.Drawing.Size(35, 35);
            this.btnplus3.TabIndex = 4;
            this.btnplus3.Text = "+";
            this.btnplus3.UseVisualStyleBackColor = false;
            // 
            // lblNoodleBox
            // 
            this.lblNoodleBox.AutoSize = true;
            this.lblNoodleBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoodleBox.Location = new System.Drawing.Point(9, 150);
            this.lblNoodleBox.Name = "lblNoodleBox";
            this.lblNoodleBox.Size = new System.Drawing.Size(170, 23);
            this.lblNoodleBox.TabIndex = 2;
            this.lblNoodleBox.Text = "Teriyaki Noodle Box";
            // 
            // lbl75
            // 
            this.lbl75.AutoSize = true;
            this.lbl75.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl75.Location = new System.Drawing.Point(9, 185);
            this.lbl75.Name = "lbl75";
            this.lbl75.Size = new System.Drawing.Size(66, 23);
            this.lbl75.TabIndex = 1;
            this.lbl75.Text = "R75.00";
            // 
            // lblNoodleHouse
            // 
            this.lblNoodleHouse.AutoSize = true;
            this.lblNoodleHouse.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoodleHouse.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblNoodleHouse.Location = new System.Drawing.Point(45, 132);
            this.lblNoodleHouse.Name = "lblNoodleHouse";
            this.lblNoodleHouse.Size = new System.Drawing.Size(93, 17);
            this.lblNoodleHouse.TabIndex = 1;
            this.lblNoodleHouse.Text = "Noodle House";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 132);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(0, 23);
            this.label41.TabIndex = 1;
            // 
            // pictureBoxNoodleBox
            // 
            this.pictureBoxNoodleBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNoodleBox.Image")));
            this.pictureBoxNoodleBox.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxNoodleBox.Name = "pictureBoxNoodleBox";
            this.pictureBoxNoodleBox.Size = new System.Drawing.Size(220, 120);
            this.pictureBoxNoodleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNoodleBox.TabIndex = 0;
            this.pictureBoxNoodleBox.TabStop = false;
            // 
            // lblPopularRightNow
            // 
            this.lblPopularRightNow.AutoSize = true;
            this.lblPopularRightNow.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularRightNow.Location = new System.Drawing.Point(20, 15);
            this.lblPopularRightNow.Name = "lblPopularRightNow";
            this.lblPopularRightNow.Size = new System.Drawing.Size(266, 38);
            this.lblPopularRightNow.TabIndex = 0;
            this.lblPopularRightNow.Text = "Popular Right Now";
            // 
            // btnViewAllOutLets
            // 
            this.btnViewAllOutLets.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnViewAllOutLets.Location = new System.Drawing.Point(1033, 18);
            this.btnViewAllOutLets.Name = "btnViewAllOutLets";
            this.btnViewAllOutLets.Size = new System.Drawing.Size(138, 35);
            this.btnViewAllOutLets.TabIndex = 1;
            this.btnViewAllOutLets.Text = "View All Outlets";
            this.btnViewAllOutLets.UseVisualStyleBackColor = true;
            // 
            // pnlMainScroll
            // 
            this.pnlMainScroll.AutoScroll = true;
            this.pnlMainScroll.AutoScrollMinSize = new System.Drawing.Size(1100, 2500);
            this.pnlMainScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainScroll.Location = new System.Drawing.Point(3, 1343);
            this.pnlMainScroll.Name = "pnlMainScroll";
            this.pnlMainScroll.Size = new System.Drawing.Size(1920, 350);
            this.pnlMainScroll.TabIndex = 9;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
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
            this.pnlForgotPassword.ResumeLayout(false);
            this.pnlForgotPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1779, 1055);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.pnlQueueLessWorks.ResumeLayout(false);
            this.pnlHowItWorks.ResumeLayout(false);
            this.pnlHowItWorks.PerformLayout();
            this.pnlPreorderCard.ResumeLayout(false);
            this.pnlPreorderCard.PerformLayout();
            this.pnlDeliverCard.ResumeLayout(false);
            this.pnlDeliverCard.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flpStatsRow.ResumeLayout(false);
            this.pnlCampusOutlest.ResumeLayout(false);
            this.pnlCampusOutlest.PerformLayout();
            this.pnlDeliveryTime.ResumeLayout(false);
            this.pnlDeliveryTime.PerformLayout();
            this.pnlStudentsStaff.ResumeLayout(false);
            this.pnlStudentsStaff.PerformLayout();
            this.pnl0Queue.ResumeLayout(false);
            this.pnl0Queue.PerformLayout();
            this.pnlCampusFoodReimagined.ResumeLayout(false);
            this.pnlCampusFoodReimagined.PerformLayout();
            this.pnlPreOrder.ResumeLayout(false);
            this.pnlPreOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlighting)).EndInit();
            this.pnlDeliver.ResumeLayout(false);
            this.pnlDeliver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).EndInit();
            this.pnl8MinWait.ResumeLayout(false);
            this.pnl8MinWait.PerformLayout();
            this.pnlOrderReady.ResumeLayout(false);
            this.pnlOrderReady.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBurger)).EndInit();
            this.pnl1Queueless.ResumeLayout(false);
            this.pnl1Queueless.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlPopular.ResumeLayout(false);
            this.pnlPopular.PerformLayout();
            this.flpPopularItems.ResumeLayout(false);
            this.pnlClassicSmashBurger.ResumeLayout(false);
            this.pnlClassicSmashBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmashBurger)).EndInit();
            this.pnlHarvestGrainBowl.ResumeLayout(false);
            this.pnlHarvestGrainBowl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarvestGrainBowl)).EndInit();
            this.pnlFlatWhiteCroissant.ResumeLayout(false);
            this.pnlFlatWhiteCroissant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlatWhiteAndCroissant)).EndInit();
            this.pnlNoodleBox.ResumeLayout(false);
            this.pnlNoodleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoodleBox)).EndInit();
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
        private System.Windows.Forms.Panel pnlForgotPassword;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtForgotEmail;
        private System.Windows.Forms.Label lblPasswordUpdate;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBacktoLogin;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblForgotPasswordError;

        private System.Windows.Forms.Panel pnlQueueLessWorks;
        private System.Windows.Forms.Panel pnlHowItWorks;
        private System.Windows.Forms.Panel pnlPreorderCard;
        private System.Windows.Forms.Label lblThreeInfo;
        private System.Windows.Forms.Label lblTwoInfo;
        private System.Windows.Forms.Label lblOneInfo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblPreOrderAndCollcetInfo;
        private System.Windows.Forms.Label lblCollect;
        private System.Windows.Forms.Panel pnlDeliverCard;
        private System.Windows.Forms.Label lblFoodArrivesAtYourSeat;
        private System.Windows.Forms.Label lblPickYourCampusLocation;
        private System.Windows.Forms.Label lblChooseYourOutletsItems;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblDeliverToMyLocationExplaination;
        private System.Windows.Forms.Label lblDeliverToMyLocation;
        private System.Windows.Forms.Label lblWorksSub;
        private System.Windows.Forms.Label lblWorksTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel pnlCampusFoodReimagined;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnFindFood;
        private System.Windows.Forms.ComboBox cmbSelectDeliveryLocation;
        private System.Windows.Forms.Label lblOrderFoodToLectureRoom;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblCampusFoodReimagined;
        private System.Windows.Forms.Panel pnl1Queueless;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOutlets;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnTrackOrder;
        private System.Windows.Forms.Label lblQueueLess;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlPopular;
        private System.Windows.Forms.Label lblPopularRightNow;
        private System.Windows.Forms.FlowLayoutPanel flpPopularItems;
        private System.Windows.Forms.Panel pnlClassicSmashBurger;
        private System.Windows.Forms.PictureBox pictureBoxSmashBurger;
        private System.Windows.Forms.Label lblClassicSmashBurger;
        private System.Windows.Forms.Label lblItemTitle;
        private System.Windows.Forms.Label lblCampusGrill;
        private System.Windows.Forms.Label lbl89;
        private System.Windows.Forms.Panel pnlHarvestGrainBowl;
        private System.Windows.Forms.Label lblHarvestGrainBowl;
        private System.Windows.Forms.Label lbl65;
        private System.Windows.Forms.Label lblFreshAndGreen;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.PictureBox pictureBoxHarvestGrainBowl;
        private System.Windows.Forms.Panel pnlFlatWhiteCroissant;
        private System.Windows.Forms.Label lblFlatWhiteCroissant;
        private System.Windows.Forms.Label lbl48;
        private System.Windows.Forms.Label lblBrewAndBite;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.PictureBox pictureBoxFlatWhiteAndCroissant;
        private System.Windows.Forms.Panel pnlNoodleBox;
        private System.Windows.Forms.Label lblNoodleBox;
        private System.Windows.Forms.Label lbl75;
        private System.Windows.Forms.Label lblNoodleHouse;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox pictureBoxNoodleBox;
        private System.Windows.Forms.Panel pnlMainScroll;
        private System.Windows.Forms.FlowLayoutPanel flpStatsRow;
        private System.Windows.Forms.Panel pnlCampusOutlest;
        private System.Windows.Forms.Label lblCampusOutlets;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Panel pnlDeliveryTime;
        private System.Windows.Forms.Label lblAverageDeliveryTime;
        private System.Windows.Forms.Label lbl8Min;
        private System.Windows.Forms.Panel pnlStudentsStaff;
        private System.Windows.Forms.Label lblstudentsAndStaff;
        private System.Windows.Forms.Label lbl5000;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnplus1;
        private System.Windows.Forms.Button btnplus2;
        private System.Windows.Forms.Button btnplus3;
        private System.Windows.Forms.PictureBox pictureBoxBurger;
        private System.Windows.Forms.Panel pnlOrderReady;
        private System.Windows.Forms.PictureBox pictureBoxCheckMark;
        private System.Windows.Forms.Label lblLectureRoomA101;
        private System.Windows.Forms.Label lblOrderReady;
        private System.Windows.Forms.Panel pnl8MinWait;
        private System.Windows.Forms.Label lblMinWait;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Panel pnl0Queue;
        private System.Windows.Forms.Label lblPreOrder;
        private System.Windows.Forms.Label lbl0Queue;
        private System.Windows.Forms.Label lblGetFood;
        private System.Windows.Forms.Panel pnlPreOrder;
        private System.Windows.Forms.PictureBox pictureBoxlighting;
        private System.Windows.Forms.Label lblPreOrderAndCollectExplaination;
        private System.Windows.Forms.Label lblPreOrderAndCollect;
        private System.Windows.Forms.Panel pnlDeliver;
        private System.Windows.Forms.Label lblDeliverExplanation;
        private System.Windows.Forms.Label lblDeliverToRoom;
        private System.Windows.Forms.PictureBox pictureBoxBuilding;
        private System.Windows.Forms.Button btnViewAllOutLets;
    }
}

