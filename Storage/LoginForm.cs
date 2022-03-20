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
    public partial class LoginForm : Form
    {
        private Users user;
        public LoginForm()
        {
            InitializeComponent();
            
        }       
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBConnect.Login(textBox1.Text, textBox2.Text) == null)
                {
                    MessageBox.Show("Sikertelen bejelentkezés", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    user = new Users((int?)DBConnect.Login(textBox1.Text, textBox2.Text).Id, (string)DBConnect.Login(textBox1.Text, textBox2.Text).Name, (TypeOfUsers)DBConnect.Login(textBox1.Text, textBox2.Text).TypeOfUsers);
                    MainForm main = new MainForm(user);
                    main.Show();
                    main.Activate();
                    Hide();
                }  
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen módosítás!", ex);
            }          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {            
            if (textBox2.PasswordChar == '*')
            {
                toolTip1.SetToolTip(pictureBox1, "Jelszó megjelenítése");
            }
            else
            {
                toolTip1.SetToolTip(pictureBox1, "Jelszó elrejtése");
            }
        }
    }
}
