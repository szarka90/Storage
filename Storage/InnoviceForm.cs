using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class InnoviceForm : Form
    {
        private Orders orders;
        public InnoviceForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        internal InnoviceForm(Orders order, string nettoAmount, string bruttoAmount, Users user) : this()
        {
            this.orders = order;
            label1.Text = order.CompanyData.Name;
            label2.Text = order.CompanyData.BillingPostcode;
            label3.Text = order.CompanyData.BillingCity;
            label4.Text = order.CompanyData.BillingAddress;
            label5.Text = order.CompanyData.TaxNumber;
            label10.Text = order.Partner.Name;
            label9.Text = order.Partner.BillingPostcode;
            label8.Text = order.Partner.BillingCity;
            label7.Text = order.Partner.BillingAddress;
            label6.Text = order.Partner.TaxNumber;
            label21.Text = order.TermsOfPayment.ToString();
            label25.Text = order.CompletionDate.ToString("yyyy/MM/dd");
            label24.Text = order.PaymentDeadline.ToString("yyyy/MM/dd");
            label12.Text = order.OrderDate.ToString("yyyy/MM/dd");
            label16.Text = nettoAmount;
            label17.Text = bruttoAmount;
            label18.Text = "A számlát az Ügyvitel V1.0 szoftver állította ki, (DEMO változat, adóigazolársa nem alkalmas!) Készítette: " + order.User.Name;
            dataGridView1.DataSource = order.Product;
            if (order.Innoviced == true)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
        private void Print(Panel panel)
        {
            PrinterSettings printer = new PrinterSettings();
            panelPrint = panel;
            getprintarea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel panel)
        {
            memoryimg = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryimg, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(panelPrint);            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Print");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orders.Innoviced = true;
            button1.Enabled = true;
            button2.Enabled = false;
            try
            {
                DBConnect.UpdateOrdersInnoviceStatus(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
