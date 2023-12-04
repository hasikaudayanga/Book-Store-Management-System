using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_Shop_Management_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpos = 0;  
        private void timer2_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogress.Value = startpos;
            PresentageLbl.Text = startpos + "%";
            if (Myprogress.Value == 100) 
            {
                Myprogress.Value = 0;
                timer2.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer2.Start();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void Splash_TextChanged(object sender, EventArgs e)
        {

        }

        private void Splash_Validated(object sender, EventArgs e)
        {

        }
    }
}
