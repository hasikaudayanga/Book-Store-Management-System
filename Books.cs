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
            populat();
        }
        SqlConnection con = new SqlConnection(@"");

        private void populat()
        {
            con.Open();
            String Query = "Select * BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query , con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();   
            sda.Fill(ds);
            BookDGV.Datasource = ds.Tables[0];
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
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
               
        }

    }
}
