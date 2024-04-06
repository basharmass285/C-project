namespace Endproject_
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            afriCircleImage1 = new AfriCircleImage.AfriCircleImage();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            labelshow = new Label();
            ((System.ComponentModel.ISupportInitialize)afriCircleImage1).BeginInit();
            SuspendLayout();
            // 
            // afriCircleImage1
            // 
            afriCircleImage1.BackColor = Color.White;
            afriCircleImage1.Image = Properties.Resources.Select_png;
            afriCircleImage1.Location = new Point(29, 17);
            afriCircleImage1.Name = "afriCircleImage1";
            afriCircleImage1.Size = new Size(76, 64);
            afriCircleImage1.SizeMode = PictureBoxSizeMode.Zoom;
            afriCircleImage1.TabIndex = 0;
            afriCircleImage1.TabStop = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.GhostWhite;
            guna2TextBox1.BorderColor = Color.GhostWhite;
            guna2TextBox1.BorderRadius = 20;
            guna2TextBox1.CustomizableEdges = customizableEdges9;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.FromArgb(51, 51, 55);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(111, 27);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox1.Size = new Size(350, 54);
            guna2TextBox1.TabIndex = 2;
            // 
            // labelshow
            // 
            labelshow.AutoSize = true;
            labelshow.BackColor = Color.FromArgb(51, 51, 55);
            labelshow.Location = new Point(143, 39);
            labelshow.Name = "labelshow";
            labelshow.Size = new Size(68, 30);
            labelshow.TabIndex = 3;
            labelshow.Text = "label1";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(labelshow);
            Controls.Add(guna2TextBox1);
            Controls.Add(afriCircleImage1);
            Name = "UserControl2";
            Size = new Size(466, 90);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)afriCircleImage1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AfriCircleImage.AfriCircleImage afriCircleImage1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label labelshow;
    }
}
