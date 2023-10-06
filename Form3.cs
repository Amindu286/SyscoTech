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
    public partial class Form3 : Form

        
    {

        SqlConnection conn = new SqlConnection (ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            

            try
            {
                string mem_type = memtype.Text;
                string sql = "INSERT INTO Member (uname, name, mail, type, pswd)VALUES('" + uname.Text + "','" + name.Text + "','" + mail.Text + "','" + mem_type + "','" + pswd.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Registration Successful ", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 newForm = new Form2();
                newForm.Show();
                this.Hide();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Library Management System",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }





        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
