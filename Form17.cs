using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_SDAM
{
    public partial class Form17 : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Form17()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            try
            {
                
                string BDate = BurrowD.Value.ToString("yyyy-MM-dd");
                string RDate = ReturnD.Value.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO Return_book (bookID, BookName, BDate, Rdate) VALUES('" + IDreturn.Text + "','" + ReturnC.Text + "','" + BDate + "','" + RDate + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Return Successfull ", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }

        }

        private void ReturnD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btndec_Click(object sender, EventArgs e)
        {
            string message = "Do you want to end the return process?";
            string title = "Confirm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form4 newForm = new Form4();
                newForm.Show();
                this.Close();
            }
            else
            {
                //this.Close(); 
            }
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }
    }
}
