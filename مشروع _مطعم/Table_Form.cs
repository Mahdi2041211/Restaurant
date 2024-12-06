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

namespace مشروع__مطعم
{
    public partial class Table_form : Form
    {
        public Table_form()
        {
            InitializeComponent();
            Table1.Click += SetTable_Click;
            Table2.Click += SetTable_Click;
            Table3.Click += SetTable_Click;
            Table4.Click += SetTable_Click;
            Table5.Click += SetTable_Click;
            Table6.Click += SetTable_Click;
            Table7.Click += SetTable_Click;
            Table8.Click += SetTable_Click;
            Table9.Click += SetTable_Click;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {

        }

        private void Table_form_Load(object sender, EventArgs e)
        {

        }
        private void guna2CircleButton9_DoubleClick(object sender, EventArgs e)
        {

        }

        private void SetTable_Click(object sender, EventArgs e)
        {
            
            Guna2CircleButton btn = sender as Guna2CircleButton;

            if (btn.FillColor == Color.Green)
            {
               
                btn.FillColor = Color.Red;
                MessageBox.Show("The table has been reserved");
            }
            else
            {
                btn.FillColor = Color.Green;
                MessageBox.Show("Table available");
            }
        }

        private void Table9_Click(object sender, EventArgs e)
        {

        }

        private void Table3_Click(object sender, EventArgs e)
        {

        }

        private void Table6_Click(object sender, EventArgs e)
        {

        }

        private void Table7_Click(object sender, EventArgs e)
        {

        }

        private void Table8_Click(object sender, EventArgs e)
        {

        }

        private void Table2_Click(object sender, EventArgs e)
        {

        }

        private void Table4_Click(object sender, EventArgs e)
        {

        }

        private void Table5_Click(object sender, EventArgs e)
        {

        }

        private void Table1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
    }
}
