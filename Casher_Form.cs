using System;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Casher_form : Form
    {
        public Casher_form()
        {
            InitializeComponent();
            
            number_order.KeyPress += NumberOrder_KeyPress;
            number_order.Leave += NumberOrder_Leave;
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
           int.TryParse(price.Text, out int value1);
           int.TryParse(Total_Price.Text, out int value2);
            int result = value1 + value2;
           Total_Price.Text = result.ToString();
            price.Text = "0";
            number_order.Text = "1";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            
            int b = int .Parse(number_order.Text);
            int result =  b* 10;
          
            this.price.Text = result.ToString();
        }
        private void NumberOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void NumberOrder_Leave(object sender, EventArgs e)
        {
           
            Guna2TextBox textBox = sender as Guna2TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text) || !int.TryParse(textBox.Text, out int value) || value < 1 || value > 10)
            {
                MessageBox.Show("Please enter a number between 1 and 10. Default value set to 1.");
                textBox.Text = "1";
                textBox.Focus();
            }
        }



        private void number_order_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            Total_Price.Text = "0";
            price.Text = "";

        }

        private void set_table_btn_Click(object sender, EventArgs e)
        {
            Table_form frm = new Table_form();
            frm.Show();

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            int Invoice = int.Parse(Total_Price.Text);
            Total_Price.Text = "0";

        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
