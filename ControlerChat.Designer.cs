namespace Endproject_
{
    partial class ControlerChat
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            UsersButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.GhostWhite;
            UsersButton.BorderColor = Color.GhostWhite;
            UsersButton.BorderRadius = 20;
            UsersButton.CustomizableEdges = customizableEdges1;
            UsersButton.DisabledState.BorderColor = Color.DarkGray;
            UsersButton.DisabledState.CustomBorderColor = Color.DarkGray;
            UsersButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            UsersButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            UsersButton.FillColor = Color.FromArgb(51, 51, 76);
            UsersButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsersButton.ForeColor = Color.White;
            UsersButton.ImageAlign = HorizontalAlignment.Left;
            UsersButton.ImageSize = new Size(75, 75);
            UsersButton.Location = new Point(3, 3);
            UsersButton.Name = "UsersButton";
            UsersButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UsersButton.Size = new Size(315, 80);
            UsersButton.TabIndex = 0;
            UsersButton.Text = "Name";
            UsersButton.Click += UsersButton_Click;
            // 
            // ControlerChat
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(UsersButton);
            ForeColor = Color.GhostWhite;
            Name = "ControlerChat";
            Size = new Size(321, 86);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button UsersButton;
    }
}
