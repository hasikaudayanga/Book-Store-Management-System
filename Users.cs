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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }

        public Users(SqlConnection con)
        {
            this.con = con;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Randhu\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String Query = "Select * From UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "insert into UserTbl values('" + UnameTb.Text + "' ,'" + PhoneTb.Text + "' , '" + AddTb.Text + "' , '" + PassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
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
        private void Reset()
        {
            UnameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
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
                    string query = "delete from UserTbl where UID=" + key + ";";
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
        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddTb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            PassTb.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (UnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditeBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "update UserTbl set UName = '" + UnameTb.Text + "', UPhone='" + PhoneTb.Text + "', UAdd='" + AddTb.Text + "',UPass = '" + PassTb.Text + "' where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
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

        private void BooksLbl_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
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

        private void Users_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
    }
