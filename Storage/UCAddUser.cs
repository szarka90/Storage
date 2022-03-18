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
    public partial class UCAddUser : UserControl
    {
        private Users user;
        public UCAddUser()
        {
            InitializeComponent();
            typeOfUserCbx.DataSource = Enum.GetValues(typeof(TypeOfUsers));
        }
        internal UCAddUser (Users user) : this()
        {
            this.user = user;
            nameTxb.Text = user.Name;
            userNameTxb.Text = user.Username;
            typeOfUserCbx.SelectedItem = user.TypeOfUsers;
            emailTxb.Text = user.Email;

            passwordCbx.Visible = true;
            password1Txb.Enabled = false;
            password2Txb.Enabled = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            UCUsers users = new UCUsers();
            MainControlCLass.showControl(users, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (user == null && password1Txb.Text == password2Txb.Text)
                {
                    user = new Users(nameTxb.Text, userNameTxb.Text, password1Txb.Text, DateTime.Now, (TypeOfUsers)typeOfUserCbx.SelectedItem, emailTxb.Text);
                    DBConnect.AddNewUser(user);
                }
                else if (passwordCbx.Checked && password1Txb.Text == password2Txb.Text)
                {
                    user.Name = nameTxb.Text;
                    user.Username = userNameTxb.Text;
                    user.Password = password1Txb.Text;
                    user.TypeOfUsers = (TypeOfUsers)typeOfUserCbx.SelectedItem;
                    user.Email = emailTxb.Text;
                    DBConnect.ModifyUserAndPassword(user);
                }
                else
                {
                    user.Name = nameTxb.Text;
                    user.Username = userNameTxb.Text;
                    user.TypeOfUsers = (TypeOfUsers)typeOfUserCbx.SelectedItem;
                    user.Email = emailTxb.Text;
                    DBConnect.ModifyUser(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UCUsers usersUC = new UCUsers();
            MainControlCLass.showControl(usersUC, Content);
        }

        private void passwordCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCbx.Checked)
            {
                password1Txb.Enabled = true;
                password2Txb.Enabled = true;
            }
            else
            {
                password1Txb.Enabled = false;
                password2Txb.Enabled = false;
            }
        }
    }
}
