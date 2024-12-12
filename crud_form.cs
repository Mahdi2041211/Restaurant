using System;
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
    public partial class crud_form : Form
    {
        public crud_form()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {

             if (AdminMain_Form.select_btn == "del")
            {
                price_TextBox.Enabled = false;
                discrption_TextBox.Enabled = false;
              
            }
           else if (AdminMain_Form.select_btn == "crt")
            {
                id_textBox.Enabled = false;
            }
           
           else if (AdminMain_Form.select_btn == "up")
            {
              
            }

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AdminMain_Form frm = new AdminMain_Form();
            frm.Show();
            this.Close();
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discrption_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ID_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
