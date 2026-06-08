using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareShop
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Con = new functions();
            ShowCustomers();
        }
        functions Con;

        private void ShowCustomers()
        {
            string Query = "select * from CustomerTbl";
            CustomersList.DataSource = Con.GetData(Query);
            CustomersList.ColumnHeadersHeight = 40;
        }
        

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenderCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    string Query = "insert into CustomerTbl values('{0}','{1}','{2}')";
                    Query = string.Format(Query, Name, Gender, Phone);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Added!");
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenderCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    string Query = "update CustomerTbl set Name = '{0}', Gender = '{1}', Phone = '{2}' where CustCode = '{3}'";
                    Query = string.Format(Query, Name, Gender, Phone, Key);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Updated!");
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void CustomersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersList.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                NameTb.Text = CustomersList.SelectedRows[0].Cells[1].Value.ToString();
                GenderCb.Text = CustomersList.SelectedRows[0].Cells[2].Value.ToString();
                PhoneTb.Text = CustomersList.SelectedRows[0].Cells[3].Value.ToString();

                if (NameTb.Text == "")
                    Key = 0;
                else
                    Key = Convert.ToInt32(CustomersList.SelectedRows[0].Cells[0].Value.ToString());
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

        private void DeleteBtn_Click(object sender, EventArgs e) 
        {
            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string CheckQuery = "select count(*) from BillingTbl where Customer = {0}";
                    CheckQuery = string.Format(CheckQuery, Key);
                    int BillCount = Convert.ToInt32(Con.GetData(CheckQuery).Rows[0][0]);

                    if (BillCount > 0)
                    {
                        DialogResult result = MessageBox.Show(
                            "This customer has " + BillCount + " bill(s) linked to them.\nDeleting will also delete their billing records. Continue?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            string DeleteBills = "Delete from BillingTbl where Customer = {0}";
                            DeleteBills = string.Format(DeleteBills, Key);
                            Con.SetData(DeleteBills);
                        }
                        else
                        {
                            return;
                        }
                    }

                    string Query = "Delete from CustomerTbl where CustCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Deleted!");
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
