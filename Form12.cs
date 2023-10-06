﻿using System;
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
    public partial class MemberAIshop : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public MemberAIshop()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO MemPer(BookID, BookName, Price) VALUES(1004, 'AI superpowers','$40')";
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
            Form16 newForm = new Form16();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO MemPer(BookID, BookName, Price) VALUES(1000, 'Age  of AI','$15')";
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
            Form16 newForm = new Form16();
            newForm.Show();
            this.Hide();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO MemPer(BookID, BookName, Price) VALUES(1001, 'Artificial Intelligence','$30')";
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
            Form16 newForm = new Form16();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO MemPer(BookID, BookName, Price) VALUES(1002, 'AI basics','$28')";
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
            Form16 newForm = new Form16();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }
    }
}
