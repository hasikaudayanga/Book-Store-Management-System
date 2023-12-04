using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Shop_Management_System
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Randhu\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            String Query = "Select * From BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query , con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();    
        }
        private void Filter()
        {
            con.Open();
            String Query = "Select * From BookTbl where BCat='"+CatCbSearchCb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BautTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            { MessageBox.Show("Missing Information"); 
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "insert into BookTbl values('" + BTitleTb.Text + "' ,'" + BautTb.Text + "' , '" + BCatCb.SelectedItem.ToString() + "', '" + QtyTb.Text + "' , '" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
               
        }

        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }
        private void Reset()
        {
            BTitleTb.Text = "";
            BautTb.Text = "";
            BCatCb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
            
        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BautTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            BCatCb.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            QtyTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if(BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "delete from BookTbl where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Delete Successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditeBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BautTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "update BookTbl set BTitle = '" +BTitleTb.Text+ "', BAuthor='"+BautTb.Text+"', BCat='"+BCatCb.SelectedItem.ToString()+"',BQty = "+QtyTb.Text+",BPrice="+PriceTb.Text+" where BId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void UserLbl_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void DashboardLbl_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

    }
}
