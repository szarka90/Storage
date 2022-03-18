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
    public partial class UCProduct : UserControl
    {
        List<Products> products;
        Users user;
        bool increase;
        public UCProduct()
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
        internal UCProduct(Users user) : this()
        {
            this.user = user;

            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                button3.Enabled = false;
            }
        }
        internal UCProduct(Users user, bool increase) : this()
        {
            this.user = user;
            this.increase = increase;

            if (increase == true)
            {
                button2.Text = "Termék bevételezése";
                button1.Visible = false;
                button3.Visible = false;
                label3.Text = "Termékek bevételezése";
            }

            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                button3.Visible = false;
            }
        }
        public void DataGridViewUpdate()
        {
            products = DBConnect.ListProducts();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (Convert.ToInt32(row.Cells[7].Value) < Convert.ToInt32(row.Cells[8].Value))
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Int32.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()) < Int32.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }*/
        }
        public void DataGridViewSearch()
        {
            products = DBConnect.SearchProduct(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UCAddProduct addProduct = new UCAddProduct(user);
            MainControlCLass.showControl(addProduct, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                bool increase;
                if (button2.Text == "Termék módosítása")
                {
                    increase = false;
                }
                else
                {
                    increase = true;
                }
                UCAddProduct addProduct = new UCAddProduct(dataGridView1.CurrentRow.DataBoundItem as Products, user, increase);
                MainControlCLass.showControl(addProduct, Content);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
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
                        DBConnect.DeleteProduct(dataGridView1.CurrentRow.DataBoundItem as Products);
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
