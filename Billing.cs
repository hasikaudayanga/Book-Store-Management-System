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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Randhu\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            String Query = "Select * From BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        int key = 0, stock=0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            //QtyTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BTitleTb.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }
        private void Reset()
        {
            BTitleTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            ClientnameTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            try
            {

                con.Open();
                string query = "update BookTbl set BQty = " + newQty + " where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Updated Successfully");
                con.Close();
                populate();
                //Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int n = 0, Grdtotal=0;
        int prodid, prodqty, prodprice, tottal, pos = 60;

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
           
            if (ClientnameTb.Text == "" || BTitleTb.Text == "")
            {
                MessageBox.Show("Select Cliant Name");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "insert into BillTbl values('" + UserNameLbl.Text + "' ,'" + ClientnameTb.Text + "' , " + Grdtotal + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                
            }
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Dream Readers Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Navy, new Point(40));
            e.Graphics.DrawString("ID  PRODUCT  PRICE  QUANTITY  TOTAL",new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Navy, new Point(20, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(20, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(40, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(180, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total : RS " + tottal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Navy, new Point(50, pos + 50));
            e.Graphics.DrawString("********* Thank You! *********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Navy, new Point(40, pos +85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            Grdtotal = 0;

        }

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            
            if(QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1 ;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                Grdtotal = Grdtotal + total;
                TotalLbl.Text = "Rs"+ Grdtotal;
            }
        }
    }
}
