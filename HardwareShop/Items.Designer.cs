namespace HardwareShop
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.CatBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CustBtn = new System.Windows.Forms.Button();
            this.BillBtn = new System.Windows.Forms.Button();
            this.ItemsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ManufacturerTb = new System.Windows.Forms.TextBox();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ItemList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(244, 825);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // SalesBtn
            // 
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.Location = new System.Drawing.Point(16, 585);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(213, 48);
            this.SalesBtn.TabIndex = 36;
            this.SalesBtn.Text = "Daily Report";
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // CatBtn
            // 
            this.CatBtn.Image = ((System.Drawing.Image)(resources.GetObject("CatBtn.Image")));
            this.CatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CatBtn.Location = new System.Drawing.Point(16, 299);
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
            this.LogoutBtn.Location = new System.Drawing.Point(16, 766);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(213, 48);
            this.LogoutBtn.TabIndex = 34;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CustBtn
            // 
            this.CustBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustBtn.Image")));
            this.CustBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustBtn.Location = new System.Drawing.Point(16, 397);
            this.CustBtn.Name = "CustBtn";
            this.CustBtn.Size = new System.Drawing.Size(213, 48);
            this.CustBtn.TabIndex = 31;
            this.CustBtn.Text = "Customer";
            this.CustBtn.UseVisualStyleBackColor = true;
            this.CustBtn.Click += new System.EventHandler(this.CustBtn_Click);
            // 
            // BillBtn
            // 
            this.BillBtn.Image = ((System.Drawing.Image)(resources.GetObject("BillBtn.Image")));
            this.BillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillBtn.Location = new System.Drawing.Point(16, 492);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(213, 48);
            this.BillBtn.TabIndex = 30;
            this.BillBtn.Text = "Billing";
            this.BillBtn.UseVisualStyleBackColor = true;
            this.BillBtn.Click += new System.EventHandler(this.BillBtn_Click);
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItemsBtn.Image")));
            this.ItemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemsBtn.Location = new System.Drawing.Point(16, 200);
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Size = new System.Drawing.Size(213, 48);
            this.ItemsBtn.TabIndex = 27;
            this.ItemsBtn.Text = "Items";
            this.ItemsBtn.UseVisualStyleBackColor = true;
            this.ItemsBtn.Click += new System.EventHandler(this.ItemsBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(242, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 70);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(276, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hardware Shop Management System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Item";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(345, 184);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(184, 27);
            this.NameTb.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(809, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Price (€)";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(810, 184);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(184, 27);
            this.PriceTb.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1033, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Stock";
            // 
            // StockTb
            // 
            this.StockTb.Location = new System.Drawing.Point(1035, 184);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(184, 27);
            this.StockTb.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(672, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Manufacturer";
            // 
            // ManufacturerTb
            // 
            this.ManufacturerTb.Location = new System.Drawing.Point(677, 271);
            this.ManufacturerTb.Name = "ManufacturerTb";
            this.ManufacturerTb.Size = new System.Drawing.Size(184, 27);
            this.ManufacturerTb.TabIndex = 19;
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "PC Parts",
            "Laptop Parts",
            "Phone Parts",
            "Playstation Parts"});
            this.CatCb.Location = new System.Drawing.Point(580, 184);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(181, 26);
            this.CatCb.TabIndex = 21;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(921, 334);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(203, 49);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Teal;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(658, 334);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(203, 49);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(401, 334);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(203, 49);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ItemList
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ItemList.ColumnHeadersHeight = 4;
            this.ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemList.DefaultCellStyle = dataGridViewCellStyle15;
            this.ItemList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemList.Location = new System.Drawing.Point(260, 440);
            this.ItemList.Name = "ItemList";
            this.ItemList.RowHeadersVisible = false;
            this.ItemList.RowHeadersWidth = 51;
            this.ItemList.RowTemplate.Height = 24;
            this.ItemList.Size = new System.Drawing.Size(1054, 358);
            this.ItemList.TabIndex = 25;
            this.ItemList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ItemList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemList.ThemeStyle.HeaderStyle.Height = 4;
            this.ItemList.ThemeStyle.ReadOnly = false;
            this.ItemList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemList.ThemeStyle.RowsStyle.Height = 24;
            this.ItemList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemList_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 403);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Items List";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightCyan;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(268, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "Items Management";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 825);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ManufacturerTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ManufacturerTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.ComboBox CatCb;
        private Guna.UI2.WinForms.Guna2DataGridView ItemList;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button CustBtn;
        private System.Windows.Forms.Button BillBtn;
        private System.Windows.Forms.Button ItemsBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}