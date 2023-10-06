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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for shopping with us");
            Form5 newForm = new Form5();
            newForm.Show();
            this.Hide();
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            string message = "Do you want to decline the purchase?";
            string title = "Confirm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Your purchase has been declined");
                Memberpurchase2 newForm = new Memberpurchase2();
                newForm.Show();
                this.Close();
            }
            else
            {
                //this.Close(); 
            }
            

        }
    }
}
