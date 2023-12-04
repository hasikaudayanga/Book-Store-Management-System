using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class AdminLoging : Form
    {
        public AdminLoging()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UPassTb.Text== "Password")
            {
                Books obj = new Books();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password.Coctact The Admin");
            }
        }

        private void CancelLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void AdminLoging_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
