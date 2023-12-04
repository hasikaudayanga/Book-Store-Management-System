using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Randhu\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        public static string UserName = "";
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UName = '"+UnameTb.Text+"' and UPass = '"+UPassTb.Text+"' ", con); 
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                UserName =UnameTb.Text;
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            con.Close();
        }

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLbl_Click(object sender, EventArgs e)
        {
            AdminLoging obj = new AdminLoging();
            obj.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
