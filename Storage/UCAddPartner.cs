using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;


namespace Storage
{
    public partial class UCAddPartner : UserControl
    {
        private PartnerClass partner;
        List<Contact> kapcsolattartos;
        private Users user;
        public UCAddPartner()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Description";
            comboBox1.DataSource = Enum.GetValues(typeof(TypeOfPartner)).Cast<Enum>().Select(value => new { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();
        }
        internal UCAddPartner(Users user) : this()
        {
            this.user = user;           
        }
        internal PartnerClass Partner
        {
            get => partner;
        }
        internal UCAddPartner (PartnerClass partner, Users user) : this()
        {
            this.user = user;
            this.partner = partner;
            comboBox1.SelectedIndex = (int)partner.Type;
            textBox17.Text = partner.Name;
            textBox16.Text = partner.TaxNumber;
            textBox1.Text = partner.BillingCountry;
            textBox2.Text = partner.BillingPostcode;
            textBox3.Text = partner.BillingCity;
            textBox4.Text = partner.BillingAddress;
            textBox10.Text = partner.DeliveryCountry;
            textBox9.Text = partner.DeliveryPostcode;
            textBox8.Text = partner.DeiveryCity;
            textBox7.Text = partner.DeliveryAddress;
            textBox14.Text = partner.Web;
            textBox15.Text = partner.BankAccount;
            textBox5.Text = partner.Comment;

            label1.Text = "Partner módosítása";
            groupBox5.Enabled = true;

            kapcsolattartos = DBConnect.ListedContacts(partner);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kapcsolattartos;

        }        
        private void button3_Click(object sender, EventArgs e)
        {        
            UCPartner partner = new UCPartner(user);          
            MainControlCLass.showControl(partner, Content);        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (partner == null)
                {
                    partner = new PartnerClass((TypeOfPartner)comboBox1.SelectedIndex, textBox17.Text, textBox16.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox10.Text, textBox9.Text, textBox8.Text, textBox7.Text, textBox14.Text, textBox15.Text, textBox5.Text);
                    DBConnect.AddNewPartner(partner);
                }
                else
                {
                    partner.Type = (TypeOfPartner)comboBox1.SelectedIndex;
                    partner.Name = textBox17.Text;
                    partner.TaxNumber = textBox16.Text;
                    partner.BillingCountry = textBox1.Text;
                    partner.BillingPostcode = textBox2.Text;
                    partner.BillingCity = textBox3.Text;
                    partner.BillingAddress = textBox4.Text;
                    partner.DeliveryCountry = textBox10.Text;
                    partner.DeliveryPostcode = textBox9.Text;
                    partner.DeiveryCity = textBox8.Text;
                    partner.DeliveryAddress = textBox7.Text;
                    partner.Web = textBox14.Text;
                    partner.BankAccount = textBox15.Text;
                    partner.Comment = textBox5.Text;
                    DBConnect.ModificatePartner(partner);
                }
                UCPartner partnerUc = new UCPartner(user);
                MainControlCLass.showControl(partnerUc, Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox1.Text;
            textBox9.Text = textBox2.Text;
            textBox8.Text = textBox3.Text;
            textBox7.Text = textBox4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {           
            UCContact contact = new UCContact(partner,user);
            MainControlCLass.showControl(contact, Content);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                UCContact ucContact = new UCContact(partner, dataGridView1.CurrentRow.DataBoundItem as Contact, user);
                MainControlCLass.showControl(ucContact, Content);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
