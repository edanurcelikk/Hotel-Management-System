﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        private string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edanu\OneDrive\Belgeler\hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();

            this.Hide();
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users WHERE username = @usern AND password=@pass" +
                        " AND status='Active'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Login successfully!", "Information Message", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string selectRole = "SELECT role FROM users WHERE username=@usern AND password=@pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                if(userRole == "Admin")
                                {
                                    AdminMainForm adminForm = new AdminMainForm();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else if (userRole == "Staff")
                                {
                                    staffMainForm staffForm = new staffMainForm();
                                    staffForm.Show();
                                    this.Hide();
                                }
                            }

                               
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password", "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
    }
}
                
