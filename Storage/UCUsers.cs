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
    public partial class UCUsers : UserControl
    {
        List<Users> users;
        public UCUsers()
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
        public void DataGridViewUpdate()
        {
            users = DBConnect.ListUsers();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            UCAddUser addUser = new UCAddUser();
            MainControlCLass.showControl(addUser, Content);
        }

        private void userModBtn_Click(object sender, EventArgs e)
        {
            UCAddUser addUser = new UCAddUser(dataGridView1.CurrentRow.DataBoundItem as Users);
            MainControlCLass.showControl(addUser, Content);
        }

        private void userDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {

                    if (MessageBox.Show("Biztosan szeretné törölni a kijelölt elemet?", "Figyelmeztetés!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBConnect.DeleteUser(dataGridView1.CurrentRow.DataBoundItem as Users);
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
