using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=Jomolungma\\SQLEXPRESS;Database=Students;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblAdminInfo.Text = "Timing: MON - FRI\n08:00 AM - 04:00 PM\nPhone: + 475555555\nEmail: admin@university.com";
            lblAdminInfo.Visible = !lblAdminInfo.Visible;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblAdminInfo.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentIdText = txtStudentID.Text.Trim();
            string studentName = txtStudentName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(studentIdText) && string.IsNullOrEmpty(studentName) && string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter at least one parameter for search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT StudID, FullName, PhoneNumber, Photo FROM Studlogin WHERE 1=1";

                    if (!string.IsNullOrEmpty(studentIdText))
                        query += " AND StudID = @StudID";
                    if (!string.IsNullOrEmpty(studentName))
                        query += " AND FullName = @FullName";
                    if (!string.IsNullOrEmpty(phoneNumber))
                        query += " AND PhoneNumber = @PhoneNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(studentIdText) && int.TryParse(studentIdText, out int studentId))
                            command.Parameters.AddWithValue("@StudID", studentId);
                        if (!string.IsNullOrEmpty(studentName))
                            command.Parameters.AddWithValue("@FullName", studentName);
                        if (!string.IsNullOrEmpty(phoneNumber))
                            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtStudentID.Text = reader["StudID"].ToString();
                            txtStudentName.Text = reader["FullName"].ToString();
                            txtPhoneNumber.Text = reader["PhoneNumber"].ToString();

                            byte[] photoData = reader["Photo"] as byte[];
                            if (photoData != null)
                            {
                                using (var ms = new MemoryStream(photoData))
                                {
                                    picStudentPhoto.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                picStudentPhoto.Image = Image.FromFile("C:\\Users\\torri\\source\\repos\\SQLapp\\SQLapp\\Resources\\img_placeholder.png");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student not found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtPhoneNumber.Text = "";
            picStudentPhoto.Image = Image.FromFile("C:\\Users\\torri\\source\\repos\\SQLapp\\SQLapp\\Resources\\img_placeholder.png"); 
        }
    }
}
