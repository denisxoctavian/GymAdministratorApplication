using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGYM
{
    public partial class Form4 : Form
    {
        bool updateMode = false;
        public Form activeForm = null;

        //Form4 constructor
        public Form4()
        {
            InitializeComponent();
            LoadCombo();
            LoadAccountInfo();
        }

        //This method insert account informations in the TextBoxes.
        public void LoadAccountInfo()
        {
            textbox_Name.Text = Global.logged_first_name + " " + Global.logged_last_name;
            textbox_Email.Text = Global.logged_email;
            textbox_Password.Text = Global.logged_password;
            if (Global.logged_subscription == "1")
            {
                combobox_Sub.Text = "Paid";
            }
            else
            {
                combobox_Sub.Text = "Not paid";
            }
            if(UserIsInDataBaseProcedure())
            {
                LoadUserDetailsProcedure();
            }
            
        }

        //This method insert the items in the ComboBox.
        public void LoadCombo()
        {
            combobox_Sub.Items.Add("Paid");
            combobox_Sub.Items.Add("Not Paid");
        }

        //This method switch the EditMode OF.
        public void updateModeOff()
        {
            button_Update.Visible = true;
            button_UpdateOf.Visible = false;
            picture_Edit.Visible = false;
            picture_Edit1.Visible = false;
            picture_Edit2.Visible = false;
           
            picture_Edit4.Visible = false;
            picture_Edit5.Visible = false;
            picture_Edit6.Visible = false;
            updateMode = false;
            textbox_Email.ReadOnly = true;
           
            textbox_Name.ReadOnly = true;
            textbox_Password.ReadOnly = true;
            combobox_Sub.Enabled = false;
            
        }

        //Update button event - This event turns the EditMode ON.
        private void button_Update_Click(object sender, EventArgs e)
        {
            button_Update.Visible = false;
            button_UpdateOf.Visible = true;
            picture_Edit1.Visible = true;
            picture_Edit2.Visible = true;
            picture_Edit4.Visible = true;
            picture_Edit5.Visible = true;
            picture_Edit6.Visible = true;
            picture_Edit.Visible = true;
            textbox_Email.ReadOnly = false;
            textbox_Name.ReadOnly = false;
            textbox_Password.ReadOnly = false;
            combobox_Sub.Enabled = true;

        }

        //UpdateOf button event - This event turns the EditMode OF.
        private void button_UpdateOf_Click(object sender, EventArgs e)
        {
            //verify name
            if (string.IsNullOrEmpty(textbox_Name.Text))
            {
                label_ErrorN.Visible = true;
                label_ErrorN.Text = "You must enter a name!";
                textbox_Name.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Name.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorN.Visible = false;
            }

        
            if (string.IsNullOrEmpty(textbox_Email.Text))
            {
                label_ErrorE.Visible = true;
                label_ErrorE.Text = "You must enter an email!";
                textbox_Name.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Name.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorE.Visible = false;
            }

         
            if (string.IsNullOrEmpty(textbox_Password.Text))
            {
                label_ErrorP.Visible = true;
                label_ErrorP.Text = "You must enter a password!";
                textbox_Password.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Password.BorderColor = Color.FromArgb(213, 218, 223);
                label_ErrorP.Visible = false;
            }

            updateUsersProcedure();
            updateModeOff();
        }

        //Remove button event - This event removes selected account from the list.
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RemoveUserProgressProcedure();
            RemoveUserProcedure();
            Global.openChildForm(new Form9(), activeForm, panel_profile);
        }

        //UpdateDetails button event - This event turns EditMode ON for the user progress.
        private void button_UpdateDetails_Click(object sender, EventArgs e)
        {
            button_UpdateDetails.Visible = false;
            guna2Button2.Visible = true;
            textbox_Height.ReadOnly = false;
            textbox_Weight.ReadOnly = false;
            textbox_MuscleMass.ReadOnly = false;
            picture_Edit4.Visible = true;
            picture_Edit5.Visible = true;
            picture_Edit6.Visible = true;
        }

        //UpdateDetailsOF button event - This event turns EditMode OF and save user progress in DB.
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_Weight.Text))
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must enter a value!";
                return;
            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            if (string.IsNullOrEmpty(textbox_Height.Text))
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must enter a value!";
                return;
            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            if (string.IsNullOrEmpty(textbox_MuscleMass.Text))
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must enter a value!";
                return;

            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            double weight;
            if (!double.TryParse(textbox_Weight.Text, out weight))
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must enter a numeric value!";
                return;
            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            double height;
            if (!double.TryParse(textbox_Height.Text, out height))
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must enter a numeric value!";
                return;
            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            double musclemass;
            if (!double.TryParse(textbox_MuscleMass.Text, out musclemass))
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must enter a numeric value!";
                return;
            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            if (double.Parse(textbox_Height.Text) < 150)
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must have atleast 150cm and 40kg!";
                return;
            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            if (double.Parse(textbox_Weight.Text) < 40)
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You must have atleast 150cm and 40kg!";
                return;
            }
            else
            {
                label_ErrorDetails.Visible = false;
            }

            if (double.Parse(textbox_Weight.Text) < double.Parse(textbox_MuscleMass.Text))
            {
                label_ErrorDetails.Visible = true;
                label_ErrorDetails.Text = "You cannot have more muscle mass than total weight!";
                return;
            }
            {
                label_ErrorDetails.Visible = false;
            }

            if (UserIsInDataBaseProcedure())
            {
                SaveUserDetailsProcedure();
            }
            else
            {
                InsertUserDetailsProcedure();
            }

            button_UpdateDetails.Visible = true;
            guna2Button2.Visible = false;
            textbox_Height.ReadOnly = true;
            textbox_Weight.ReadOnly = true;
            textbox_MuscleMass.ReadOnly = true;
            picture_Edit4.Visible = false;
            picture_Edit5.Visible = false;
            picture_Edit6.Visible = false;

        }

        //Exit button event - This event close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //PROCEDURES!//
        //Update user's account informations in DB.
        public void updateUsersProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_user";
            SqlParameter p1 = new SqlParameter();
            p1.Value = label_PageTitle.Text;
            p1.ParameterName = "@uuser_id";
            cmd.Parameters.Add(p1);
            SqlParameter p2 = new SqlParameter();
            p2.Value = textbox_Password.Text;
            p2.ParameterName = "@uuser_password";
            cmd.Parameters.Add(p2);
            SqlParameter p3 = new SqlParameter();
            p3.Value =textbox_Email.Text;
            p3.ParameterName = "@uuser_email";
            cmd.Parameters.Add(p3);
            SqlParameter p4 = new SqlParameter();
            if(combobox_Sub.Text == "Paid")
            {
                p4.Value = 1;
            }
            else
            {
                p4.Value = 0;
            }
            p4.ParameterName = "@usubscrition";
            cmd.Parameters.Add(p4);
            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();
        }

        //Removes user's account from DB.
        public void RemoveUserProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "remove_user";
            SqlParameter p1 = new SqlParameter();
            p1.Value = label_PageTitle.Text;
            p1.ParameterName = "@ruser_id";
            cmd.Parameters.Add(p1);
            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();
     
        }

        //Remove user's progress from DB.
        public void RemoveUserProgressProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "remove_userprogress";
            SqlParameter p1 = new SqlParameter();
            p1.Value = label_PageTitle.Text;
            p1.ParameterName = "@ruser_id";
            cmd.Parameters.Add(p1);
            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();
        }

        //Checks if the @user is in DB.
        public bool UserIsInDataBaseProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "search_id";

            SqlParameter p1 = new SqlParameter();
            p1.Value = Global.logged_id;
            p1.ParameterName = "@logged_user";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@result";
            p2.DbType = DbType.Int32;
            p2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p2);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();

            if (p2.Value.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Loads the user's details in TextBoxes.
        public void LoadUserDetailsProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_details";

            SqlParameter p1 = new SqlParameter();
            p1.Value = Global.logged_id;
            p1.ParameterName = "@logged_user";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@user_bodymass";
            p2.DbType = DbType.Int32;
            p2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@user_musclemass";
            p3.DbType = DbType.Int32;
            p3.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@user_height";
            p4.DbType = DbType.Int32;
            p4.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p4);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();

            
            Global.logged_bodymass = int.Parse(p2.Value.ToString());
            Global.logged_height = int.Parse(p4.Value.ToString()); 
            Global.logged_musclemass = int.Parse(p3.Value.ToString());

            textbox_Height.Text = Global.logged_height.ToString();
            textbox_MuscleMass.Text = Global.logged_musclemass.ToString();
            textbox_Weight.Text = Global.logged_bodymass.ToString();
        }

        //Saves user's details in DB.
        public void SaveUserDetailsProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_details";

            SqlParameter p1 = new SqlParameter();
            p1.Value = Global.logged_id;
            p1.ParameterName = "@logged_user";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = textbox_Weight.Text;
            p2.ParameterName = "@user_bodymass";
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.Value = textbox_MuscleMass.Text;
            p3.ParameterName = "@user_musclemass";
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.Value = textbox_Height.Text;
            p4.ParameterName = "@user_height";
            cmd.Parameters.Add(p4);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();

        }

        //If the user has 0 progress this procedure insert new progress details in DB.
        public void InsertUserDetailsProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_userdetails";

            SqlParameter p1 = new SqlParameter();
            p1.Value = Global.logged_id;
            p1.ParameterName = "@logged_user";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = textbox_Weight.Text;
            p2.ParameterName = "@user_bodymass";
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.Value = textbox_Height.Text;
            p3.ParameterName = "@user_height";
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.Value = textbox_MuscleMass.Text;
            p4.ParameterName = "@user_musclemass";
            cmd.Parameters.Add(p4);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();

        }

    }
}
