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
    public partial class Form6 : Form
    {
        
        //Form6 constructor.
        public Form6()
        {
            InitializeComponent();
            LoadTextBoxes();
        }

        //This method loads user details into TextBoxes.
        public void LoadTextBoxes()
        {
            if (!string.IsNullOrEmpty(Global.logged_bodymass.ToString()))
            {
                textbox_Weight.Text = Global.logged_bodymass.ToString();
            }

            if (!string.IsNullOrEmpty(Global.logged_height.ToString()))
            {
                textbox_Height.Text = Global.logged_height.ToString();
            }
        }

        //Calculate button event - This event does the "magic".
        private void button_Calculate_Click(object sender, EventArgs e)
        {
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

            if(int.Parse(textbox_Height.Text) < 149)
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

            //verify weight
            if (string.IsNullOrEmpty(textbox_Weight.Text))
            {
                textbox_Weight.BorderColor = Color.Red;
                label_ErrorW.Visible = true;
                label_ErrorW.Text = "You must enter your weight!";
                return;
            }
            else
            {
                textbox_Weight.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorW.Visible = false;
            }

            double weight;
            if (!double.TryParse(textbox_Weight.Text, out weight))
            {
                textbox_Weight.BorderColor = Color.Red;
                label_ErrorW.Visible = true;
                label_ErrorW.Text = "Your weight must be a number!";
                return;
            }
            else
            {
                textbox_Weight.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorW.Visible = false;
            }

            label_BMI.Visible = true;
            label_Result.Visible = true;
            label_Result.Text = ((double.Parse(textbox_Weight.Text) / double.Parse(textbox_Height.Text) / double.Parse(textbox_Height.Text)) * 10000).ToString();
        }

        //Exit button event - This event close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
