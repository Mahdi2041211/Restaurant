using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Resturant
{
    public partial class AdminMain_Form : Form
    {
       public static string select_btn;
        public AdminMain_Form()
        {
            InitializeComponent();
            
            creat_btn.Tag = "crt";
            delete_btn.Tag = "del";
            update_btn.Tag = "up";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void AdminMain_Form_Click(object sender, EventArgs e)
        {
            crud_form frm = new crud_form();
             Guna2Button btn = sender as Guna2Button;
            if (btn!=null)
            {
                select_btn = btn.Tag.ToString(); 
            }
            frm.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void read_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
