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
using System.IO;
using System.Drawing.Printing;
using System.Collections;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Endproject_
{
    public partial class Home : Form
    {
        public string Hello { set; get; }
        public string name { set; get; }
        public string lastname { set; get; }
        public string email { set; get; }
        public string ID { set; get; }
        public string Phone { set; get; }

        public Home()
        {
            InitializeComponent();

        }
        string consrtring = "Data Source=BASHAR;Initial Catalog=Login;Integrated Security=True";

        private void Home_Load(object sender, EventArgs e)
        {
            MessageChat();
            UserItem();

            panelSearch.Visible = false;
            Homepanel.Visible = true;
            Profilepanel.Visible = false;
            panelSettings.Visible = false;
            panelChat1.Visible = false;
            Panelserial.Visible = false;

            Hellolabel.Text = Hello;
            FirstnameBox.Text = name;
            FirstnameBox.ReadOnly = true;
            LastnameBox.Text = lastname;
            LastnameBox.ReadOnly = true;
            EmailBox.Text = email;
            EmailBox.ReadOnly = true;
            Idbox.Text = ID;
            Idbox.ReadOnly = true;
            Phonebox.Text = Phone;
            Phonebox.ReadOnly = true;
            byte[] getimage = new byte[0];
            SqlConnection con = new SqlConnection(consrtring);
            con.Open();
            string q = "select * from TableLogin1 WHERE Email='" + FirstnameBox.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows) // Read the data for the specific user
            {
                Hellolabel.Text = "Hello" + " " + dataReader[0].ToString() + " : ";
                EmployeeNumberlabel1.Text = dataReader[8].ToString() + " " + "Number";
                labelnumberemployee.Text = dataReader[10].ToString();
                FirstnameBox.Text = dataReader[0].ToString();
                LastnameBox.Text = dataReader[1].ToString();
                EmailBox.Text = dataReader[2].ToString();
                Idbox.Text = dataReader[3].ToString();
                Phonebox.Text = dataReader[4].ToString();
                Course3Box.Text = dataReader[11].ToString();
                Course2Box.Text = dataReader[12].ToString();
                Course1Box.Text = dataReader[13].ToString();
                byte[] images = (byte[])dataReader["image"];
                if (images == null)
                {

                }
                else
                {
                    MemoryStream me = new MemoryStream(images);
                    profilepic.Image = Image.FromStream(me);
                }
            }
            con.Close();

        }
        private bool check;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                Menupanel.Width += 10;
                if (Menupanel.Size == Menupanel.MaximumSize)
                {
                    timer1.Stop();
                    check = false;

                }
            }
            else
            {
                Menupanel.Width -= 10;
                if (Menupanel.Size == Menupanel.MinimumSize)
                {
                    timer1.Stop();
                    check = true;

                }

            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginPage Login = new LoginPage();
            this.Hide();
            Login.Show();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            titlelabel.Text = "Profile";
            Homepanel.Visible = false;
            Profilepanel.Visible = true;
            panelSettings.Visible = false;
            panelChat1.Visible = false;
            panelSearch.Visible = false;
            Panelserial.Visible = false;

        }

        private void ChatBtn_Click(object sender, EventArgs e)
        {
            UserItem();
            Panelserial.Visible = false;
            panelChat1.Visible = true;
            Homepanel.Visible = false;
            panelSettings.Visible = false;
            Profilepanel.Visible = false;
            panelSearch.Visible = false;
            titlelabel.Text = "Chat";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Panelserial.Visible = false;
            titlelabel.Text = "Search";
            panelSearch.Visible = true;
            Homepanel.Visible = false;
            panelSettings.Visible = false;
            Profilepanel.Visible = false;
            panelChat1.Visible = false;


        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Panelserial.BringToFront();
            Panelserial.Visible = true;
            panelChat1.Visible = false;
            Homepanel.Visible = false;
            panelSettings.Visible = false;
            Profilepanel.Visible = false;
            panelSearch.Visible = false;
            string userType = ""; // נוסיף משתנה לאחסון ערך העמודה userType
            SqlConnection con = new SqlConnection(consrtring);
            con.Open();

            // הפניה לטבלה ובדיקת הערך של userType למשתמש הנוכחי
            string q = "SELECT userType FROM TableLogin1 WHERE Email = @Email AND Firstname = @Firstname";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
            cmd.Parameters.AddWithValue("@Firstname", FirstnameBox.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    // קריאה לערך של userType מהתוצאה שקיבלנו
                    userType = dataReader["userType"].ToString();
                }
            }

            con.Close();

            // בדיקה איזה ערך נמצא ב-userType והצבת התוכן המתאים בתוך ה-label
            if (userType == "Student")
            {
                titlelabel.Text = "Student Info";
            }
            else
            {
                titlelabel.Text = "Lecturer Info";
            }
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            panelSettings.BringToFront();
            titlelabel.Text = "Settings";
            Homepanel.Visible = false;
            Profilepanel.Visible = false;
            panelSettings.Visible = true;
            panelChat1.Visible = false;
            panelSearch.Visible = false;
            Panelserial.Visible = false;

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            titlelabel.Text = "Home";
            Homepanel.Visible = true;
            Profilepanel.Visible = false;
            panelSettings.Visible = false;
            panelChat1.Visible = false;
            panelSearch.Visible = false;
            Panelserial.Visible = false;


        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(consrtring);
            con.Open();
            string q = "UPDATE TableLogin1 SET Password=@Password, Confirmpass=@Confirmpass WHERE Email=@Email";
            using (SqlCommand command = new SqlCommand(q, con))
            {
                // הגדרת הפרמטרים
                command.Parameters.AddWithValue("@Password", changpassBox.Text);
                command.Parameters.AddWithValue("@Confirmpass", confrmpassBox.Text);
                command.Parameters.AddWithValue("@Email", emailBox1.Text); // הוסף את הפרמטר החסר @Email

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully!");
                }
                else
                {
                    MessageBox.Show("שגיאה - לא ניתן לעדכן את הסיסמה.");
                }
            }

            con.Close();
        }

        private void UserItem()
        {
            flowUsers.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from TableLogin1 ", consrtring);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table != null)
            {
                if (table.Rows.Count > 0)
                {



                    ControlerChat[] usercontrols = new ControlerChat[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            usercontrols[i] = new ControlerChat();
                            MemoryStream stream = new MemoryStream((byte[])row["image"]);
                            usercontrols[i].ProfileImage = new Bitmap(stream);
                            usercontrols[i].Title = row["Firstname"].ToString();
                            if (usercontrols[i].Title == Hellolabel.Text)
                            {
                                flowUsers.Controls.Remove(usercontrols[i]);
                            }
                            else
                            {
                                flowUsers.Controls.Add(usercontrols[i]);
                            }

                            usercontrols[i].Click += new System.EventHandler(this.ViewUsers_Load);

                        }
                    }
                }
            }
        }

        private void MessageChat()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("SELECT * FROM Chat1 ORDER BY MessageDateTime DESC", consrtring);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table != null && table.Rows.Count > 0)
            {
                flowChat.Controls.Clear();

                foreach (DataRow row in table.Rows)
                {
                    if (FirstnameBox.Text == row["userone"].ToString() && NameSelect.Text == row["usertwo"].ToString())
                    {
                        UserControl1 userControl1 = new UserControl1();
                        userControl1.Dock = DockStyle.Top;
                        userControl1.BringToFront();
                        userControl1.Title = row["message"].ToString();

                        flowChat.Controls.Add(userControl1);
                        flowChat.ScrollControlIntoView(userControl1);
                    }
                    else if (NameSelect.Text == row["userone"].ToString() && FirstnameBox.Text == row["usertwo"].ToString())
                    {
                        UserControl2 userControl2 = new UserControl2();
                        userControl2.Dock = DockStyle.Top;
                        userControl2.BringToFront();
                        userControl2.Title = row["message"].ToString();
                        userControl2.Icon = UserSelect.Image;

                        flowChat.Controls.Add(userControl2);
                        flowChat.ScrollControlIntoView(userControl2);
                    }
                }
            }
        }


        private void AddMessageToChat(string userone, string usertwo, string message)
        {
            using (SqlConnection connection = new SqlConnection(consrtring))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Chat1 (userone, usertwo, message, MessageDateTime) VALUES (@userone, @usertwo, @message, @messageDateTime)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@userone", userone);
                command.Parameters.AddWithValue("@usertwo", usertwo);
                command.Parameters.AddWithValue("@message", message);
                command.Parameters.AddWithValue("@messageDateTime", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
        private void DisplayUserCourses()
        {
            string query = "SELECT Course1, Course2, Course3 FROM TableLogin1 WHERE ID = @UserID";

            using (SqlConnection connection = new SqlConnection(consrtring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", Idbox);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Display the courses in the text boxes
                    Course1Box.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    Course2Box.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    Course3Box.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                }

                reader.Close();
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(consrtring);

            string q = "insert into Chat1(userone,usertwo,message)values(@userone,@usertwo,@message)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("userone", FirstnameBox.Text);
            cmd.Parameters.AddWithValue("usertwo", NameSelect.Text);
            cmd.Parameters.AddWithValue("message", TextBoxMessage.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageChat();
            TextBoxMessage.Clear();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            ControlerChat control = (ControlerChat)sender;
            NameSelect.Text = control.Title;
            UserSelect.Image = control.ProfileImage;
            MessageChat();

        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            string nameToSearch = searchboxbyname.Text.Trim();

            if (string.IsNullOrEmpty(nameToSearch))
            {
                MessageBox.Show("נא להכניס שם לחיפוש");
                return;
            }

            string queryString = "SELECT * FROM TableLogin1 WHERE Firstname LIKE @NameToSearch OR Lastname LIKE @NameToSearch";
            using (SqlConnection connection = new SqlConnection(consrtring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@NameToSearch", "%" + nameToSearch + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    SearchFirstnameBox.Text = row["Firstname"].ToString();
                    SearchLastnameBox.Text = row["Lastname"].ToString();
                    SearchEmailBox.Text = row["Email"].ToString();
                    SearchPhoneBox.Text = row["Phone"].ToString();
                    // Get the image data from the "image" field
                    byte[] imageData = (byte[])row["image"];

                    // Convert the byte array to a MemoryStream
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        // Display the image in the PictureBox
                        Picsearch.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    // Clear TextBoxes if no search results were found
                    SearchFirstnameBox.Text = string.Empty;
                    SearchLastnameBox.Text = string.Empty;
                    SearchEmailBox.Text = string.Empty;
                    SearchPhoneBox.Text = string.Empty;
                }
            }
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            // Read the course names from the TextBoxes
            string course1 = Course1Box.Text;
            string course2 = Course2Box.Text;
            string course3 = Course3Box.Text;

            // Update the courses in the database
            string updateQuery = @"UPDATE TableLogin1
                           SET Course1 = @Course1,
                               Course2 = @Course2,
                               Course3 = @Course3
                           WHERE FirstName = @Firstname;"; // <-- Check this line

            using (SqlConnection connection = new SqlConnection(consrtring))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Course1", course1);
                command.Parameters.AddWithValue("@Course2", course2);
                command.Parameters.AddWithValue("@Course3", course3);
                command.Parameters.AddWithValue("@Firstname", FirstnameBox.Text); // <-- Replace this with the actual first name

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Courses updated successfully!");
                }
                else
                {
                    MessageBox.Show("No courses were updated.");
                }
            }
        }

        Boolean isDarkMode;

        private void Darkmodebtn_Click(object sender, EventArgs e)
        {
            // Toggle the value of isDarkMode using the logical NOT operator (!)
            isDarkMode = !isDarkMode;

            // Update the UI based on the isDarkMode value
            if (isDarkMode)
            {
                Menupanel.BackColor = Color.Black;
                TitlePanel.BackColor = Color.Black;
                titlelabel.BackColor = Color.Black;
                Homebtn.ForeColor = Color.White;
                ProfileBtn.ForeColor = Color.White;
                addbtn.ForeColor = Color.White;
                ChatBtn.ForeColor=Color.White;
                searchbtn.ForeColor=Color.White;
                menubtn.ForeColor=Color.White;
                SettingBtn.ForeColor = Color.White;
                Logoutbtn.ForeColor = Color.White;
                

            }
            else
            {
                Menupanel.BackColor = Color.GhostWhite;
                TitlePanel.BackColor = Color.FromArgb(51, 51, 76);
                titlelabel.BackColor=Color.FromArgb(51, 51, 76);
                Homebtn.ForeColor = Color.FromArgb(51, 51, 76);
                ProfileBtn.ForeColor = Color.FromArgb(51, 51, 76);
                addbtn.ForeColor = Color.FromArgb(51, 51, 76);
                SettingBtn.ForeColor = Color.FromArgb(51, 51, 76);
                Logoutbtn.ForeColor = Color.FromArgb(51, 51, 76);
                ChatBtn.ForeColor = Color.FromArgb(51, 51, 76);
                searchbtn.ForeColor = Color.FromArgb(51, 51, 76);
                menubtn.ForeColor = Color.FromArgb(51, 51, 76);
            }
        }
    }
}

