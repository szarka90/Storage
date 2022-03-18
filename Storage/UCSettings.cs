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
    public partial class UCSettings : UserControl
    {
        private List<PartnerClass> companyData;
        public UCSettings()
        {
            InitializeComponent();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            UCUsers users = new UCUsers();
            MainControlCLass.showControl(users, Content);
        }

        private void companyBtn_Click(object sender, EventArgs e)
        {
            companyData = new List<PartnerClass>(DBConnect.CompanyDataReading());
            
            UCCompanyData UCcompanyData = new UCCompanyData(companyData[0]);
            MainControlCLass.showControl(UCcompanyData, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCDatabaseConect uCDatabase = new UCDatabaseConect();
            MainControlCLass.showControl(uCDatabase, Content);
        }
    }
}
