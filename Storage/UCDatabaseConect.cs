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
    public partial class UCDatabaseConect : UserControl
    {
        DatabaseConnect database;
        public UCDatabaseConect()
        {
            InitializeComponent();
            database = DBConnect.ConnectDataReading();
            textBox1.Text = database.Server;
            textBox2.Text = database.User;
            numericUpDown1.Value = database.Port;
            textBox3.Text = database.Password;
            textBox4.Text = database.Database;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                database.Server = textBox1.Text;
                database.User = textBox2.Text;
                database.Port = (uint)numericUpDown1.Value;
                database.Password = textBox3.Text;
                database.Database = textBox4.Text;
                DBConnect.ConnectDataWriting(database);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
