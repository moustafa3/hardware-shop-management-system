namespace HardwareShop
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CustBtn = new System.Windows.Forms.Button();
            this.BillBtn = new System.Windows.Forms.Button();
            this.CatBtn = new System.Windows.Forms.Button();
            this.ItemsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CategoriesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SalesBtn);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Controls.Add(this.CustBtn);
            this.panel1.Controls.Add(this.BillBtn);
            this.panel1.Controls.Add(this.CatBtn);
            this.panel1.Controls.Add(this.ItemsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 784);
            this.panel1.TabIndex = 29;
            // 
            // SalesBtn
            // 
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.Location = new System.Drawing.Point(16, 574);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(213, 48);
            this.SalesBtn.TabIndex = 58;
            this.SalesBtn.Text = "Daily Report";
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(16, 722);
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
            this.CustBtn.Location = new System.Drawing.Point(16, 389);
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
            this.BillBtn.Location = new System.Drawing.Point(16, 484);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(213, 48);
            this.BillBtn.TabIndex = 30;
            this.BillBtn.Text = "Billing";
            this.BillBtn.UseVisualStyleBackColor = true;
            this.BillBtn.Click += new System.EventHandler(this.BillBtn_Click);
            // 
            // CatBtn
            // 
            this.CatBtn.Image = ((System.Drawing.Image)(resources.GetObject("CatBtn.Image")));
            this.CatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CatBtn.Location = new System.Drawing.Point(16, 288);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(213, 48);
            this.CatBtn.TabIndex = 29;
            this.CatBtn.Text = "Categories";
            this.CatBtn.UseVisualStyleBackColor = true;
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItemsBtn.Image")));
            this.ItemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemsBtn.Location = new System.Drawing.Point(16, 192);
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
            this.panel3.Location = new System.Drawing.Point(244, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 70);
            this.panel3.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(276, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hardware Shop Management System";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightCyan;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(253, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(272, 23);
            this.label14.TabIndex = 57;
            this.label14.Text = "Categories Management";
            // 
            // CategoriesList
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.CategoriesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.CategoriesList.ColumnHeadersHeight = 4;
            this.CategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesList.DefaultCellStyle = dataGridViewCellStyle12;
            this.CategoriesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesList.Location = new System.Drawing.Point(244, 359);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.RowHeadersVisible = false;
            this.CategoriesList.RowHeadersWidth = 51;
            this.CategoriesList.RowTemplate.Height = 24;
            this.CategoriesList.Size = new System.Drawing.Size(1058, 414);
            this.CategoriesList.TabIndex = 55;
            this.CategoriesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoriesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoriesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoriesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoriesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CategoriesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoriesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoriesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoriesList.ThemeStyle.HeaderStyle.Height = 4;
            this.CategoriesList.ThemeStyle.ReadOnly = false;
            this.CategoriesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoriesList.ThemeStyle.RowsStyle.Height = 24;
            this.CategoriesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoriesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesList_CellClick);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(398, 253);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(203, 49);
            this.AddBtn.TabIndex = 54;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Teal;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(655, 253);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(203, 49);
            this.EditBtn.TabIndex = 53;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(918, 253);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(203, 49);
            this.DeleteBtn.TabIndex = 52;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Category Name";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(655, 169);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(203, 27);
            this.NameTb.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(669, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 18);
            this.label13.TabIndex = 56;
            this.label13.Text = "Categories List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 784);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CategoriesList);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView CategoriesList;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CustBtn;
        private System.Windows.Forms.Button BillBtn;
        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button ItemsBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}