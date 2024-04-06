using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endproject_
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; MessageLabel.Text = value; AddHeighttext(); }
        }
        void AddHeighttext()
        {
            UserControl1 user = new UserControl1();
            user.BringToFront();
            MessageLabel.Height = Uilist.GetTextheight(MessageLabel) + 10;
            user.Height = MessageLabel.Top + MessageLabel.Height;
            this.Height = user.Bottom + 10;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
