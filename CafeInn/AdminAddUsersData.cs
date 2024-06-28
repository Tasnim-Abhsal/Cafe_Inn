using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CafeInn
{
    internal class AdminAddUsersData
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\My Lenovo\Documents\cafeIn.mdf"";Integrated Security=True;Connect Timeout=30");
        
        public int Id {  get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public string role {  get; set; }
        public string Status {  get; set; }
        public string DataRegistered {  get; set; }
        public List<AdminAddUsersData> usersListData()
        {
            List<AdminAddUsersData> listData= new List<AdminAddUsersData>();
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT *FROM users";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AdminAddUsersData usersData = new AdminAddUsersData();
                            usersData.Id = (int)reader["id"];
                            usersData.Username = reader["Username"].ToString();
                            usersData.Password = reader["Password"].ToString();
                            usersData.role = reader["role"].ToString();
                            usersData.Status = reader["status"].ToString();
                            usersData.DataRegistered = reader["date_reg"].ToString();
                            listData.Add(usersData);


                        }

                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex);

                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;

        }
    }
}
