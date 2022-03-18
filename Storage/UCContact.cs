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
    public partial class UCContact : UserControl
    {
        private PartnerClass partner;
        private Contact kapcsolattarto;
        private Users user;
        public UCContact()
        {
            InitializeComponent();
            UCAddPartner partnerFelvitel = new UCAddPartner();           
        }
        internal PartnerClass Partner
        {
            get => partner;
        }
        internal UCContact (PartnerClass partner, Users user) : this()
        {
            this.user = user;
            this.partner = partner;
            textBox1.Text = partner.Name;
        }
        internal UCContact(PartnerClass partner, Contact kapcsolattarto, Users user) : this()
        {
            this.user = user;
            this.partner = partner;
            this.kapcsolattarto = kapcsolattarto;
            textBox1.Text = partner.Name;
            textBox2.Text = kapcsolattarto.Name;
            textBox3.Text = kapcsolattarto.PhoneNumber;
            textBox4.Text = kapcsolattarto.Email;
            textBox5.Text = kapcsolattarto.Title;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UCAddPartner addPartner = new UCAddPartner(partner, user);
            MainControlCLass.showControl(addPartner, Content);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kapcsolattarto == null)
                {                
                    kapcsolattarto = new Contact((int)partner.Id, textBox2.Text, textBox3.Text,textBox4.Text, textBox5.Text);
                    DBConnect.AddNewContact(kapcsolattarto);
                }
                else
                {
                    kapcsolattarto.Name = textBox2.Text;
                    kapcsolattarto.PhoneNumber = textBox3.Text;
                    kapcsolattarto.Email = textBox4.Text;
                    kapcsolattarto.Title = textBox5.Text;
                    DBConnect.ModifyContact(kapcsolattarto);
                }
                UCAddPartner addPartner = new UCAddPartner(partner, user);
                MainControlCLass.showControl(addPartner, Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
