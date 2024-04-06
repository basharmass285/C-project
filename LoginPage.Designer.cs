namespace Endproject_
{
    partial class LoginPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TitlePanel = new Panel();
            panelLoding = new Panel();
            progressBar = new ProgressBar();
            btnLogin = new Button();
            signupbtn = new Button();
            panelLogo = new Panel();
            LogoLabel = new Label();
            LoginPanel = new Panel();
            Student = new Guna.UI2.WinForms.Guna2CheckBox();
            Lecturer = new Guna.UI2.WinForms.Guna2CheckBox();
            ErrorLabel = new Label();
            panelsignup = new Panel();
            panel14 = new Panel();
            Course1Box = new TextBox();
            panel15 = new Panel();
            panel12 = new Panel();
            Course2Box = new TextBox();
            panel13 = new Panel();
            panel10 = new Panel();
            EmployeeNumberbox = new TextBox();
            panel11 = new Panel();
            specializationlabel = new Label();
            specializationCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            panel3 = new Panel();
            Idtext = new TextBox();
            panel8 = new Panel();
            panelphone = new Panel();
            Phonetext = new TextBox();
            panel5 = new Panel();
            Selectpic = new PictureBox();
            Emptymessage = new Label();
            panel1 = new Panel();
            lastnametxt = new TextBox();
            panel2 = new Panel();
            panelSignUpBtn = new Panel();
            btnsign = new Button();
            panelenteremail = new Panel();
            textEmail = new TextBox();
            panel6 = new Panel();
            panelenterphone = new Panel();
            passtxt = new TextBox();
            panel4 = new Panel();
            panelenterpass = new Panel();
            confirmtxt = new TextBox();
            panel7 = new Panel();
            panelenteruser = new Panel();
            Firstname = new TextBox();
            panel9 = new Panel();
            panelPic = new Panel();
            picpassword = new PictureBox();
            picprofile = new PictureBox();
            PanelLogin = new Panel();
            LoginBtn = new Button();
            Panelpassword = new Panel();
            TextPassword = new TextBox();
            paneltextapss = new Panel();
            panelusername = new Panel();
            TextUsername = new TextBox();
            paneltextuser = new Panel();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            TitlePanel.SuspendLayout();
            panelLoding.SuspendLayout();
            panelLogo.SuspendLayout();
            LoginPanel.SuspendLayout();
            panelsignup.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panelphone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Selectpic).BeginInit();
            panel1.SuspendLayout();
            panelSignUpBtn.SuspendLayout();
            panelenteremail.SuspendLayout();
            panelenterphone.SuspendLayout();
            panelenterpass.SuspendLayout();
            panelenteruser.SuspendLayout();
            panelPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picpassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picprofile).BeginInit();
            PanelLogin.SuspendLayout();
            Panelpassword.SuspendLayout();
            panelusername.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.FromArgb(51, 51, 76);
            TitlePanel.Controls.Add(panelLoding);
            TitlePanel.Controls.Add(btnLogin);
            TitlePanel.Controls.Add(signupbtn);
            TitlePanel.Controls.Add(panelLogo);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1179, 93);
            TitlePanel.TabIndex = 0;
            // 
            // panelLoding
            // 
            panelLoding.Controls.Add(progressBar);
            panelLoding.Location = new Point(366, 3);
            panelLoding.Name = "panelLoding";
            panelLoding.Size = new Size(499, 87);
            panelLoding.TabIndex = 23;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.Lime;
            progressBar.Location = new Point(98, 41);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(281, 23);
            progressBar.TabIndex = 29;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Call Of Ops Duty", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaption;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(366, 28);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 59);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // signupbtn
            // 
            signupbtn.FlatStyle = FlatStyle.Flat;
            signupbtn.Font = new Font("Call Of Ops Duty", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            signupbtn.ForeColor = SystemColors.ActiveCaption;
            signupbtn.Image = (Image)resources.GetObject("signupbtn.Image");
            signupbtn.ImageAlign = ContentAlignment.MiddleLeft;
            signupbtn.Location = new Point(614, 28);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(239, 59);
            signupbtn.TabIndex = 21;
            signupbtn.Text = "SignUp";
            signupbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += signupbtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(LogoLabel);
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(189, 93);
            panelLogo.TabIndex = 0;
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Old English Text MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogoLabel.ForeColor = Color.AliceBlue;
            LogoLabel.Location = new Point(30, 31);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(132, 26);
            LogoLabel.TabIndex = 4;
            LogoLabel.Text = "BS-university";
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(30, 30, 30);
            LoginPanel.Controls.Add(Student);
            LoginPanel.Controls.Add(Lecturer);
            LoginPanel.Controls.Add(ErrorLabel);
            LoginPanel.Controls.Add(panelsignup);
            LoginPanel.Controls.Add(panelPic);
            LoginPanel.Controls.Add(PanelLogin);
            LoginPanel.Controls.Add(Panelpassword);
            LoginPanel.Controls.Add(panelusername);
            LoginPanel.ForeColor = Color.FromArgb(100, 0, 0);
            LoginPanel.Location = new Point(0, 93);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(1179, 509);
            LoginPanel.TabIndex = 1;
            LoginPanel.Paint += LoginPanel_Paint;
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Student.CheckedState.BorderRadius = 0;
            Student.CheckedState.BorderThickness = 0;
            Student.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Student.Font = new Font("Segoe UI", 8.142858F, FontStyle.Bold, GraphicsUnit.Point);
            Student.ForeColor = Color.Gray;
            Student.Location = new Point(633, 265);
            Student.Name = "Student";
            Student.Size = new Size(118, 32);
            Student.TabIndex = 32;
            Student.Text = "Student ";
            Student.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Student.UncheckedState.BorderRadius = 0;
            Student.UncheckedState.BorderThickness = 0;
            Student.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Student.CheckedChanged += Student_CheckedChanged;
            // 
            // Lecturer
            // 
            Lecturer.AutoSize = true;
            Lecturer.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Lecturer.CheckedState.BorderRadius = 0;
            Lecturer.CheckedState.BorderThickness = 0;
            Lecturer.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Lecturer.Font = new Font("Segoe UI", 8.142858F, FontStyle.Bold, GraphicsUnit.Point);
            Lecturer.ForeColor = Color.Gray;
            Lecturer.Location = new Point(437, 265);
            Lecturer.Name = "Lecturer";
            Lecturer.Size = new Size(116, 32);
            Lecturer.TabIndex = 31;
            Lecturer.Text = "Lecturer";
            Lecturer.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Lecturer.UncheckedState.BorderRadius = 0;
            Lecturer.UncheckedState.BorderThickness = 0;
            Lecturer.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Lecturer.CheckedChanged += Lecturer_CheckedChanged;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(430, 48);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(315, 30);
            ErrorLabel.TabIndex = 28;
            ErrorLabel.Text = "Please Enter Email and Password";
            // 
            // panelsignup
            // 
            panelsignup.Controls.Add(panel14);
            panelsignup.Controls.Add(panel12);
            panelsignup.Controls.Add(panel10);
            panelsignup.Controls.Add(specializationlabel);
            panelsignup.Controls.Add(specializationCombo);
            panelsignup.Controls.Add(panel3);
            panelsignup.Controls.Add(panelphone);
            panelsignup.Controls.Add(Selectpic);
            panelsignup.Controls.Add(Emptymessage);
            panelsignup.Controls.Add(panel1);
            panelsignup.Controls.Add(panelSignUpBtn);
            panelsignup.Controls.Add(panelenteremail);
            panelsignup.Controls.Add(panelenterphone);
            panelsignup.Controls.Add(panelenterpass);
            panelsignup.Controls.Add(panelenteruser);
            panelsignup.Location = new Point(0, 3);
            panelsignup.Name = "panelsignup";
            panelsignup.Size = new Size(1179, 503);
            panelsignup.TabIndex = 17;
            // 
            // panel14
            // 
            panel14.Controls.Add(Course1Box);
            panel14.Controls.Add(panel15);
            panel14.Location = new Point(12, 195);
            panel14.Name = "panel14";
            panel14.Size = new Size(305, 49);
            panel14.TabIndex = 23;
            // 
            // Course1Box
            // 
            Course1Box.BackColor = Color.FromArgb(30, 30, 30);
            Course1Box.BorderStyle = BorderStyle.None;
            Course1Box.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Course1Box.ForeColor = Color.Gray;
            Course1Box.Location = new Point(6, 11);
            Course1Box.Name = "Course1Box";
            Course1Box.PlaceholderText = "Course2";
            Course1Box.Size = new Size(239, 32);
            Course1Box.TabIndex = 3;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.Location = new Point(6, 43);
            panel15.Name = "panel15";
            panel15.Size = new Size(502, 3);
            panel15.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.Controls.Add(Course2Box);
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(12, 143);
            panel12.Name = "panel12";
            panel12.Size = new Size(305, 49);
            panel12.TabIndex = 23;
            // 
            // Course2Box
            // 
            Course2Box.BackColor = Color.FromArgb(30, 30, 30);
            Course2Box.BorderStyle = BorderStyle.None;
            Course2Box.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Course2Box.ForeColor = Color.Gray;
            Course2Box.Location = new Point(6, 11);
            Course2Box.Name = "Course2Box";
            Course2Box.PlaceholderText = "Course1";
            Course2Box.Size = new Size(239, 32);
            Course2Box.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Location = new Point(6, 43);
            panel13.Name = "panel13";
            panel13.Size = new Size(502, 3);
            panel13.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(EmployeeNumberbox);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(12, 259);
            panel10.Name = "panel10";
            panel10.Size = new Size(305, 49);
            panel10.TabIndex = 22;
            // 
            // EmployeeNumberbox
            // 
            EmployeeNumberbox.BackColor = Color.FromArgb(30, 30, 30);
            EmployeeNumberbox.BorderStyle = BorderStyle.None;
            EmployeeNumberbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeNumberbox.ForeColor = Color.Gray;
            EmployeeNumberbox.Location = new Point(6, 11);
            EmployeeNumberbox.Name = "EmployeeNumberbox";
            EmployeeNumberbox.PlaceholderText = "Employee Number";
            EmployeeNumberbox.Size = new Size(239, 32);
            EmployeeNumberbox.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(6, 43);
            panel11.Name = "panel11";
            panel11.Size = new Size(502, 3);
            panel11.TabIndex = 5;
            // 
            // specializationlabel
            // 
            specializationlabel.AutoSize = true;
            specializationlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            specializationlabel.ForeColor = Color.White;
            specializationlabel.Location = new Point(119, 45);
            specializationlabel.Name = "specializationlabel";
            specializationlabel.Size = new Size(149, 30);
            specializationlabel.TabIndex = 30;
            specializationlabel.Text = "Specialization";
            // 
            // specializationCombo
            // 
            specializationCombo.BackColor = Color.FromArgb(30, 30, 30);
            specializationCombo.CustomizableEdges = customizableEdges1;
            specializationCombo.DrawMode = DrawMode.OwnerDrawFixed;
            specializationCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            specializationCombo.FillColor = Color.FromArgb(30, 30, 30);
            specializationCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            specializationCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            specializationCombo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            specializationCombo.ForeColor = Color.White;
            specializationCombo.ItemHeight = 30;
            specializationCombo.Location = new Point(12, 90);
            specializationCombo.Name = "specializationCombo";
            specializationCombo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            specializationCombo.Size = new Size(305, 36);
            specializationCombo.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.Controls.Add(Idtext);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(606, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 49);
            panel3.TabIndex = 22;
            // 
            // Idtext
            // 
            Idtext.BackColor = Color.FromArgb(30, 30, 30);
            Idtext.BorderStyle = BorderStyle.None;
            Idtext.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Idtext.ForeColor = Color.Gray;
            Idtext.Location = new Point(6, 11);
            Idtext.Name = "Idtext";
            Idtext.PlaceholderText = "Enter ID";
            Idtext.Size = new Size(228, 32);
            Idtext.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(6, 43);
            panel8.Name = "panel8";
            panel8.Size = new Size(502, 3);
            panel8.TabIndex = 5;
            // 
            // panelphone
            // 
            panelphone.Controls.Add(Phonetext);
            panelphone.Controls.Add(panel5);
            panelphone.Location = new Point(343, 195);
            panelphone.Name = "panelphone";
            panelphone.Size = new Size(237, 49);
            panelphone.TabIndex = 21;
            // 
            // Phonetext
            // 
            Phonetext.BackColor = Color.FromArgb(30, 30, 30);
            Phonetext.BorderStyle = BorderStyle.None;
            Phonetext.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Phonetext.ForeColor = Color.Gray;
            Phonetext.Location = new Point(6, 11);
            Phonetext.Name = "Phonetext";
            Phonetext.PlaceholderText = "Enter phone";
            Phonetext.Size = new Size(228, 32);
            Phonetext.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(6, 43);
            panel5.Name = "panel5";
            panel5.Size = new Size(502, 3);
            panel5.TabIndex = 5;
            // 
            // Selectpic
            // 
            Selectpic.BorderStyle = BorderStyle.Fixed3D;
            Selectpic.Location = new Point(899, 91);
            Selectpic.Name = "Selectpic";
            Selectpic.Size = new Size(175, 191);
            Selectpic.SizeMode = PictureBoxSizeMode.Zoom;
            Selectpic.TabIndex = 28;
            Selectpic.TabStop = false;
            Selectpic.Click += Selectpic_Click;
            // 
            // Emptymessage
            // 
            Emptymessage.AutoSize = true;
            Emptymessage.ForeColor = Color.Red;
            Emptymessage.Location = new Point(384, 15);
            Emptymessage.Name = "Emptymessage";
            Emptymessage.Size = new Size(418, 30);
            Emptymessage.TabIndex = 27;
            Emptymessage.Text = "The fields are empty, please fill in the fields.";
            // 
            // panel1
            // 
            panel1.Controls.Add(lastnametxt);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(606, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 49);
            panel1.TabIndex = 20;
            // 
            // lastnametxt
            // 
            lastnametxt.BackColor = Color.FromArgb(30, 30, 30);
            lastnametxt.BorderStyle = BorderStyle.None;
            lastnametxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastnametxt.ForeColor = Color.Gray;
            lastnametxt.Location = new Point(6, 11);
            lastnametxt.Name = "lastnametxt";
            lastnametxt.PlaceholderText = "Enter Lastname";
            lastnametxt.Size = new Size(228, 32);
            lastnametxt.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(6, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 3);
            panel2.TabIndex = 5;
            // 
            // panelSignUpBtn
            // 
            panelSignUpBtn.Controls.Add(btnsign);
            panelSignUpBtn.Location = new Point(399, 372);
            panelSignUpBtn.Name = "panelSignUpBtn";
            panelSignUpBtn.Size = new Size(350, 81);
            panelSignUpBtn.TabIndex = 24;
            // 
            // btnsign
            // 
            btnsign.FlatAppearance.BorderColor = Color.Lime;
            btnsign.FlatAppearance.BorderSize = 2;
            btnsign.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnsign.FlatStyle = FlatStyle.Flat;
            btnsign.ForeColor = Color.Lime;
            btnsign.Location = new Point(3, 13);
            btnsign.Name = "btnsign";
            btnsign.Size = new Size(344, 54);
            btnsign.TabIndex = 15;
            btnsign.Text = "Sign Up";
            btnsign.UseVisualStyleBackColor = true;
            btnsign.Click += btnsign_Click;
            // 
            // panelenteremail
            // 
            panelenteremail.Controls.Add(textEmail);
            panelenteremail.Controls.Add(panel6);
            panelenteremail.Location = new Point(343, 135);
            panelenteremail.Name = "panelenteremail";
            panelenteremail.Size = new Size(511, 49);
            panelenteremail.TabIndex = 20;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(30, 30, 30);
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textEmail.ForeColor = Color.Gray;
            textEmail.Location = new Point(6, 11);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Enter Email";
            textEmail.Size = new Size(502, 32);
            textEmail.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(6, 43);
            panel6.Name = "panel6";
            panel6.Size = new Size(502, 3);
            panel6.TabIndex = 5;
            // 
            // panelenterphone
            // 
            panelenterphone.Controls.Add(passtxt);
            panelenterphone.Controls.Add(panel4);
            panelenterphone.Location = new Point(343, 259);
            panelenterphone.Name = "panelenterphone";
            panelenterphone.Size = new Size(237, 49);
            panelenterphone.TabIndex = 21;
            // 
            // passtxt
            // 
            passtxt.BackColor = Color.FromArgb(30, 30, 30);
            passtxt.BorderStyle = BorderStyle.None;
            passtxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passtxt.ForeColor = Color.Gray;
            passtxt.Location = new Point(6, 11);
            passtxt.Name = "passtxt";
            passtxt.PasswordChar = '*';
            passtxt.PlaceholderText = "Enter Password";
            passtxt.Size = new Size(228, 32);
            passtxt.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(6, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(502, 3);
            panel4.TabIndex = 5;
            // 
            // panelenterpass
            // 
            panelenterpass.Controls.Add(confirmtxt);
            panelenterpass.Controls.Add(panel7);
            panelenterpass.Location = new Point(606, 259);
            panelenterpass.Name = "panelenterpass";
            panelenterpass.Size = new Size(248, 49);
            panelenterpass.TabIndex = 22;
            // 
            // confirmtxt
            // 
            confirmtxt.BackColor = Color.FromArgb(30, 30, 30);
            confirmtxt.BorderStyle = BorderStyle.None;
            confirmtxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            confirmtxt.ForeColor = Color.Gray;
            confirmtxt.Location = new Point(6, 11);
            confirmtxt.Name = "confirmtxt";
            confirmtxt.PasswordChar = '*';
            confirmtxt.PlaceholderText = "Confirm password";
            confirmtxt.Size = new Size(239, 32);
            confirmtxt.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(6, 43);
            panel7.Name = "panel7";
            panel7.Size = new Size(502, 3);
            panel7.TabIndex = 5;
            // 
            // panelenteruser
            // 
            panelenteruser.Controls.Add(Firstname);
            panelenteruser.Controls.Add(panel9);
            panelenteruser.Location = new Point(343, 78);
            panelenteruser.Name = "panelenteruser";
            panelenteruser.Size = new Size(237, 49);
            panelenteruser.TabIndex = 19;
            // 
            // Firstname
            // 
            Firstname.BackColor = Color.FromArgb(30, 30, 30);
            Firstname.BorderStyle = BorderStyle.None;
            Firstname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Firstname.ForeColor = Color.Gray;
            Firstname.Location = new Point(6, 11);
            Firstname.Name = "Firstname";
            Firstname.PlaceholderText = "Enter Firstname";
            Firstname.Size = new Size(228, 32);
            Firstname.TabIndex = 3;
            Firstname.TextChanged += Firstname_TextChanged;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(6, 43);
            panel9.Name = "panel9";
            panel9.Size = new Size(502, 3);
            panel9.TabIndex = 5;
            // 
            // panelPic
            // 
            panelPic.Controls.Add(picpassword);
            panelPic.Controls.Add(picprofile);
            panelPic.Location = new Point(298, 116);
            panelPic.Name = "panelPic";
            panelPic.Size = new Size(68, 143);
            panelPic.TabIndex = 16;
            panelPic.Paint += panelPic_Paint;
            // 
            // picpassword
            // 
            picpassword.Image = (Image)resources.GetObject("picpassword.Image");
            picpassword.Location = new Point(2, 92);
            picpassword.Name = "picpassword";
            picpassword.Size = new Size(63, 51);
            picpassword.SizeMode = PictureBoxSizeMode.CenterImage;
            picpassword.TabIndex = 18;
            picpassword.TabStop = false;
            picpassword.Click += picpassword_Click;
            // 
            // picprofile
            // 
            picprofile.Image = (Image)resources.GetObject("picprofile.Image");
            picprofile.Location = new Point(3, 3);
            picprofile.Name = "picprofile";
            picprofile.Size = new Size(62, 48);
            picprofile.SizeMode = PictureBoxSizeMode.CenterImage;
            picprofile.TabIndex = 17;
            picprofile.TabStop = false;
            picprofile.Click += picprofile_Click;
            // 
            // PanelLogin
            // 
            PanelLogin.Controls.Add(LoginBtn);
            PanelLogin.Location = new Point(426, 328);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(347, 62);
            PanelLogin.TabIndex = 15;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatAppearance.BorderColor = Color.Lime;
            LoginBtn.FlatAppearance.BorderSize = 2;
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.ForeColor = Color.Lime;
            LoginBtn.Location = new Point(0, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(344, 54);
            LoginBtn.TabIndex = 14;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Panelpassword
            // 
            Panelpassword.Controls.Add(TextPassword);
            Panelpassword.Controls.Add(paneltextapss);
            Panelpassword.Location = new Point(366, 208);
            Panelpassword.Name = "Panelpassword";
            Panelpassword.Size = new Size(502, 51);
            Panelpassword.TabIndex = 7;
            // 
            // TextPassword
            // 
            TextPassword.BackColor = Color.FromArgb(30, 30, 30);
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.ForeColor = Color.Gray;
            TextPassword.Location = new Point(3, 13);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '*';
            TextPassword.PlaceholderText = "Enter Password";
            TextPassword.Size = new Size(496, 32);
            TextPassword.TabIndex = 6;
            TextPassword.TextChanged += TextPassword_TextChanged;
            // 
            // paneltextapss
            // 
            paneltextapss.BackColor = Color.White;
            paneltextapss.Location = new Point(0, 45);
            paneltextapss.Name = "paneltextapss";
            paneltextapss.Size = new Size(502, 3);
            paneltextapss.TabIndex = 4;
            // 
            // panelusername
            // 
            panelusername.Controls.Add(TextUsername);
            panelusername.Controls.Add(paneltextuser);
            panelusername.Location = new Point(369, 116);
            panelusername.Name = "panelusername";
            panelusername.Size = new Size(502, 51);
            panelusername.TabIndex = 5;
            // 
            // TextUsername
            // 
            TextUsername.BackColor = Color.FromArgb(30, 30, 30);
            TextUsername.BorderStyle = BorderStyle.None;
            TextUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TextUsername.ForeColor = Color.Gray;
            TextUsername.Location = new Point(3, 13);
            TextUsername.Name = "TextUsername";
            TextUsername.PlaceholderText = "Enter Email";
            TextUsername.Size = new Size(496, 32);
            TextUsername.TabIndex = 6;
            TextUsername.TextChanged += TextUsername_TextChanged;
            // 
            // paneltextuser
            // 
            paneltextuser.BackColor = Color.White;
            paneltextuser.Location = new Point(0, 45);
            paneltextuser.Name = "paneltextuser";
            paneltextuser.Size = new Size(502, 3);
            paneltextuser.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 602);
            Controls.Add(LoginPanel);
            Controls.Add(TitlePanel);
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            TitlePanel.ResumeLayout(false);
            panelLoding.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            panelsignup.ResumeLayout(false);
            panelsignup.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelphone.ResumeLayout(false);
            panelphone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Selectpic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSignUpBtn.ResumeLayout(false);
            panelenteremail.ResumeLayout(false);
            panelenteremail.PerformLayout();
            panelenterphone.ResumeLayout(false);
            panelenterphone.PerformLayout();
            panelenterpass.ResumeLayout(false);
            panelenterpass.PerformLayout();
            panelenteruser.ResumeLayout(false);
            panelenteruser.PerformLayout();
            panelPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picpassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picprofile).EndInit();
            PanelLogin.ResumeLayout(false);
            Panelpassword.ResumeLayout(false);
            Panelpassword.PerformLayout();
            panelusername.ResumeLayout(false);
            panelusername.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Panel panelLogo;
        private Label LogoLabel;
        private Panel LoginPanel;
        private Panel panelusername;
        private Panel paneltextuser;
        private Button LoginBtn;
        private Panel Panelpassword;
        private TextBox TextPassword;
        private Panel paneltextapss;
        private TextBox TextUsername;
        private Panel PanelLogin;
        private Button signupbtn;
        private Panel panelPic;
        private PictureBox picpassword;
        private PictureBox picprofile;
        private Button btnLogin;
        private Panel panelsignup;
        private Panel panelphonemeil;
        private PictureBox mailPic;
        private PictureBox phonePic;
        private Panel panellogologin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panelenteremail;
        private TextBox textEmail;
        private Panel panel6;
        private Panel panelenterphone;
        private TextBox passtxt;
        private Panel panel4;
        private Panel panelenterpass;
        private TextBox confirmtxt;
        private Panel panel7;
        private Panel panelenteruser;
        private TextBox Firstname;
        private Panel panel9;
        private Panel panelSignUpBtn;
        private Button btnsign;
        private Panel panel1;
        private TextBox lastnametxt;
        private Panel panel2;
        private Label Emptymessage;
        private PictureBox Selectpic;
        private Label ErrorLabel;
        private OpenFileDialog openFileDialog1;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private Panel panelLoding;
        private Panel panel3;
        private TextBox Idtext;
        private Panel panel8;
        private Panel panelphone;
        private TextBox Phonetext;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2CheckBox Student;
        private Guna.UI2.WinForms.Guna2CheckBox Lecturer;
        private Guna.UI2.WinForms.Guna2ComboBox specializationCombo;
        private Label specializationlabel;
        private Panel panel10;
        private TextBox EmployeeNumberbox;
        private Panel panel11;
        private Panel panel14;
        private TextBox Course1Box;
        private Panel panel15;
        private Panel panel12;
        private TextBox Course2Box;
        private Panel panel13;
    }
}