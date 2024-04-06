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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; labelshow.Text = value; }
        }
        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; afriCircleImage1.Image = value; AddHeighttext(); }
        }
        void AddHeighttext()
        {
            UserControl2 user = new UserControl2();
            user.BringToFront();
            labelshow.Height = Uilist.GetTextheight(labelshow) + 10;
            user.Height = labelshow.Top + labelshow.Height;
            this.Height = user.Bottom + 10;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }
    }
}
