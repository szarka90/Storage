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
    public partial class UCAddOrders : UserControl
    {
        private Orders orders;
        PartnerClass partner;
        List<PartnerClass> company;
        List<Users> users;
        List<Products> products = new List<Products>();
        List<Products> stock = new List<Products>();
        List<Products> deletedProducts = new List<Products>();
        List<Products> addproducts = new List<Products>();
        Products product;
        bool changedOrder = false;
        private Users user;

        
        public UCAddOrders()
        {
            InitializeComponent();
            try
            {
                DBConnect.InitDB();
                users = DBConnect.ListUsers();
                company = DBConnect.CompanyDataReading();
                stock = DBConnect.ListProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            userCbx.DataSource = users;
            paymentCbx.DisplayMember = "Description";
            paymentCbx.DataSource = Enum.GetValues(typeof(TermsOfPayment)).Cast<Enum>().Select(value => new { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();
            if (paymentCbx.SelectedIndex == 0)
            {
                dateTimePicker3.Value = dateTimePicker1.Value;
                dateTimePicker3.Enabled = false;
            }
            checkBox1.Enabled = false;

        }
        internal UCAddOrders( Users user) : this()
        {
            this.user = user;
            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                button3.Enabled = false;
            }
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == user.Id)
                {
                    userCbx.SelectedIndex = i;
                }
            }
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
        }
        internal UCAddOrders(Orders order, Users user) : this()
        {
            this.partner = order.Partner;
            this.user = user;
            this.orders = order;
            textBox1.Text = order.Partner.Name;
            textBox2.Text = order.Partner.BillingCountry + Environment.NewLine + order.Partner.BillingPostcode + " " + order.Partner.BillingCity + "," + Environment.NewLine + order.Partner.BillingAddress;
            dateTimePicker1.Value = order.OrderDate;
            dateTimePicker2.Value = order.CompletionDate;
            dateTimePicker3.Value = order.PaymentDeadline;
            paymentCbx.SelectedIndex = (int)order.TermsOfPayment;
            dataGridView1.DataSource = order.Product;
            dateTimePicker1.Enabled = false;
            products.AddRange(order.Product);
            label8.Text = nettoTotalAmount(products).ToString() + " Ft";
            label9.Text = bruttoTotalAmount(products).ToString() + " Ft";
            paymentCbx.SelectedIndex = (int)order.TermsOfPayment;
            changedOrder = true;
            label3.Text = "Megrendelés módosítása";

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == order.User.Name)
                {
                    userCbx.SelectedIndex = i;
                }
            }
            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                button3.Enabled = false;
            }
            if (order.Innoviced == true)
            {
                button7.Text = "Számla megtekintése";
                label3.Text = "Számla megtekintése";
                checkBox1.Checked = true;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                button5.Enabled = false;
            }
        }       
        public void DataGridViewUpdate()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }
        //Add new partner button
        private void button4_Click(object sender, EventArgs e)
        {
            PartnerSelectForm partner = new PartnerSelectForm();
            if (partner.ShowDialog() == DialogResult.OK)
            {
                this.partner = partner.partner;
                textBox1.Text = partner.partner.Name;
                textBox2.Text = partner.partner.BillingCountry + Environment.NewLine + partner.partner.BillingPostcode + " " + partner.partner.BillingCity + "," + Environment.NewLine + partner.partner.BillingAddress;
            }
        }
        //Add new item button
        private void button1_Click(object sender, EventArgs e)
        {
            ProductSelectForm product = new ProductSelectForm(orders, stock);
            if (product.ShowDialog() == DialogResult.OK)
            {
                Products newProduct = new Products(product.product.Id, product.product.ProductName, product.product.ProductNumber, product.product.Quantity, product.product.Vat, product.product.NettoBuyPrice, product.product.BruttoBuyPrice, product.product.NettoSellPrice, product.product.BruttoSellPrice, product.stockChanged, product.product.MinStock);
                bool productIsExist = false;
                if (orders == null)
                {                
                    if (products != null)
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i].Id == product.product.Id)
                            {
                                products[i].Stock += product.stockChanged;
                                productIsExist = true;
                            }
                        }
                    }
                    if (productIsExist == false)
                    {
                        products.Add(newProduct);

                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = products;
                    label8.Text = nettoTotalAmount(products).ToString() + " Ft";
                    label9.Text = bruttoTotalAmount(products).ToString() + " Ft";
                }
                else
                {
                    if (changedOrder == true)
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i].Id == product.product.Id)
                            {
                                products[i].Stock += newProduct.Stock;
                                addproducts.Add(newProduct);
                                productIsExist = true;
                            }
                        }
                        if (productIsExist == false)
                        {
                            products.Add(newProduct);
                            addproducts.Add(newProduct);
                        } 
                    }
                    else
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i].Id == product.product.Id)
                            {
                                products[i].Stock += newProduct.Stock;
                                productIsExist = true;
                            }
                        }
                        if (productIsExist == false)
                        {
                            products.Add(newProduct);
                        }
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = products;
                    label8.Text = nettoTotalAmount(products).ToString() + " Ft";
                    label9.Text = bruttoTotalAmount(products).ToString() + " Ft";
                }
                
                for (int i = 0; i < stock.Count; i++)
                {
                    if (product.product.Id == stock[i].Id)
                    {
                        stock[i].Stock -= product.stockChanged;
                        break;
                    }
                }

            }

        }
        //Save button
        private void button5_Click(object sender, EventArgs e)
        {
            if (!(partner == null))
            {
                try
                {
                    List<Products> actualStock = new List<Products>();
                    actualStock = DBConnect.ListProducts();
                    //Create new order and reduced item datebase
                    if (orders == null)
                    {
                        orders = new Orders(dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value, (bool)checkBox1.Checked, (TermsOfPayment)paymentCbx.SelectedIndex);
                        DBConnect.AddNewOrders(orders, products, (Users)userCbx.SelectedItem, partner, company[0]);

                        for (int i = 0; i < products.Count; i++)
                        {
                            for (int j = 0; j < actualStock.Count; j++)
                            {
                                if (products[i].Id == actualStock[j].Id)
                                {
                                    int stockChanged = (int)actualStock[j].Stock - (int)products[i].Stock;
                                    DBConnect.StockReduction(products[i], stockChanged);
                                }
                            }
                        }
                        UCOrders ucOrders = new UCOrders(user);
                        MainControlCLass.showControl(ucOrders, Content);
                    }
                    //update order
                    else
                    {
                        orders.OrderDate = dateTimePicker1.Value;
                        orders.CompletionDate = dateTimePicker2.Value;
                        orders.PaymentDeadline = dateTimePicker3.Value;
                        orders.Innoviced = checkBox1.Checked;
                        orders.TermsOfPayment = (TermsOfPayment)paymentCbx.SelectedIndex;
                        DBConnect.UpdateOrders(orders, products, (Users)userCbx.SelectedItem, partner);
                        for (int i = 0; i < deletedProducts.Count; i++)
                        {
                            for (int j = 0; j < actualStock.Count; j++)
                            {
                                if (deletedProducts[i].Id == actualStock[j].Id)
                                {
                                    int stockChanged = (int)deletedProducts[i].Stock + (int)actualStock[j].Stock;
                                    DBConnect.StockReduction(actualStock[j], stockChanged);
                                }
                            }
                        }
                        for (int i = 0; i < addproducts.Count; i++)
                        {
                            for (int j = 0; j < actualStock.Count; j++)
                            {
                                if (addproducts[i].Id == actualStock[j].Id)
                                {
                                    int stockChanged = (int)actualStock[j].Stock - (int)addproducts[i].Stock;
                                    DBConnect.StockReduction(actualStock[j], stockChanged);
                                }
                            }
                        }
                        UCOrders ucOrders = new UCOrders(user);
                        MainControlCLass.showControl(ucOrders, Content);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Kérem válassza ki a megrendelőt!", "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {                     
            UCOrders ucOrders = new UCOrders(user);
            MainControlCLass.showControl(ucOrders, Content);             
        }
        //Delete button
        private void button3_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Biztosan törli a kjelölt elemet?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.CurrentCell != null)
                    {
                        //Delete width updating products in the database
                        product = (Products)dataGridView1.CurrentRow.DataBoundItem;
                        if (orders != null)
                        {
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (product.Id == products[i].Id)
                                {
                                    deletedProducts.Add(products[i]);
                                    products.RemoveAt(i);
                                    DataGridViewUpdate();

                                    label8.Text = nettoTotalAmount(products).ToString() + " Ft";
                                    label9.Text = bruttoTotalAmount(products).ToString() + " Ft";
                                    for (int j = 0; j < stock.Count; j++)
                                    {
                                        if (product.Id == stock[j].Id)
                                        {
                                            stock[j].Stock += product.Stock;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        //Delete without updating products in th database
                        else
                        {
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (product.Id == products[i].Id)
                                {
                                    products.RemoveAt(i);
                                    DataGridViewUpdate();

                                    label8.Text = nettoTotalAmount(products).ToString() + " Ft";
                                    label9.Text = bruttoTotalAmount(products).ToString() + " Ft";
                                    for (int j = 0; j < stock.Count; j++)
                                    {
                                        if (product.Id == stock[j].Id)
                                        {
                                            stock[j].Stock += product.Stock;
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nem lehet törölni elemet", "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }
        //Modify button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    product = (Products)dataGridView1.CurrentRow.DataBoundItem;
                    int stockSelectedItem = 0;
                    int oldStock = product.Stock;
                    for (int i = 0; i < stock.Count; i++)
                    {
                        if (product.Id == stock[i].Id)
                        {
                            stockSelectedItem = stock[i].Stock + product.Stock;
                            break;
                        }
                    }
                    ProductSelectForm product1 = new ProductSelectForm(orders, product, stockSelectedItem);
                    if (product1.ShowDialog() == DialogResult.OK)
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i].Id == product1.product.Id)
                            {
                                products[i].Stock = product1.stockChanged;
                                
                                if (oldStock < products[i].Stock)
                                {
                                    int addStock = product1.stockChanged - oldStock;
                                    Products changedProducts = new Products(product1.product.Id, product1.product.ProductName, product1.product.ProductNumber, product1.product.Quantity, product1.product.Vat, product1.product.NettoBuyPrice, product1.product.BruttoBuyPrice, product1.product.NettoSellPrice, product1.product.BruttoSellPrice, addStock, product1.product.MinStock);
                                    addproducts.Add(changedProducts);
                                }
                                else if (oldStock > products[i].Stock)
                                {
                                    int addStock = oldStock - product1.stockChanged;
                                    Products changedProducts = new Products(product1.product.Id, product1.product.ProductName, product1.product.ProductNumber, product1.product.Quantity, product1.product.Vat, product1.product.NettoBuyPrice, product1.product.BruttoBuyPrice, product1.product.NettoSellPrice, product1.product.BruttoSellPrice, addStock, product1.product.MinStock);
                                    deletedProducts.Add(changedProducts);
                                }
                                break;
                            }
                        }
                        for (int i = 0; i < stock.Count; i++)
                        {
                            if (product1.product.Id == stock[i].Id)
                            {
                                stock[i].Stock = stockSelectedItem - product1.stockChanged;
                                break;
                            }
                        }                        
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = products;
                        label8.Text = nettoTotalAmount(products).ToString() + " Ft";
                        label9.Text = bruttoTotalAmount(products).ToString() + " Ft";                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (orders == null)
            {
                MessageBox.Show("Nem hozható létre számla!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InnoviceForm innoviceForm = new InnoviceForm(orders, label8.Text, label9.Text, user);
                if (innoviceForm.ShowDialog() == DialogResult.OK)
                {
                    checkBox1.Checked = true;
                    button7.Text = "Számla megtekintése";
                    checkBox1.Checked = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    button5.Enabled = false;                   
                }

            }
        }
        private double nettoTotalAmount (List<Products> products)
        {
            double amount = 0;
            List <double> amounts = new List<double>();

            for (int i = 0; i < products.Count; i++)
            {
                amounts.Add(products[i].NettoSellPrice * products[i].Stock);
            }
            for (int i = 0; i < amounts.Count; i++)
            {
                amount += amounts[i];
            }

            return amount;
        }
        private double bruttoTotalAmount(List<Products> products)
        {
            double amount = 0;
            List<double> amounts = new List<double>();

            for (int i = 0; i < products.Count; i++)
            {
                amounts.Add(products[i].BruttoSellPrice * products[i].Stock);
            }
            for (int i = 0; i < amounts.Count; i++)
            {
                amount += amounts[i];
            }

            return amount;
        }

        private void paymentCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentCbx.SelectedIndex == 0)
            {
                dateTimePicker3.Value = dateTimePicker1.Value;
                dateTimePicker3.Enabled = false;
            }
            else
            {
                dateTimePicker3.Enabled = true;
            }
        }
    }
}
