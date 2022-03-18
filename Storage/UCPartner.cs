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
    public partial class UCPartner : UserControl
    {
        List<PartnerClass> partners;
        private Users user;
        public UCPartner()
        {
            InitializeComponent();
            try
            {
                DBConnect.InitDB();
                DataGridViewUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }
        internal UCPartner(Users user) : this()
        {
            this.user = user;
            
            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                button3.Enabled = false;
            }
        }
        public void DataGridViewUpdate()
        {
            partners = DBConnect.ListedPartners();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partners;
        }
        public void DataGridViewSearch()
        {
            partners = DBConnect.SearchPartner(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partners;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            UCAddPartner addPartner = new UCAddPartner(user);
            MainControlCLass.showControl(addPartner, Content);            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {               
                UCAddPartner addPartner = new UCAddPartner(dataGridView1.CurrentRow.DataBoundItem as PartnerClass, user);               
                MainControlCLass.showControl(addPartner, Content);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            string billingCountry = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string billingPostcode = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string billingCity = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string billingAddress = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            billingTbx.Text = billingCountry + Environment.NewLine + billingPostcode + " " + billingCity + "," + Environment.NewLine + billingAddress;                    ;

            string deliveryCountry = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string deliveryPostcode = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string deliveryCity = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string deliveryAddress = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            deliveryTbx.Text = deliveryCountry + Environment.NewLine + deliveryPostcode + " " + deliveryCity + "," + Environment.NewLine + deliveryAddress;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSearch();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {

                    if (MessageBox.Show("Biztosan szeretné törölni a kijelölt elemet?", "Figyelmeztetés!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBConnect.DeletePartner(dataGridView1.CurrentRow.DataBoundItem as PartnerClass);
                        DataGridViewUpdate();
                    }
                }
                else
                {
                    MessageBox.Show("Nincs kijelölt elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
