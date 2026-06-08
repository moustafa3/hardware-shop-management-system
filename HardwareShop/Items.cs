using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace HardwareShop
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            Con = new functions();
            GetCategories();
            ShowItems();
        }
        functions Con;

        private void GetCategories()
        {
            string Query = "select * from CategoryTbl";
            DataTable dt = Con.GetData(Query);
            CatCb.ValueMember = "CatCode";
            CatCb.DisplayMember = "CatName";
            CatCb.DataSource = dt;
        }


        private void ShowItems()
        {
            string Query = @"select i.ItCode, i.ItName, c.CatName, i.ItPrice, i.ItStock, i.Manufacturer 
                     from ItemTbl i 
                     inner join CategoryTbl c on i.ItCategory = c.CatCode";
            ItemList.DataSource = Con.GetData(Query);
            ItemList.ColumnHeadersHeight = 40;
        }

        int Key = 0;

        private void ItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ItemList.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                try
                {
                    NameTb.Text = ItemList.SelectedRows[0].Cells[1].Value.ToString();
                    PriceTb.Text = ItemList.SelectedRows[0].Cells[3].Value.ToString();
                    StockTb.Text = ItemList.SelectedRows[0].Cells[4].Value.ToString();
                    ManufacturerTb.Text = ItemList.SelectedRows[0].Cells[5].Value.ToString();

                    string catName = ItemList.SelectedRows[0].Cells[2].Value.ToString();
                    foreach (DataRowView row in CatCb.Items)
                    {
                        if (row["CatName"].ToString() == catName)
                        {
                            CatCb.SelectedValue = row["CatCode"];
                            break;
                        }
                    }

                    Key = NameTb.Text == "" ? 0 : Convert.ToInt32(ItemList.SelectedRows[0].Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || CatCb.SelectedIndex == -1 || ManufacturerTb.Text == "" || StockTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    DataRowView selectedRow = (DataRowView)CatCb.SelectedItem;
                    int Cat = Convert.ToInt32(selectedRow["CatCode"].ToString());
                    string Price = PriceTb.Text;
                    string Stock = StockTb.Text;
                    string Man = ManufacturerTb.Text;
                    string Query = "insert into ItemTbl values('{0}','{1}','{2}', '{3}', '{4}')";
                    Query = string.Format(Query, Name, Cat, Price, Stock, Man);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Item Added!");
                    NameTb.Text = "";
                    ManufacturerTb.Text = "";
                    CatCb.SelectedIndex = -1;
                    PriceTb.Text = "";
                    StockTb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || CatCb.SelectedIndex == -1 || ManufacturerTb.Text == "" || StockTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    DataRowView selectedRow = (DataRowView)CatCb.SelectedItem;
                    int Cat = Convert.ToInt32(selectedRow["CatCode"].ToString());
                    string Price = PriceTb.Text;
                    string Stock = StockTb.Text;
                    string Man = ManufacturerTb.Text;
                    string Query = "update ItemTbl set ItName='{0}', ItCategory={1}, ItPrice={2}, ItStock={3}, Manufacturer='{4}' where ItCode={5}";
                    Query = string.Format(Query, Name, Cat, Price, Stock, Man, Key);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Item updated!");
                    NameTb.Text = "";
                    ManufacturerTb.Text = "";
                    CatCb.SelectedIndex = -1;
                    PriceTb.Text = "";
                    StockTb.Text = "";
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select an item to delete!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string Query = "delete from ItemTbl where ItCode = {0}";
                        Query = string.Format(Query, Key);
                        Con.SetData(Query);
                        ShowItems();
                        MessageBox.Show("Item Deleted!");
                        NameTb.Text = "";
                        ManufacturerTb.Text = "";
                        CatCb.SelectedIndex = -1;
                        PriceTb.Text = "";
                        StockTb.Text = "";
                        Key = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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
