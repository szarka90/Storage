using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class UCCompanyData : UserControl
    {
        PartnerClass companyData;
        public UCCompanyData()
        {
            InitializeComponent();
            try
            {
                DBConnect.CompanyDataReading();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }
        internal UCCompanyData (PartnerClass companyData) : this()
        {
            this.companyData = companyData;
            textBox17.Text = companyData.Name;
            textBox16.Text = companyData.TaxNumber;
            textBox14.Text = companyData.Web;
            textBox15.Text = companyData.BankAccount;
            textBox5.Text = companyData.Comment;
            textBox1.Text = companyData.BillingCountry;
            textBox2.Text = companyData.BillingPostcode;
            textBox3.Text = companyData.BillingCity;
            textBox4.Text = companyData.BillingAddress;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (companyData == null)
                {
                    companyData = new PartnerClass(textBox17.Text, textBox16.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox14.Text, textBox15.Text, textBox5.Text);
                    DBConnect.CompanyDataAdd(companyData);
                }
                else
                {
                    companyData.Name = textBox17.Text;
                    companyData.TaxNumber = textBox16.Text;
                    companyData.BillingCountry = textBox1.Text;
                    companyData.BillingPostcode = textBox2.Text;
                    companyData.BillingCity = textBox3.Text;
                    companyData.BillingAddress = textBox4.Text;
                    companyData.Web = textBox14.Text;
                    companyData.BankAccount = textBox15.Text;
                    companyData.Comment = textBox5.Text;
                    DBConnect.CompanyDataModify(companyData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
