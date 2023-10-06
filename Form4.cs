using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_SDAM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Exit?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //this.Close(); 
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
            this.Hide();
        }

        private void btnBurrow_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnHostory_Click(object sender, EventArgs e)
        {
            Form17 newForm = new Form17();
            newForm.Show();
            this.Hide();
        }

        private void memshop_Click(object sender, EventArgs e)
        {
            Memberpurchase2 newForm = new Memberpurchase2();
            newForm.Show();
            this.Hide();
        }
    }
}
    

