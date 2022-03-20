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
    
    public partial class UCAddProduct : UserControl
    {
        private Products products;
        private Users user;
        private bool increase;
        public UCAddProduct()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Quantity));
            comboBox2.DisplayMember = "Description";
            comboBox2.DataSource = Enum.GetValues(typeof(VAT)).Cast<Enum>().Select(value => new { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();


            label12.Visible = false;
            numericUpDown7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            UCProduct termekek = new UCProduct(user);
            MainControlCLass.showControl(termekek, Content);
        }
        internal UCAddProduct (Users user) : this()
        {
            this.user = user;
        }
        internal UCAddProduct (Products products, Users user, bool increase) : this()
        {
            this.increase = increase;
            this.user = user;
            this.products = products;
            textBox1.Text = products.ProductName;
            textBox2.Text = products.ProductNumber;
            comboBox1.SelectedItem = products.Quantity;
            comboBox2.SelectedIndex = (int)products.Vat;
            numericUpDown1.Value = (decimal)products.NettoBuyPrice;
            numericUpDown2.Value = (decimal)products.BruttoBuyPrice;
            numericUpDown3.Value = (decimal)products.NettoSellPrice;
            numericUpDown4.Value = (decimal)products.BruttoSellPrice;
            numericUpDown5.Value = products.Stock;
            numericUpDown6.Value = products.MinStock;

            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                numericUpDown5.Enabled = false;
                numericUpDown6.Enabled = false;
            }
            if (increase == true)
            {
                label3.Text = "Termék bevételezése";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
                numericUpDown6.Enabled = false;
                numericUpDown7.Visible = true;
                label12.Visible = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (products == null)
                {
                    products = new Products(textBox1.Text, textBox2.Text, (Quantity)comboBox1.SelectedItem, (VAT)comboBox2.SelectedIndex, Convert.ToDouble(numericUpDown1.Value), Convert.ToDouble(numericUpDown2.Value), Convert.ToDouble(numericUpDown3.Value), Convert.ToDouble(numericUpDown4.Value), (int)numericUpDown5.Value, (int)numericUpDown6.Value);
                    DBConnect.AddNewProduct(products);
                }
                else if (increase == true)
                {
                    products.ProductName = textBox1.Text;
                    products.ProductNumber = textBox2.Text;
                    products.Quantity = (Quantity)comboBox1.SelectedItem;
                    products.Vat = (VAT)comboBox2.SelectedIndex;
                    products.NettoBuyPrice = (double)numericUpDown1.Value;
                    products.BruttoBuyPrice = (double)numericUpDown2.Value;
                    products.NettoSellPrice = (double)numericUpDown3.Value;
                    products.BruttoSellPrice = (double)numericUpDown4.Value;
                    products.Stock = (int)numericUpDown5.Value + (int)numericUpDown7.Value;
                    products.MinStock = (int)numericUpDown6.Value;
                    DBConnect.ModifyProduct(products);
                }
                else
                {
                    products.ProductName = textBox1.Text;
                    products.ProductNumber = textBox2.Text;
                    products.Quantity = (Quantity)comboBox1.SelectedItem;
                    products.Vat = (VAT)comboBox2.SelectedIndex;
                    products.NettoBuyPrice = (double)numericUpDown1.Value;
                    products.BruttoBuyPrice = (double)numericUpDown2.Value;
                    products.NettoSellPrice = (double)numericUpDown3.Value;
                    products.BruttoSellPrice = (double)numericUpDown4.Value;
                    products.Stock = (int)numericUpDown5.Value;
                    products.MinStock = (int)numericUpDown6.Value;
                    DBConnect.ModifyProduct(products);
                }
                UCProduct termekUc = new UCProduct(user, increase);
                MainControlCLass.showControl(termekUc, Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && numericUpDown2.Value == 0)
            {
                numericUpDown2.Value = (decimal)(Convert.ToDouble(numericUpDown1.Value) * 1.27);
            }
            else if (comboBox2.SelectedIndex == 1 && numericUpDown2.Value == 0)
            {
                numericUpDown2.Value = (decimal)(Convert.ToDouble(numericUpDown1.Value) * 1.18);
            }
            else if (comboBox2.SelectedIndex == 2 && numericUpDown2.Value == 0)
            {
                numericUpDown2.Value = (decimal)(Convert.ToDouble(numericUpDown1.Value) * 1.05); 
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = (decimal)(Convert.ToDouble(numericUpDown2.Value) / 1.27); 
            }
            else if (comboBox2.SelectedIndex == 1 && numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = (decimal)(Convert.ToDouble(numericUpDown2.Value) / 1.27);
            }
            else if (comboBox2.SelectedIndex == 2 && numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = (decimal)(Convert.ToDouble(numericUpDown2.Value) / 1.27);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && numericUpDown4.Value == 0)
            {
                numericUpDown4.Value = (decimal)(Convert.ToDouble(numericUpDown3.Value) * 1.27);
            }
            else if (comboBox2.SelectedIndex == 1 && numericUpDown4.Value == 0)
            {
                numericUpDown4.Value = (decimal)(Convert.ToDouble(numericUpDown3.Value) * 1.18);
            }
            else if (comboBox2.SelectedIndex == 2 && numericUpDown4.Value == 0)
            {
                numericUpDown4.Value = (decimal)(Convert.ToDouble(numericUpDown3.Value) * 1.05);
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && numericUpDown3.Value == 0)
            {
                numericUpDown3.Value = (decimal)(Convert.ToDouble(numericUpDown4.Value) / 1.27);
            }
            else if (comboBox2.SelectedIndex == 1 && numericUpDown3.Value == 0)
            {
                numericUpDown3.Value = (decimal)(Convert.ToDouble(numericUpDown4.Value) / 1.18);
            }
            else if (comboBox2.SelectedIndex == 2 && numericUpDown3.Value == 0)
            {
                numericUpDown3.Value = (decimal)(Convert.ToDouble(numericUpDown4.Value) / 1.05);
            }
        }
    }
}
