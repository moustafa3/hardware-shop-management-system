using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace HardwareShop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            Con = new functions();
            InitializeComponent();
            ShowItems();

            ClientBill.Columns.Clear();
            ClientBill.Columns.Add("No", "No");
            ClientBill.Columns.Add("Name", "Name");
            ClientBill.Columns.Add("Price", "Price");
            ClientBill.Columns.Add("Qty", "Qty");
            ClientBill.Columns.Add("Total", "Total");
            ClientBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientBill.ColumnHeadersHeight = 40;
            CashRadio.Checked = true;

        }

        functions Con;
        List<(int Key, int Qty)> BillItems = new List<(int, int)>();
        private void ShowItems()
        {
            string Query = @"select i.ItCode, i.ItName, c.CatName, i.ItPrice, i.ItStock, i.Manufacturer 
                     from ItemTbl i 
                     inner join CategoryTbl c ON i.ItCategory = c.CatCode";
            ItemList.DataSource = Con.GetData(Query);
            ItemList.ColumnHeadersHeight = 40;
        }

        int Key = 0;
        int Stock = 0;

        private void ItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NameTb.Text = ItemList.Rows[e.RowIndex].Cells[1].Value.ToString();
                PriceTb.Text = ItemList.Rows[e.RowIndex].Cells[3].Value.ToString();
                Stock = Convert.ToInt32(ItemList.Rows[e.RowIndex].Cells[4].Value.ToString());

                if (NameTb.Text == "")
                    Key = 0;
                else
                    Key = Convert.ToInt32(ItemList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BillItems.Clear();
            NameTb.Text = "";
            PriceTb.Text = "";
            QtyTb.Text = "";
            CustTb.Text = "";
            ClientBill.Rows.Clear();
            GrdTotal = 0;
            n = 0;
            CurrentCustomer = "";
            GrdTotalLbl.Text = "€ 0";
        }

        string PMethod = "";
        int n = 0;
        int GrdTotal = 0;
        string CurrentCustomer = "";

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PriceTb.Text == "" || QtyTb.Text == "" || NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else if (!int.TryParse(QtyTb.Text, out _))
            {
                MessageBox.Show("Quantity must be a number!");
            }
            else if (!int.TryParse(PriceTb.Text, out _))
            {
                MessageBox.Show("Price must be a number!");
            }
            else
            {
                if (CustTb.Text == "")
                    CustTb.Text = "Unknown";

                if (CurrentCustomer != "" && CustTb.Text != CurrentCustomer)
                {
                    MessageBox.Show("Cannot add item! Current bill belongs to '" + CurrentCustomer + "'. Please reset the bill first.");
                    return;
                }

                string CheckQuery = "select count(*) from CustomerTbl where Name = '{0}'";
                CheckQuery = string.Format(CheckQuery, CustTb.Text);
                int CustomerCount = Convert.ToInt32(Con.GetData(CheckQuery).Rows[0][0]);

                if (CustomerCount == 0 && CustTb.Text != "Unknown")
                {
                    MessageBox.Show("This customer doesn't exist!");
                    return;
                }

                if (CustTb.Text == "Unknown" && CustomerCount == 0)
                {
                    string AddUnknown = "insert into CustomerTbl values('Unknown', 'N/A', 'N/A')";
                    Con.SetData(AddUnknown);
                }

                int alreadyInBill = BillItems.Where(item => item.Key == Key).Sum(item => item.Qty);
                int availableStock = Stock - alreadyInBill;

                if (availableStock < Convert.ToInt32(QtyTb.Text))
                {
                    MessageBox.Show("Not Enough Stock! Available: " + availableStock);
                }
                else
                {
                    int Qte = Convert.ToInt32(QtyTb.Text);
                    int total = Convert.ToInt32(PriceTb.Text) * Qte;
                    ClientBill.Rows.Add(n + 1, NameTb.Text, PriceTb.Text, QtyTb.Text, "€ " + total);
                    n++;
                    CurrentCustomer = CustTb.Text;
                    GrdTotal = GrdTotal + total;
                    GrdTotalLbl.Text = "€ " + GrdTotal;
                    BillItems.Add((Key, Qte));
                    ShowItems();
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("No items in the bill!");
                return;
            }

            if (CustTb.Text == "")
                CustTb.Text = "Unknown";

            try
            {

                // Generate PDF
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.FileName = "Receipt_" + CustTb.Text + "_" + DateTime.Today.ToString("yyyyMMdd");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A5);
                    PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Fonts
                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f);
                    iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11f);
                    iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10f);

                    // Header
                    doc.Add(new iTextSharp.text.Paragraph("HARDWARE SHOP", titleFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new iTextSharp.text.Paragraph("Receipt", headerFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new iTextSharp.text.Paragraph(" "));
                    doc.Add(new iTextSharp.text.Paragraph("Customer: " + CustTb.Text, normalFont));
                    doc.Add(new iTextSharp.text.Paragraph("Date: " + DateTime.Today.ToString("dd/MM/yyyy"), normalFont));
                    doc.Add(new iTextSharp.text.Paragraph("Payment: " + PMethod, normalFont));
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    // Table
                    PdfPTable table = new PdfPTable(5);
                    table.WidthPercentage = 100;

                    // Table Headers
                    foreach (string header in new[] { "No", "Name", "Price", "Qty", "Total" })
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                        cell.BackgroundColor = new BaseColor(211, 211, 211);
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 5f;
                        table.AddCell(cell);
                    }

                    // Table Rows
                    foreach (DataGridViewRow row in ClientBill.Rows)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(row.Cells[i].Value?.ToString() ?? "", normalFont));
                            cell.Padding = 4f;
                            table.AddCell(cell);
                        }
                    }

                    doc.Add(table);
                    doc.Add(new iTextSharp.text.Paragraph(" "));
                    doc.Add(new iTextSharp.text.Paragraph("Grand Total: € " + GrdTotal, headerFont) { Alignment = Element.ALIGN_RIGHT });

                    doc.Close();
                    MessageBox.Show("Receipt saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void CashInBtn_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("No items in the bill!");
                return;
            }

            if (CustTb.Text == "")
                CustTb.Text = "Unknown";

            try
            {
                if (MobileRadio.Checked) PMethod = "Mobile";
                else if (CardRadio.Checked) PMethod = "Card";
                else PMethod = "Cash";

                string CustQuery = "select CustCode from CustomerTbl where Name = '{0}'";
                CustQuery = string.Format(CustQuery, CustTb.Text);
                int CustID = Convert.ToInt32(Con.GetData(CustQuery).Rows[0][0]);

                string Query = "insert into BillingTbl values('{0}',{1},{2},'{3}')";
                Query = string.Format(Query, DateTime.Today.ToString("yyyy-MM-dd"), CustID, GrdTotal, PMethod);
                Con.SetData(Query);

                foreach (var item in BillItems)
                {
                    string StockQuery = "update ItemTbl set ItStock = ItStock - {0} where ItCode = {1}";
                    StockQuery = string.Format(StockQuery, item.Qty, item.Key);
                    Con.SetData(StockQuery);
                }
                BillItems.Clear();
                ShowItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}