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
    public partial class Form3 : Form
    {
        public Form activeForm = null;
        
        //Form3 constructor
        public Form3()
        {
            InitializeComponent();
            checkAdminStatus();


        }

        //This method checks if the user that logged is administrator or not.
        public void checkAdminStatus()
        {
            if (string.IsNullOrEmpty(Global.administrator))
            {
                button_Members.Visible = false;
                guna2PictureBox6.Visible = false;
            }
           
        }

        //Facebook button event - This opens Facebook in user's default browser.
        private void button_Facebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        //Home button event - This opens the Form3(Home-Page).
        private void button_Home_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form3(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(33, 71, 148);
            button_Profile.FillColor = Color.FromArgb(107, 145, 218);
            button_CalorieCalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_BMICalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_Weight.FillColor = Color.FromArgb(107, 145, 218);
            button_Workout.FillColor = Color.FromArgb(107, 145, 218);
            button_Members.FillColor = Color.FromArgb(107, 145, 218);
          
            button_Help.FillColor = Color.FromArgb(107, 145, 218);

        }

        //Profile button event - This opens the Form4(Profile-Page).
        private void button_Profile_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form4(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(107, 145, 218);
            button_Profile.FillColor = Color.FromArgb(33, 71, 148);
            button_CalorieCalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_BMICalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_Weight.FillColor = Color.FromArgb(107, 145, 218);
            button_Workout.FillColor = Color.FromArgb(107, 145, 218);
            button_Members.FillColor = Color.FromArgb(107, 145, 218);
            
            button_Help.FillColor = Color.FromArgb(107, 145, 218);
        }

        //CalorieCalculator button event - This opens the Form5(Calorie-Calculator-Page).
        private void button_CalorieCalculator_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form5(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(107, 145, 218);
            button_Profile.FillColor = Color.FromArgb(107, 145, 218);
            button_CalorieCalculator.FillColor = Color.FromArgb(33, 71, 148);
            button_BMICalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_Weight.FillColor = Color.FromArgb(107, 145, 218);
            button_Workout.FillColor = Color.FromArgb(107, 145, 218);
            button_Members.FillColor = Color.FromArgb(107, 145, 218);
          
            button_Help.FillColor = Color.FromArgb(107, 145, 218);
        }

        //BMI Calculaor button event - This opens the Form6(BMI-Calculator-Page).
        private void button_BMICalculator_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form6(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(107, 145, 218);
            button_Profile.FillColor = Color.FromArgb(107, 145, 218);
            button_CalorieCalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_BMICalculator.FillColor = Color.FromArgb(33, 71, 148);
            button_Weight.FillColor = Color.FromArgb(107, 145, 218);
            button_Workout.FillColor = Color.FromArgb(107, 145, 218);
            button_Members.FillColor = Color.FromArgb(107, 145, 218);
           
            button_Help.FillColor = Color.FromArgb(107, 145, 218);
        }

        //Weight button event - This opens the Form7(Ideal-Weight-Calculator).
        private void button_Weight_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form7(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(107, 145, 218);
            button_Profile.FillColor = Color.FromArgb(107, 145, 218);
            button_CalorieCalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_BMICalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_Weight.FillColor = Color.FromArgb(33, 71, 148);
            button_Workout.FillColor = Color.FromArgb(107, 145, 218);
            button_Members.FillColor = Color.FromArgb(107, 145, 218);
           
            button_Help.FillColor = Color.FromArgb(107, 145, 218);
        }

        //Workout button event - This opens the Form8(Workout-Plans).
        private void button_Workout_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form8(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(107, 145, 218);
            button_Profile.FillColor = Color.FromArgb(107, 145, 218);
            button_CalorieCalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_BMICalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_Weight.FillColor = Color.FromArgb(107, 145, 218);
            button_Workout.FillColor = Color.FromArgb(33, 71, 148);
            button_Members.FillColor = Color.FromArgb(107, 145, 218);
           
            button_Help.FillColor = Color.FromArgb(107, 145, 218);
        }

        //Members button event - This opens the Form9(List with all users), can only be seen by the administrator.
        private void button_Members_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form9(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(107, 145, 218);
            button_Profile.FillColor = Color.FromArgb(107, 145, 218);
            button_CalorieCalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_BMICalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_Weight.FillColor = Color.FromArgb(107, 145, 218);
            button_Workout.FillColor = Color.FromArgb(107, 145, 218);
            button_Members.FillColor = Color.FromArgb(33, 71, 148);
          
            button_Help.FillColor = Color.FromArgb(107, 145, 218);
        }

        //Help button event - This opens the Form11(Help-Page)
        private void button_Help_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form11(), activeForm, guna2Panel1);
            button_Home.FillColor = Color.FromArgb(107, 145, 218);
            button_Profile.FillColor = Color.FromArgb(107, 145, 218);
            button_CalorieCalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_BMICalculator.FillColor = Color.FromArgb(107, 145, 218);
            button_Weight.FillColor = Color.FromArgb(107, 145, 218);
            button_Workout.FillColor = Color.FromArgb(107, 145, 218);
            button_Members.FillColor = Color.FromArgb(107, 145, 218);
          
            button_Help.FillColor = Color.FromArgb(33, 71, 148);
        }

        //Exit button event - This close the application
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
