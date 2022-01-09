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
    public partial class Form8 : Form
    {
        //Form8 constructor.
        public Form8()
        {
            InitializeComponent();
        }

        //Article 1+ Hover effect.
        private void panel_Article1_MouseEnter(object sender, EventArgs e)
        {
            panel_Article1.FillColor = Color.FromArgb(255, 146, 146);
            panel_Article1.FillColor2 = Color.FromArgb(255, 146, 146);
        }
        private void panel_Article1_MouseLeave(object sender, EventArgs e)
        {
            panel_Article1.FillColor = Color.FromArgb(255, 192, 192);
            panel_Article1.FillColor2 = Color.FromArgb(255, 192, 192);
        }
        private void panel_Article1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freedieting.com/exercise-plan-1");
        }

        //Article 2 + Hover effect.
        private void panel_Article2_MouseEnter(object sender, EventArgs e)
        {
            panel_Article2.FillColor = Color.FromArgb(255, 146, 146);
            panel_Article2.FillColor2 = Color.FromArgb(255, 146, 146);
        }
        private void panel_Article2_MouseLeave(object sender, EventArgs e)
        {
            panel_Article2.FillColor = Color.FromArgb(255, 192, 192);
            panel_Article2.FillColor2 = Color.FromArgb(255, 192, 192);
        }
        private void panel_Article2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freedieting.com/exercise-plan-2");
        }


        //Article 3 + Hover effect.
        private void panel_Article3_MouseEnter(object sender, EventArgs e)
        {
            panel_Article3.FillColor = Color.FromArgb(255, 146, 146);
            panel_Article3.FillColor2 = Color.FromArgb(255, 146, 146);
        }
        private void panel_Article3_MouseLeave(object sender, EventArgs e)
        {
            panel_Article3.FillColor = Color.FromArgb(255, 192, 192);
            panel_Article3.FillColor2 = Color.FromArgb(255, 192, 192);
        }
        private void panel_Article3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freedieting.com/exercise-plan-3");
        }

        //Article 4 + Hover effect.
        private void panel_Article4_MouseEnter(object sender, EventArgs e)
        {
            panel_Article4.FillColor = Color.FromArgb(255, 146, 146);
            panel_Article4.FillColor2 = Color.FromArgb(255, 146, 146);
        }
        private void panel_Article4_MouseLeave(object sender, EventArgs e)
        {
            panel_Article4.FillColor = Color.FromArgb(255, 192, 192);
            panel_Article4.FillColor2 = Color.FromArgb(255, 192, 192);
        }
        private void panel_Article4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freedieting.com/circuit-training");
        }

        //Article 5 + Hover effect.
        private void panel_Article5_MouseEnter(object sender, EventArgs e)
        {
            panel_Article5.FillColor = Color.FromArgb(255, 146, 146);
            panel_Article5.FillColor2 = Color.FromArgb(255, 146, 146);
        }
        private void panel_Article5_MouseLeave(object sender, EventArgs e)
        {
            panel_Article5.FillColor = Color.FromArgb(255, 192, 192);
            panel_Article5.FillColor2 = Color.FromArgb(255, 192, 192);
        }
        private void panel_Article5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freedieting.com/fat-blast-diet");
        }

        //Exit button event - This event close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
