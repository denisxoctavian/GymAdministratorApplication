using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGYM
{
    public partial class Form11 : Form
    {
        //Form11 constructor.
        public Form11()
        {
            InitializeComponent();
        }

        //Contact us button event - This event opens Gmail Page in user's default browser.
        private void button_Update_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }

        //Exit button event - This event close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
