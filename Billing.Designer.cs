namespace Book_Shop_Management_System
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.label4 = new System.Windows.Forms.Label();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.AddToBillBtn = new System.Windows.Forms.Button();
            this.BautLbl = new System.Windows.Forms.Label();
            this.BTitleLbl = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.BTitleTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LogoutLbl = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.ClientnameTb = new System.Windows.Forms.TextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(265, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Books List";
            // 
            // BookDGV
            // 
            this.BookDGV.AllowUserToAddRows = false;
            this.BookDGV.AllowUserToDeleteRows = false;
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BookDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.BookDGV.Location = new System.Drawing.Point(25, 390);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(596, 348);
            this.BookDGV.TabIndex = 19;
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(343, 254);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(93, 35);
            this.ResetBtn.TabIndex = 18;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CloseLbl.Location = new System.Drawing.Point(1062, 3);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(18, 20);
            this.CloseLbl.TabIndex = 9;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.CloseLbl_Click);
            // 
            // AddToBillBtn
            // 
            this.AddToBillBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddToBillBtn.ForeColor = System.Drawing.Color.White;
            this.AddToBillBtn.Location = new System.Drawing.Point(207, 254);
            this.AddToBillBtn.Name = "AddToBillBtn";
            this.AddToBillBtn.Size = new System.Drawing.Size(93, 35);
            this.AddToBillBtn.TabIndex = 7;
            this.AddToBillBtn.Text = "Add To Bill";
            this.AddToBillBtn.UseVisualStyleBackColor = false;
            this.AddToBillBtn.Click += new System.EventHandler(this.AddToBillBtn_Click);
            // 
            // BautLbl
            // 
            this.BautLbl.AutoSize = true;
            this.BautLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BautLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BautLbl.Location = new System.Drawing.Point(218, 189);
            this.BautLbl.Name = "BautLbl";
            this.BautLbl.Size = new System.Drawing.Size(61, 20);
            this.BautLbl.TabIndex = 6;
            this.BautLbl.Text = "Quantity";
            // 
            // BTitleLbl
            // 
            this.BTitleLbl.AutoSize = true;
            this.BTitleLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTitleLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTitleLbl.Location = new System.Drawing.Point(33, 189);
            this.BTitleLbl.Name = "BTitleLbl";
            this.BTitleLbl.Size = new System.Drawing.Size(80, 20);
            this.BTitleLbl.TabIndex = 5;
            this.BTitleLbl.Text = "Book Name";
            // 
            // QtyTb
            // 
            this.QtyTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.QtyTb.Location = new System.Drawing.Point(222, 212);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(78, 24);
            this.QtyTb.TabIndex = 4;
            // 
            // BTitleTb
            // 
            this.BTitleTb.Enabled = false;
            this.BTitleTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTitleTb.Location = new System.Drawing.Point(37, 212);
            this.BTitleTb.Name = "BTitleTb";
            this.BTitleTb.Size = new System.Drawing.Size(122, 24);
            this.BTitleTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Madhura", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(442, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dream Readers Book Shop ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(41, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Madhura", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dream Readers Book Shop ";
            // 
            // LogoutLbl
            // 
            this.LogoutLbl.AutoSize = true;
            this.LogoutLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLbl.ForeColor = System.Drawing.Color.White;
            this.LogoutLbl.Location = new System.Drawing.Point(69, 3);
            this.LogoutLbl.Name = "LogoutLbl";
            this.LogoutLbl.Size = new System.Drawing.Size(65, 23);
            this.LogoutLbl.TabIndex = 10;
            this.LogoutLbl.Text = "Logout";
            this.LogoutLbl.Click += new System.EventHandler(this.LogoutLbl_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.LogoutLbl);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Location = new System.Drawing.Point(17, 695);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 34);
            this.panel6.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.UserNameLbl);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.TotalLbl);
            this.panel2.Controls.Add(this.BillDGV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PriceTb);
            this.panel2.Controls.Add(this.ClientnameTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BookDGV);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.PrintBtn);
            this.panel2.Controls.Add(this.CloseLbl);
            this.panel2.Controls.Add(this.AddToBillBtn);
            this.panel2.Controls.Add(this.BautLbl);
            this.panel2.Controls.Add(this.BTitleLbl);
            this.panel2.Controls.Add(this.QtyTb);
            this.panel2.Controls.Add(this.BTitleTb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(263, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 756);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(54, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Login To";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UserNameLbl.Location = new System.Drawing.Point(53, 19);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(88, 23);
            this.UserNameLbl.TabIndex = 31;
            this.UserNameLbl.Text = "UserName";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TotalLbl.Location = new System.Drawing.Point(855, 666);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(48, 23);
            this.TotalLbl.TabIndex = 29;
            this.TotalLbl.Text = "Total";
            // 
            // BillDGV
            // 
            this.BillDGV.AllowUserToAddRows = false;
            this.BillDGV.AllowUserToDeleteRows = false;
            this.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.BillDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BillDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.BillDGV.Location = new System.Drawing.Point(656, 212);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(415, 451);
            this.BillDGV.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Books";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(827, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Books Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(530, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(352, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Client Name";
            // 
            // PriceTb
            // 
            this.PriceTb.Enabled = false;
            this.PriceTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PriceTb.Location = new System.Drawing.Point(534, 212);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(78, 24);
            this.PriceTb.TabIndex = 24;
            // 
            // ClientnameTb
            // 
            this.ClientnameTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClientnameTb.Location = new System.Drawing.Point(356, 212);
            this.ClientnameTb.Name = "ClientnameTb";
            this.ClientnameTb.Size = new System.Drawing.Size(122, 24);
            this.ClientnameTb.TabIndex = 23;
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(831, 703);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(93, 35);
            this.PrintBtn.TabIndex = 16;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 738);
            this.panel1.TabIndex = 3;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Button AddToBillBtn;
        private System.Windows.Forms.Label BautLbl;
        private System.Windows.Forms.Label BTitleLbl;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.TextBox BTitleTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LogoutLbl;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.TextBox ClientnameTb;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Button PrintBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}