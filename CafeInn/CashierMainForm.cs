using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeInn
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check =MessageBox.Show("Are you sure that you want to Logout?","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(check==DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cashierOrderForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
