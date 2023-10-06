using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment_SDAM
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Usernamebox.Text;
            string password = pswdbox.Text;

            string sql = "SELECT * FROM member where uname = '" + Usernamebox.Text + "' AND pswd = '" + pswdbox.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && (Usernamebox.Text != "") && (pswdbox.Text != ""))
            {
                MessageBox.Show("Log-in Successfull");
                Form4 newForm = new Form4();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Error, Plese input valid UserName and Password");
            }
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void Usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswdbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
