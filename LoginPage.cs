using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // נוסיף ספריה זו כדי לקרוא קבצים
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Endproject_
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        string constring = "Data Source=BASHAR;Initial Catalog=Login;Integrated Security=True";
        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillSpecializations()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    string query = "SELECT specialization FROM TableSpecialization";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string specialization = reader["specialization"].ToString();
                                specializationCombo.Items.Add(specialization);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // טיפול בשגיאות אם יש צורך
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextUsername.Text.Trim()) || string.IsNullOrEmpty(TextPassword.Text.Trim()))
            {
                ErrorLabel.Visible = true;
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string q = "SELECT * FROM TableLogin1 WHERE Email = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Username", TextUsername.Text);
            cmd.Parameters.AddWithValue("@Password", TextPassword.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                string userType = string.Empty;

                while (dataReader.Read())
                {
                    // Get the value of the "userType" column from the database
                    userType = dataReader["userType"].ToString();
                }

                if (userType == "Student")
                {
                    // המשתמש הוא מרצה, עבור על האופציות של מרצה
                    if (Student.Checked)
                    {
                        // Perform actions for lecturers with valid options
                        panelLoding.Visible = true;
                        timer1.Start();
                    }
                    else
                    {
                        // Display error message for lecturers with invalid options
                        MessageBox.Show("Invalid option selected for lecturers.");
                    }
                }
                else if (userType == "Lecturer")
                {
                    // המשתמש הוא סטודנט, עבור על האופציות של סטודנט
                    if (Lecturer.Checked)
                    {
                        panelLoding.Visible = true;
                        timer1.Start();
                    }
                    else
                    {
                        // Display error message for students with invalid options
                        MessageBox.Show("Invalid option selected for students.");
                    }
                }
                else
                {
                    // Invalid user type or missing userType value in the database
                    MessageBox.Show("Invalid user type.");
                }
            }
            else
            {
                MessageBox.Show("Please check your username and password.");
            }

            con.Close();
        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            panelsignup.Visible = true;
            panelsignup.BringToFront();

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            Emptymessage.Visible = false;
            ErrorLabel.Visible = false;
        }

        private void picpassword_Click(object sender, EventArgs e)
        {
        }

        private void picprofile_Click(object sender, EventArgs e)
        {
        }

        private void panelPic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            panelsignup.Visible = false;
            LoginPanel.BringToFront();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            btnLogin.PerformClick();
            panelLoding.Visible = false;
            FillSpecializations();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            if (Selectpic.Image == null ||
                string.IsNullOrEmpty(Firstname.Text.Trim()) ||
                string.IsNullOrEmpty(lastnametxt.Text.Trim()) ||
                string.IsNullOrEmpty(textEmail.Text.Trim()) ||
                string.IsNullOrEmpty(passtxt.Text.Trim()) ||
                string.IsNullOrEmpty(confirmtxt.Text.Trim()) ||
                string.IsNullOrEmpty(Phonetext.Text.Trim()) ||
                string.IsNullOrEmpty(Idtext.Text.Trim()))
            {
                Emptymessage.Visible = true;
            }
            else
            {
                Emptymessage.Visible = false;
            }

            if (passtxt.Text != confirmtxt.Text)
            {
                MessageBox.Show("Password Not Match");
            }
            else
            {
                string specialization = specializationCombo.SelectedItem.ToString();

                SqlConnection con = new SqlConnection(constring);
                string q = "INSERT INTO TableLogin1 (Firstname, Lastname, Email, Phone, ID, Password, Confirmpass, image, userType, Specialization,EmployeeNumberbox) VALUES (@Firstname, @Lastname, @Email, @Phone, @ID, @Password, @Confirmpass, @image, @userType, @Specialization,@EmployeeNumberbox)";
                SqlCommand cmd = new SqlCommand(q, con);
                MemoryStream me = new MemoryStream();
                Selectpic.Image.Save(me, Selectpic.Image.RawFormat);
                cmd.Parameters.AddWithValue("@Firstname", Firstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", lastnametxt.Text);
                cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", Phonetext.Text);
                cmd.Parameters.AddWithValue("@ID", Idtext.Text);
                cmd.Parameters.AddWithValue("@Password", passtxt.Text);
                cmd.Parameters.AddWithValue("@Confirmpass", confirmtxt.Text);
                cmd.Parameters.AddWithValue("@image", me.ToArray());
                cmd.Parameters.AddWithValue("@userType", "Student");
                cmd.Parameters.AddWithValue("@Specialization", specialization);
                cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumberbox.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                if (Emptymessage.Visible == false)
                {
                    MessageBox.Show("Registration successfully...");

                    Firstname.Clear();
                    lastnametxt.Clear();
                    textEmail.Clear();
                    passtxt.Clear();
                    confirmtxt.Clear();
                    Phonetext.Clear();
                    Idtext.Clear();
                    Selectpic.Image = null; // קוד נוסף שלך
                }
            }
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Selectpic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "select image(*Jpg; *.png *Gif|*Jpg; *.png; *Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Selectpic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 2;
            }
            else
            {
                timer1.Stop();
                Home homepage = new Home();
                homepage.name = TextUsername.Text;
                this.Hide();
                homepage.Show();
            }
        }

        private void Student_CheckedChanged(object sender, EventArgs e)
        {
            if (Student.Checked)
            {
                Lecturer.Checked = false;
            }
        }

        private void Lecturer_CheckedChanged(object sender, EventArgs e)
        {
            if (Lecturer.Checked)
            {
                Student.Checked = false;
            }
        }
    }
}
