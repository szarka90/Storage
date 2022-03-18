using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Storage
{
    class MainControlCLass
    {
        public static void showControl(Control control, Control Content)
        {
            Content.Controls.Clear();
            
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.BringToFront();
            Content.Controls.Add(control);
        }
    }
    
}
