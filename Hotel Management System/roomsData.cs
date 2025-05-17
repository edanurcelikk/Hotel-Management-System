using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    class roomsData
    {
        private string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edanu\OneDrive\Belgeler\hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string RoomID { set; get; }
        public string RoomType { set; get; }
        public string RoomName { set; get; }
        public string Price { set; get; }
        public string Image { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }


        public List<roomsData> roomsDataList()
        {
            List<roomsData> listdata = new List<roomsData>();
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();

                string selectData = "SELECT * FROM rooms WHERE date_delete IS NULL";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        roomsData rData = new roomsData();
                        rData.ID = (int)reader["id"];
                        rData.RoomID = reader["room_id"].ToString();
                        rData.RoomType = reader["type"].ToString();
                        rData.RoomName = reader["room_name"].ToString();
                        rData.Price = reader["price"].ToString();
                        rData.Image = reader["image_path"].ToString();
                        rData.Status = reader["status"].ToString();
                        rData.Date = reader["date_register"].ToString();

                        listdata.Add(rData);
                    }
                }
            }
            return listdata;
        }

    }
}
