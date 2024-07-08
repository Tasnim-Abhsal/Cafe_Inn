using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CafeInn
{
    public partial class Form1 : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\My Lenovo\\Documents\\cafeIn.mdf\";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //go to register page
        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm=new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (login_username.Text == "" || login_password.Text == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK);

            }
            else
            {
                if (connect.State==ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectAccount = "SELECT COUNT(*) FROM users WHERE username = @usern AND password=@pass AND status =@status";
                        using (SqlCommand cmd=new SqlCommand(selectAccount,connect)) 
                        {
                            cmd.Parameters.AddWithValue("@usern",login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");
                            int rowCount =(int)cmd.ExecuteScalar();
                            if(rowCount > 0)
                            {
                                string selectRole = "SELECT role FROM users WHERE username=@usern AND password=@pass";
                                using(SqlCommand getRole=new SqlCommand(selectRole,connect))
                                {
                                    getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                    getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                                    string userRole=getRole.ExecuteScalar() as string;
                                    MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (userRole == "Admin")
                                    {
                                        AdminMainForm adminForm = new AdminMainForm();
                                        adminForm.Show();
                                        this.Hide();
                                    }
                                    else if (userRole == "Cashier")
                                    {
                                        CashierMainForm cashierForm = new CashierMainForm();
                                        cashierForm.Show();
                                        this.Hide();
                                    }
                                   
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorret Username/Password or There's no Admin Approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                 finally
                    {
                        connect.Close();

                    }
                }
               
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
