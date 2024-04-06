using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endproject_
{
    public partial class ControlerChat : UserControl
    {
        public ControlerChat()
        {
            InitializeComponent();
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; UsersButton.Text = value; UsersButton.ForeColor = Color.White; }
        }

        private Image _profileImage;

        public void UsersButton_Click(object sender, EventArgs e)
        {

        }

        public Image ProfileImage
        {
            get { return _profileImage; }
            set { _profileImage = value; UsersButton.Image = value; }
        }
    }
}
