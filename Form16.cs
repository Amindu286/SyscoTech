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
    public partial class Form16 : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Form16()
        {
            InitializeComponent();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show();
            this.Hide();
        }

        private void purchaseback_Click(object sender, EventArgs e)
        {
            Memberpurchase2 newForm = new Memberpurchase2();
            newForm.Show();
            this.Hide();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MemPer", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "MemPer");
            dataGrid.DataSource = ds.Tables["MemPer"].DefaultView;

        }

        private void memberresets_Click(object sender, EventArgs e)
        {
            string sqlStatement = "DELETE FROM MemPer";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }
            Form16_Load(this, null);
        }
    }
}
