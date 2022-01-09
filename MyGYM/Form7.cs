using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGYM
{
    public partial class Form7 : Form
    {
        double idealWeight = 0;
       
        //Form7 constructor.
        public Form7()
        {
            InitializeComponent();
            LoadTextBoxes();
        }

        //This method loads user details into TextBoxes.
        public void LoadTextBoxes()
        {
            if (!string.IsNullOrEmpty(Global.logged_height.ToString()))
            {
                textbox_Height.Text = Global.logged_height.ToString();
            }
        }

        //Calculate button event - This event does the "magic".
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            //verify age
            if (string.IsNullOrEmpty(textbox_Age.Text))
            {
                textbox_Age.BorderColor = Color.Red;
                label_ErrorA.Visible = true;
                label_ErrorA.Text = "You must enter your age!";
                return;
            }
            else
            {
                textbox_Age.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorA.Visible = false;
            }

            int age;

            if (!int.TryParse(textbox_Age.Text, out age))
            {
                textbox_Age.BorderColor = Color.Red;
                label_ErrorA.Visible = true;
                label_ErrorA.Text = "You age must be a number!";
                return;
            }
            else
            {
                textbox_Age.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorA.Visible = false;
            }

            if (int.Parse(textbox_Age.Text) < 15)
            {
                textbox_Age.BorderColor = Color.Red;
                label_ErrorA.Visible = true;
                label_ErrorA.Text = "You must be atleast 15 years old!";
                return;
            }
            else
            {
                textbox_Age.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorA.Visible = false;
            }

            //verify height
            if (string.IsNullOrEmpty(textbox_Height.Text))
            {

                textbox_Height.BorderColor = Color.Red;
                label_ErrorH.Visible = true;
                label_ErrorH.Text = "You must enter your height!";
                return;
            }
            else
            {
                textbox_Height.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorH.Visible = false;
            }

            int height;

            if (!int.TryParse(textbox_Height.Text, out height))
            {
                textbox_Height.BorderColor = Color.Red;
                label_ErrorH.Visible = true;
                label_ErrorH.Text = "Your height must be a number!";
                return;
            }
            else
            {
                textbox_Height.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorH.Visible = false;
            }

            if (int.Parse(textbox_Height.Text) < 149)
            {
                textbox_Height.BorderColor = Color.Red;
                label_ErrorH.Visible = true;
                label_ErrorH.Text = "Your height must atleas 150cm!";
                return;
            }
            else
            {
                textbox_Height.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorH.Visible = false;
            }

            //verify gender
            if (!radiobutton_Male.Checked && !radiobutton_Female.Checked)
            {
                label_ErrorG.Visible = true;
                label_ErrorG.Text = "You must select a gender!";
                return;
            }
            else
            {
                label_ErrorG.Visible = false;
            }

            if (radiobutton_Male.Checked)
            {
                idealWeight = 50 + (0.91 * (double.Parse(textbox_Height.Text) - 152.4));
            }
            else
            {
                idealWeight = 45.5 + (0.91 * (double.Parse(textbox_Height.Text) - 152.4));
            }

            label_IdealWeight.Visible = true;
            label_Result.Text = idealWeight.ToString();
            
        }

        //Exit button event - This event close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
