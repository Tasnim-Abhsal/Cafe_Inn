﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace CafeInn
{
    class CashierOrderFormProdData
    {
        public int ID { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\My Lenovo\Documents\cafeIn.mdf"";Integrated Security=True;Connect Timeout=30");
        public List<CashierOrderFormProdData> availableProductsData()
        {
            List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM products WHERE prod_status=@status AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            CashierOrderFormProdData apd = new CashierOrderFormProdData();
                            apd.ID = (int)reader["id"];
                            apd.ProductId = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString() ;


                            listData.Add(apd);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
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


    

