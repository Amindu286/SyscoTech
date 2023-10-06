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
    public partial class Form10 : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Burrowbooks", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Burrowbooks");
            Burrowgrid.DataSource = ds.Tables["Burrowbooks"].DefaultView;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Allowed to burrow");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Burrowbooks(ISBNno, Bookname) VALUES(95865214532543, 'Age  of AI')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Burrowbooks(ISBNno, Bookname) VALUES(6547852147897, 'AI basics')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Burrowbooks(ISBNno, Bookname) VALUES(98652348566254, 'Intelligent Architecture')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
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

        private void b3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Burrowbooks(ISBNno, Bookname) VALUES(7412563254789, 'Clean Architecture')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
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

        private void b5_Click(object sender, EventArgs e)
        {

        }

        private void b6_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Burrowbooks(ISBNno, Bookname) VALUES(5698741236547, 'The E myth')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
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

        private void Burrowgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
             string sqlStatement = "DELETE FROM Burrowbooks";
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
            Form10_Load(this, null);
 
        }
    }
}
