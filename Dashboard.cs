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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void BooksLbl_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void UserLbl_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Randhu\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select sum(BQty) from BookTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStockLbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select sum(Amount) from BillTbl", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmmountLbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Count(*) from UserTbl", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UsertotalLbl.Text = dt2.Rows[0][0].ToString();
            con.Close();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
