using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_Management_System
{

    class customersData
    {
        private string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edanu\OneDrive\Belgeler\hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get;}
        public string BookID { set; get; }
        public string FullName { set; get; }
        public string Email { set; get; }
        public string ContactNum { set; get; }
        public string Gender { set; get; }
        public string Address { set; get; }
        public string RoomID { set; get; }
        public string Price { set; get; }
        public string StatusPayment { set; get; }
        public string Status { set; get; }
        public string CheckIn { set; get; }
        public string CheckOut { set; get; }
        public string BookDate { set; get; }

        public List<customersData> customersListData()
        {
            List<customersData> listdata = new List<customersData>();
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();

                string selectData = "SELECT * FROM customer";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customersData cData = new customersData();

                        cData.ID = (int)reader["id"];
                        cData.BookID = reader["book_id"].ToString();
                        cData.FullName = reader["full_name"].ToString();
                        cData.Email = reader["email"].ToString();
                        cData.ContactNum = reader["contact"].ToString();
                        cData.Gender = reader["gender"].ToString();
                        cData.Address = reader["address"].ToString();
                        cData.RoomID = reader["room_id"].ToString();
                        cData.Price = reader["price"].ToString();
                        cData.StatusPayment = reader["status_payment"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.CheckIn = reader["date_from"].ToString();
                        cData.CheckOut = reader["date_to"].ToString();
                        cData.BookDate = reader["date_book"].ToString();

                        listdata.Add(cData);
                    }
                }
            }
            return listdata;
        }
    }
}
