namespace HardwareShop
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.CatBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CustBtn = new System.Windows.Forms.Button();
            this.BillBtn = new System.Windows.Forms.Button();
            this.ItemsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CashLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MobileLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CardLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.ReportList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(194, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 70);
            this.panel3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(215, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hardware Shop Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SalesBtn);
            this.panel1.Controls.Add(this.CatBtn);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Controls.Add(this.CustBtn);
            this.panel1.Controls.Add(this.BillBtn);
            this.panel1.Controls.Add(this.ItemsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 723);
            this.panel1.TabIndex = 12;
            // 
            // SalesBtn
            // 
            this.SalesBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.Location = new System.Drawing.Point(16, 494);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(213, 48);
            this.SalesBtn.TabIndex = 36;
            this.SalesBtn.Text = "Daily Report";
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // CatBtn
            // 
            this.CatBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.CatBtn.Image = ((System.Drawing.Image)(resources.GetObject("CatBtn.Image")));
            this.CatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CatBtn.Location = new System.Drawing.Point(16, 244);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(213, 48);
            this.CatBtn.TabIndex = 35;
            this.CatBtn.Text = "Categories";
            this.CatBtn.UseVisualStyleBackColor = true;
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(16, 663);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(213, 48);
            this.LogoutBtn.TabIndex = 34;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CustBtn
            // 
            this.CustBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.CustBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustBtn.Image")));
            this.CustBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustBtn.Location = new System.Drawing.Point(16, 330);
            this.CustBtn.Name = "CustBtn";
            this.CustBtn.Size = new System.Drawing.Size(213, 48);
            this.CustBtn.TabIndex = 31;
            this.CustBtn.Text = "Customer";
            this.CustBtn.UseVisualStyleBackColor = true;
            this.CustBtn.Click += new System.EventHandler(this.CustBtn_Click);
            // 
            // BillBtn
            // 
            this.BillBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.BillBtn.Image = ((System.Drawing.Image)(resources.GetObject("BillBtn.Image")));
            this.BillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillBtn.Location = new System.Drawing.Point(16, 413);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(213, 48);
            this.BillBtn.TabIndex = 30;
            this.BillBtn.Text = "Billing";
            this.BillBtn.UseVisualStyleBackColor = true;
            this.BillBtn.Click += new System.EventHandler(this.BillBtn_Click);
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItemsBtn.Image")));
            this.ItemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemsBtn.Location = new System.Drawing.Point(16, 157);
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Size = new System.Drawing.Size(213, 48);
            this.ItemsBtn.TabIndex = 27;
            this.ItemsBtn.Text = "Items";
            this.ItemsBtn.UseVisualStyleBackColor = true;
            this.ItemsBtn.Click += new System.EventHandler(this.ItemsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(287, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total money earned today: ";
            // 
            // CashLbl
            // 
            this.CashLbl.AutoSize = true;
            this.CashLbl.Font = new System.Drawing.Font("Verdana", 12F);
            this.CashLbl.Location = new System.Drawing.Point(379, 178);
            this.CashLbl.Name = "CashLbl";
            this.CashLbl.Size = new System.Drawing.Size(0, 18);
            this.CashLbl.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightCyan;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(280, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 23);
            this.label14.TabIndex = 46;
            this.label14.Text = "Today\'s Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F);
            this.label4.Location = new System.Drawing.Point(290, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cash: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.Location = new System.Drawing.Point(288, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Mobile: ";
            // 
            // MobileLbl
            // 
            this.MobileLbl.AutoSize = true;
            this.MobileLbl.Font = new System.Drawing.Font("Verdana", 12F);
            this.MobileLbl.Location = new System.Drawing.Point(381, 216);
            this.MobileLbl.Name = "MobileLbl";
            this.MobileLbl.Size = new System.Drawing.Size(0, 18);
            this.MobileLbl.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F);
            this.label9.Location = new System.Drawing.Point(290, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "Card: ";
            // 
            // CardLbl
            // 
            this.CardLbl.AutoSize = true;
            this.CardLbl.Font = new System.Drawing.Font("Verdana", 12F);
            this.CardLbl.Location = new System.Drawing.Point(374, 256);
            this.CardLbl.Name = "CardLbl";
            this.CardLbl.Size = new System.Drawing.Size(0, 18);
            this.CardLbl.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F);
            this.label12.Location = new System.Drawing.Point(537, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 58;
            this.label12.Text = "Total: ";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Verdana", 12F);
            this.TotalLbl.Location = new System.Drawing.Point(620, 217);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(0, 18);
            this.TotalLbl.TabIndex = 57;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.Teal;
            this.DownloadBtn.FlatAppearance.BorderSize = 0;
            this.DownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.DownloadBtn.ForeColor = System.Drawing.Color.White;
            this.DownloadBtn.Location = new System.Drawing.Point(507, 658);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(272, 49);
            this.DownloadBtn.TabIndex = 60;
            this.DownloadBtn.Text = "Download all sales as PDF";
            this.DownloadBtn.UseVisualStyleBackColor = false;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // ReportList
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.ReportList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.ReportList.ColumnHeadersHeight = 4;
            this.ReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportList.DefaultCellStyle = dataGridViewCellStyle24;
            this.ReportList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReportList.Location = new System.Drawing.Point(250, 330);
            this.ReportList.Name = "ReportList";
            this.ReportList.RowHeadersVisible = false;
            this.ReportList.Size = new System.Drawing.Size(772, 303);
            this.ReportList.TabIndex = 61;
            this.ReportList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReportList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReportList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReportList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReportList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReportList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReportList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReportList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReportList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReportList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReportList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReportList.ThemeStyle.HeaderStyle.Height = 4;
            this.ReportList.ThemeStyle.ReadOnly = false;
            this.ReportList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReportList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReportList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReportList.ThemeStyle.RowsStyle.Height = 22;
            this.ReportList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReportList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F);
            this.label16.Location = new System.Drawing.Point(540, 301);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 18);
            this.label16.TabIndex = 62;
            this.label16.Text = "Report List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 723);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ReportList);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CardLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MobileLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CashLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Report";
            this.Text = "Report";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button CustBtn;
        private System.Windows.Forms.Button BillBtn;
        private System.Windows.Forms.Button ItemsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CashLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MobileLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CardLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Button DownloadBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ReportList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}