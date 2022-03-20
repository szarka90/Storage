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
    public partial class UCOrders : UserControl
    {
        List<Orders> order;
        private Users user;
        public UCOrders()
        {
            InitializeComponent();
            DBConnect.InitDB();
            DataGridViewUpdate();           
            
        }
        internal UCOrders(Users user) : this()
        {
            this.user = user;

            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                button3.Enabled = false;
            }
        }
        public void DataGridViewUpdate()
        {           
            order = DBConnect.ListedOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = order;            
        }
        public void DataGridViewSearch()
        {
            order = DBConnect.SearchOrders(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = order;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCAddOrders addOrders = new UCAddOrders(user);
            MainControlCLass.showControl(addOrders, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {                
                UCAddOrders addOrders = new UCAddOrders(dataGridView1.CurrentRow.DataBoundItem as Orders, user);
                MainControlCLass.showControl(addOrders, Content);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törli a kijelölt elemet?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentCell != null)
                {
                    Orders selectedOrder = (Orders)dataGridView1.CurrentRow.DataBoundItem;
                    if (selectedOrder.Innoviced == false)
                    {
                        List<Products> stock = new List<Products>();
                        stock = DBConnect.ListProducts();
                        for (int i = 0; i < selectedOrder.Product.Count; i++)
                        {
                            for (int j = 0; j < stock.Count; j++)
                            {
                                if (selectedOrder.Product[i].Id == stock[j].Id)
                                {
                                    int stockchanged = (int)selectedOrder.Product[i].Stock + (int)stock[j].Stock;
                                    DBConnect.StockReduction(selectedOrder.Product[i], stockchanged);
                                }
                            }
                        }
                        DBConnect.DetelteOrder(selectedOrder);
                        DataGridViewUpdate();
                    }
                    else
                    {
                        MessageBox.Show("Számlázott elemm törlése nem lehetséges!", "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nincs kijelölt elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridViewSearch();
        }
    }
}
