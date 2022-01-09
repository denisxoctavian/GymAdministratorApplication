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
    public partial class Form5 : Form
    {
        double BMR = 0, calories = 0;
        
        //Form5 constructor.
        public Form5()
        {
            InitializeComponent();
            LoadComboBox();
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

        //This method add items to ComboBoxes.
        public void LoadComboBox()
        {
            combobox_Activity.Items.Add("Sedentary (little or no exercise)");
            combobox_Activity.Items.Add("Lightly active (1-3 days/week)");
            combobox_Activity.Items.Add("Moderately active (3-5 days/week)");
            combobox_Activity.Items.Add("Very active (6-7 days a week)");  
        }

        //Exit button event - This event close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                label_ErrorA.Text = "Your age must be a number!";
                return;
            }
            else
            {
                textbox_Age.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorA.Visible = false;
            }

            if (int.Parse(textbox_Age.Text) < 15 || int.Parse(textbox_Age.Text) > 80)
            {
                textbox_Age.BorderColor = Color.Red;
                label_ErrorA.Visible = true;
                label_ErrorA.Text = "Your age should be between 15 and 80";
                return;
            }
            else
            {
                textbox_Age.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorA.Visible = false;
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

            //verify activity
            if (string.IsNullOrEmpty(combobox_Activity.Text))
            {
                combobox_Activity.BorderColor = Color.Red;
                label_ErrorAc.Visible = true;
                label_ErrorAc.Text = "You must select a type for activity!";
                return;
            }
            else
            {
                combobox_Activity.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorAc.Visible = false;
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

            //formulas
            if (radiobutton_Male.Checked)
            {
                BMR = 10 * int.Parse(textbox_Weight.Text) + 6.25 * int.Parse(textbox_Height.Text) - 5 * int.Parse(textbox_Age.Text) + 5;
            }
            else
            {
                BMR = 10 * int.Parse(textbox_Weight.Text) + 6.25 * int.Parse(textbox_Height.Text) - 5 * int.Parse(textbox_Age.Text) - 161;
            }

            if(combobox_Activity.Text == "Sedentary (little or no exercise)")
            {
                calories = BMR * 1.2;
            }
            if (combobox_Activity.Text == "Lightly active (1-3 days/week)")
            {
                calories = BMR * 1.375;
            }
            if(combobox_Activity.Text == "Moderately active (3-5 days/week)")
            {
                calories = BMR * 1.55;
            }
            if (combobox_Activity.Text == "Very active (6-7 days a week)")
            {
                calories = BMR * 1.725;
            }

            label_MantainWeight.Visible = true;
            label_ResultMantain.Visible = true;
            label_ResultMantain.Text = calories.ToString() +" kcal";
            label_LoseWeight.Visible = true;
            label_ResultLose.Visible = true;
            label_ResultLose.Text = (calories - 250).ToString()+ " kcal";
        }
    }
}
