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
    public partial class ProductSelectForm : Form
    {
        internal Products product { get; set; }
        internal int stockChanged { get; set; }
        List<Products> products = new List<Products>();
        private Orders orders;
        public ProductSelectForm()
        {
            InitializeComponent();
            try
            {
                DBConnect.InitDB();
                //DataGridViewFrissites();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
        internal ProductSelectForm(Orders order, List<Products> products) : this()
        {
            this.orders = order;
            this.dataGridView1.DataSource = products;
        }
        internal ProductSelectForm(Orders order, Products product, int stock) : this()
        {
            
            this.orders = order;
            this.product = product;           
            numericUpDown1.Value = product.Stock;
            numericUpDown2.Value = product.OrderDiscount;
            product.Stock = stock;
            products.Add(product);
            dataGridView1.DataSource = products;

        }
        public void DataGridViewFrissites()
        {
            products = DBConnect.ListProducts();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }
        public void DataGridViewKereses()
        {
            products = DBConnect.SearchProduct(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
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
            try
            {
                product = (Products)dataGridView1.CurrentRow.DataBoundItem;

                if (product.Stock >= (int)numericUpDown1.Value)
                {
                    if (orders == null)
                    {
                        stockChanged = (int)numericUpDown1.Value;
                        product.OrderDiscount = (int)numericUpDown2.Value;
                        if (numericUpDown2.Value > 0)
                        {
                            product.NettoSellPrice = ((100 - (double)numericUpDown2.Value) / 100) * product.NettoSellPrice;
                            product.BruttoSellPrice = ((100 - (double)numericUpDown2.Value) / 100) * product.BruttoSellPrice;
                        }
                    }
                    else
                    {
                        stockChanged = (int)numericUpDown1.Value;
                        product.OrderDiscount = (int)numericUpDown2.Value;
                        if (numericUpDown2.Value > 0)
                        {
                            product.NettoSellPrice = ((100 - (double)numericUpDown2.Value) / 100) * product.NettoSellPrice;
                            product.BruttoSellPrice = ((100 - (double)numericUpDown2.Value) / 100) * product.BruttoSellPrice;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nem áll rendelkezésre elegendő készlet!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                 
        }
        
    }
}
