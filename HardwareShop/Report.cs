using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace HardwareShop
{
    public partial class Report : Form
    {
        functions Con;
        public Report()
        {
            InitializeComponent();
            Con = new functions();
            ShowDailyReport();
        }
        private void ShowDailyReport()
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            string Query = string.Format(@"
                select b.BCode as [Bill No], 
                       isnull(c.Name, 'Unknown') as [Customer], 
                       b.Amount as [Amount (€)], 
                       b.PaymentMode as [Payment Mode]
                from BillingTbl b
                left join CustomerTbl c on b.Customer = c.CustCode
                where b.BDate = '{0}'", today);

            DataTable dt = Con.GetData(Query);
            ReportList.DataSource = dt;
            ReportList.ColumnHeadersHeight = 40;

            string CashQuery = string.Format("select isnull(SUM(Amount), 0) from BillingTbl where BDate = '{0}' and PaymentMode = 'Cash'", today);
            int cashTotal = Convert.ToInt32(Con.GetData(CashQuery).Rows[0][0]);
            CashLbl.Text = "€ " + cashTotal;

            string MobileQuery = string.Format("select isnull(SUM(Amount), 0) from BillingTbl where BDate = '{0}' and PaymentMode = 'Mobile'", today);
            int mobileTotal = Convert.ToInt32(Con.GetData(MobileQuery).Rows[0][0]);
            MobileLbl.Text = "€ " + mobileTotal;

            string CardQuery = string.Format("select isnull(SUM(Amount), 0) from BillingTbl where BDate = '{0}' and PaymentMode = 'Card'", today);
            int cardTotal = Convert.ToInt32(Con.GetData(CardQuery).Rows[0][0]);
            CardLbl.Text = "€ " + cardTotal;

            TotalLbl.Text = "€ " + (cashTotal + mobileTotal + cardTotal);
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

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            reportForm.Show();
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

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (ReportList.Rows.Count == 0)
            {
                MessageBox.Show("No data to download!");
                return;
            }

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.FileName = "DailyReport_" + DateTime.Today.ToString("yyyyMMdd");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                    doc.Open();

                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f);
                    iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11f);
                    iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10f);

                    doc.Add(new iTextSharp.text.Paragraph("HARDWARE SHOP", titleFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new iTextSharp.text.Paragraph("Daily Report - " + DateTime.Today.ToString("dd/MM/yyyy"), headerFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    // Summary section
                    doc.Add(new iTextSharp.text.Paragraph("Cash:    " + CashLbl.Text, normalFont));
                    doc.Add(new iTextSharp.text.Paragraph("Mobile:  " + MobileLbl.Text, normalFont));
                    doc.Add(new iTextSharp.text.Paragraph("Card:    " + CardLbl.Text, normalFont));
                    doc.Add(new iTextSharp.text.Paragraph("Total:   " + TotalLbl.Text, headerFont));
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    // Table
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;

                    foreach (string header in new[] { "Bill No", "Customer", "Amount (€)", "Payment Mode" })
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                        cell.BackgroundColor = new BaseColor(211, 211, 211);
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 5f;
                        table.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in ReportList.Rows)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(row.Cells[i].Value?.ToString() ?? "", normalFont));
                            cell.Padding = 4f;
                            table.AddCell(cell);
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                    MessageBox.Show("Daily report saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
