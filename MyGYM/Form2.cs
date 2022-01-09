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
    public partial class Form2 : Form
    {
        public Form activeForm = null;
        public string vem;
        
        //Form2 constructor
        public Form2()
        {
            InitializeComponent();
            textbox_Password.PasswordChar = '*';
            textbox_ConfirmPassword.PasswordChar = '*';

        }

        //Exit button event - This close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //"Sign up" button event - This event insert the account in DB.
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_First_Name.Text))
            {
                label_FNE.Visible = true;
                label_FNE.Text = "You must enter your first name!";
                textbox_First_Name.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_First_Name.BorderColor = Color.FromArgb(213, 218, 223);
                label_FNE.Visible = false;
            }

            if (string.IsNullOrEmpty(textbox_Last_Name.Text))
            {
                label_LNE.Visible = true;
                label_LNE.Text = "You must enter your last name!";
                textbox_Last_Name.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Last_Name.BorderColor = Color.FromArgb(213, 218, 223);
                label_LNE.Visible = false;
            }

            if (string.IsNullOrEmpty(textbox_Email.Text))
            {
                label_EE.Visible = true;
                label_EE.Text = "You must enter your email!";
                textbox_Email.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Email.BorderColor = Color.FromArgb(213, 218, 223);
                label_EE.Visible = false;
            }

            if (verifyEmailProcedure())
            {
                label_EE.Visible = true;
                label_EE.Text = "This email is already in use!";
                textbox_Email.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Email.BorderColor = Color.FromArgb(213, 218, 223);
                label_EE.Visible = false;
            }


            if (string.IsNullOrEmpty(textbox_Password.Text))
            {
                label_EP.Visible = true;
                label_EP.Text = "You must enter your password!";
                textbox_Password.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Password.BorderColor = Color.FromArgb(213, 218, 223);
                label_EP.Visible = false;
            }

            if(textbox_Password.Text.Length < 5)
            {
                label_EP.Visible = true;
                label_EP.Text = "Your password needs atleast 5 characters!";
                textbox_Password.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_Password.BorderColor = Color.FromArgb(213, 218, 223);
                label_EP.Visible = false;
            }


            if (string.IsNullOrEmpty(textbox_ConfirmPassword.Text))
            {
                label_EPC.Visible = true;
                label_EPC.Text = "You must enter your password again!";
                textbox_ConfirmPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_ConfirmPassword.BorderColor = Color.FromArgb(213, 218, 223);
                label_EPC.Visible = false;
            }

            if(textbox_ConfirmPassword.Text != textbox_Password.Text)
            {
                label_EPC.Visible = true;
                label_EPC.Text = "The passwords you have entered do not match!";
                textbox_ConfirmPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                textbox_ConfirmPassword.BorderColor = Color.FromArgb(213, 218, 223);
                label_EPC.Visible = false;
            }

            createAccountProcedure();
            this.Close();

        }

        //PROCEDURES!//
        //Verify if the email that user inserts is already in DB.
        public bool verifyEmailProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "verify_email";

            SqlParameter p1 = new SqlParameter();
            p1.Value = textbox_Email.Text;
            p1.ParameterName = "@email";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = textbox_Email.Text;
            p2.ParameterName = "@result";
            p2.DbType = DbType.Byte;
            p2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p2);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();

            vem = p2.Value.ToString();

            if (vem == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        //Insert informations provided by user in the DB.
        public void createAccountProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "create_account";

            SqlParameter p1 = new SqlParameter();
            p1.Value = textbox_First_Name.Text;
            p1.ParameterName = "@user_first_name";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = textbox_Last_Name.Text;
            p2.ParameterName = "@user_last_name";
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.Value = textbox_Password.Text;
            p3.ParameterName = "@user_password";
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.Value = textbox_Email.Text;
            p4.ParameterName = "@user_email";
            cmd.Parameters.Add(p4);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();
        }

    }
}
