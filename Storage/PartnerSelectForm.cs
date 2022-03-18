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
    public partial class PartnerSelectForm : Form
    {
        internal PartnerClass partner { get; set; }
        List<PartnerClass> partners;
        public PartnerSelectForm()
        {
            InitializeComponent();
            try
            {
                DBConnect.InitDB();
                DataGridViewFrissites();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DataGridViewFrissites()
        {
            partners = DBConnect.ListedPartners();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partners;
        }
        public void DataGridViewKereses()
        {
            partners = DBConnect.SearchPartner(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partners;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewKereses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            partner = (PartnerClass)dataGridView1.CurrentRow.DataBoundItem;            
        }
    }
}
