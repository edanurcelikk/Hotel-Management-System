using System;
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
    public partial class clientInfo : Form
    {
        private string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edanu\OneDrive\Belgeler\hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public clientInfo()
        {
            InitializeComponent();
            displayBookID();
        }

        private void clientInfo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void displayBookID()
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();

                int getBookID = 0;

                string selectBID = "SELECT COUNT(id) FROM customer";
   
               using (SqlCommand cmd = new SqlCommand(selectBID, connect))
                {
                    getBookID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (getBookID == 0)
                    {
                        getBookID += 1;
                    }
                    else
                    {
                        getBookID += 1;
                    }
                }

                client_bookID.Text = $"BID-{getBookID}";
            }   
        }


        private void client_bookBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to book now?", "Information Message,",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (client_fullName.Text == "" || client_gender.SelectedIndex == -1 || client_address.Text == ""
                || client_email.Text == "" || client_contact.Text == "" || hotelData.roomID == "")
                {
                    MessageBox.Show("Please fill all blank fields.", "Error Message ,",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    using (SqlConnection connect = new SqlConnection(con))
                    {
                        connect.Open();

                        string insertData = "INSERT INTO customer " +
                            "(book_id, full_name, email, contact, gender, address,  price, room_id," +
                            "status_payment, status, date_from, date_to, date_book)" +
                            "VALUES(@bookID, @fullname, @email, @contact, @gender, @address,@roomID, @price, @statusP" +
                            ", @status, @dateForm, @dateTo, @dateBook)";


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookID", client_bookID.Text);
                            cmd.Parameters.AddWithValue("@fullname", client_fullName.Text);
                            cmd.Parameters.AddWithValue("@email", client_email.Text);
                            cmd.Parameters.AddWithValue("@contact", client_contact.Text);
                            cmd.Parameters.AddWithValue("@gender", client_gender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@address", client_address.Text);
                            cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);
                            cmd.Parameters.AddWithValue("@price", hotelData.price);
                            cmd.Parameters.AddWithValue("@statusP", "Paid");
                            cmd.Parameters.AddWithValue("@status", "Checked In");
                            cmd.Parameters.AddWithValue("@dateForm", hotelData.fromDate);
                            cmd.Parameters.AddWithValue("@dateTo", hotelData.toDate);

                            DateTime today = DateTime.Today;

                            cmd.Parameters.AddWithValue("@dateBook", today);

                            cmd.ExecuteNonQuery();

                            updateRoomStatus();

                            MessageBox.Show("Booked successfully!", "Information Message",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                        }
                    }
                }
            }
            
        }

        public void updateRoomStatus()
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();

                string updateStatus = "UPDATE rooms SET status = @status WHERE room_id = @roomID";

                using (SqlCommand cmd = new SqlCommand(updateStatus, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Unavailable");
                    cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);

                    cmd.ExecuteNonQuery();

                }


            }
        }


        private void client_clearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
