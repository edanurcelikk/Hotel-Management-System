using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    class usersData
    {
        private string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edanu\OneDrive\Belgeler\hotel.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string DateReg { set; get; }

        public List<usersData> listUsersData()
        {
            List<usersData> listdata = new List<usersData>();
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();

                string selectData = "SELECT * FROM users";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usersData uData = new usersData();
                        uData.ID = (int)reader["id"];
                        uData.Username= reader["username"].ToString();
                        uData.Password = reader["password"].ToString();
                        uData.Role= reader["role"].ToString();
                        uData.Status = reader["status"].ToString();
                        uData.DateReg = reader["date_register"].ToString();

                        listdata.Add(uData);
                    }
                }
            }
            return listdata;
        }
    }
}
