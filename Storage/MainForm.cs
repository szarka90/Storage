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
    public partial class MainForm : Form
    {
        private Users user;
        public MainForm()
        {
            InitializeComponent();
            
        }
        internal MainForm (Users user) : this()
        {
            this.user = user;
            userLabel.Text = user.Name;
            Text = "Ügyvitel v1.0 " + user.Name;
            if (user.TypeOfUsers == TypeOfUsers.user)
            {
                settingsBtn.Visible = false;
            }
        }
        private void partnerBtn_Click(object sender, EventArgs e)
        {
            UCPartner partner = new UCPartner(user);
            MainControlCLass.showControl(partner, Content);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            UCProduct termekek = new UCProduct(user);
            MainControlCLass.showControl(termekek, Content);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            UCOrders orders = new UCOrders(user);
            MainControlCLass.showControl(orders, Content);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            UCSettings settings = new UCSettings();
            MainControlCLass.showControl(settings, Content);
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            bool increase = true;
            UCProduct termekek = new UCProduct(user, increase);
            MainControlCLass.showControl(termekek, Content);
        }
    }
}
