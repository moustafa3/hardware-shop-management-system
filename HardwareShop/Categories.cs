using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace HardwareShop
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            Con = new functions();
            ShowCategories();
        }
        functions Con;
        private void ShowCategories()
        {
            string Query = "select * from CategoryTbl";
            CategoriesList.DataSource = Con.GetData(Query);
            CategoriesList.ColumnHeadersHeight = 40;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Query = "insert into CategoryTbl values ('{0}')";
                    Query = string.Format(Query, Name);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Updated!");
                    NameTb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;

        private void CategoriesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NameTb.Text = CategoriesList.SelectedRows[0].Cells[1].Value.ToString();
                if (NameTb.Text == "")
                    Key = 0;
                else
                    Key = Convert.ToInt32(CategoriesList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Query = "update CategoryTbl set CatName = '{0}' where CatCode = {1}";
                    Query = string.Format(Query, Name, Key);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Updated!");
                    NameTb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string checkQuery = string.Format("select count(*) from ItemTbl where ItCategory = {0}", Key);
                    int count = Convert.ToInt32(Con.GetData(checkQuery).Rows[0][0]);
                    if (count > 0)
                    {
                        MessageBox.Show("Cannot delete! This category has " + count + " linked item(s).");
                        return;
                    }
                    string Name = NameTb.Text;
                    string Query = "Delete from CategoryTbl where CatCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Deleted!");
                    NameTb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            Items itemsForm = new Items();
            itemsForm.Show();
            this.Hide();
        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();
            categoriesForm.Show();
            this.Hide();
        }

        private void CustBtn_Click(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.Show();
            this.Hide();
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            Billing billingForm = new Billing();
            billingForm.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            Report ReportForm = new Report();
            ReportForm.Show();
            this.Hide();
        }
    }
}
