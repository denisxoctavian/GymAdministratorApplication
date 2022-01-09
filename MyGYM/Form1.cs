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
    public partial class Form1 : Form
    {
        public Form activeForm = null;

        //Form1 constructor
        public Form1()
        {
            InitializeComponent();
            textbox_Password.PasswordChar = '*';
           
        }

        //Hover effect for "Sign up" label
        private void label_SignUp_MouseEnter(object sender, EventArgs e)
        {
            label_SignUp.ForeColor = Color.FromArgb(0,0,139);
        }

        private void label_SignUp_MouseLeave(object sender, EventArgs e)
        {
            label_SignUp.ForeColor = Color.FromArgb(107, 145, 218);
        }

        //"Sign up" button event
        private void label_SignUp_Click(object sender, EventArgs e)
        {
            Global.openChildForm(new Form2(), activeForm, panel_LoginOrRegister);
            label_Error.Visible = false;
        }

        //Exit button
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //"Login" button event
        private void button_Login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textbox_Email.Text))
            {
                label_Error.Text = "You must enter an email!";
                label_Error.Visible = true;
                return;
            }
            else
            {
                label_Error.Visible = false;
            }

            if (string.IsNullOrEmpty(textbox_Password.Text))
            {
                label_Error.Text = "You must enter a password!";
                label_Error.Visible = true;
                return;
            }
            else
            {
                label_Error.Visible = false;
            }

            if (loginProcedure())
            {
                label_Error.Visible = false;
                panel_Image.Visible = false;
                panel_LoginOrRegister.Visible = false;
                getAccountCreditsProcedure();
                Global.openChildForm(new Form3(), activeForm, panelChildForm);
            }
            else
            {
                label_Error.Text = "Wrong email or password!";
                label_Error.Visible = true;
                return;
            }
           
        }

        //Loading Form1 event
        private void Form1_Load(object sender, EventArgs e)
        {
            Global.con = new SqlConnection(Global.stringConection);
            Global.daUsers = new SqlDataAdapter("select user_id,user_first_name,user_last_name,user_type,user_password,user_email,subscrition from tUsers", Global.con);
            Global.ds = new DataSet();
            Global.daUsers.Fill(Global.ds, "Users");
            Global.cb = new SqlCommandBuilder(Global.daUsers);
            Global.daUsers.InsertCommand = Global.cb.GetInsertCommand();
            Global.daUsers.DeleteCommand = Global.cb.GetDeleteCommand();
            Global.daUsers.UpdateCommand = Global.cb.GetUpdateCommand();
        }

        //PROCEDURES!//
        //Saving account informations procedure (after login)
        public void getAccountCreditsProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_info";

            SqlParameter p1 = new SqlParameter();
            p1.Value = textbox_Email.Text;
            p1.ParameterName = "@logged_user";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@user_id";
            p2.DbType = DbType.Int32;
            p2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@user_first_name";
            p3.SqlDbType = SqlDbType.VarChar;
            p3.Size = 26;
            p3.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@user_last_name";
            p4.SqlDbType = SqlDbType.VarChar;
            p4.Size = 26;
            p4.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@user_type";
            p5.SqlDbType = SqlDbType.VarChar;
            p5.Size = 26;
            p5.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@user_password";
            p6.SqlDbType = SqlDbType.VarChar;
            p6.Size = 26;
            p6.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p6);


            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@user_email";
            p7.SqlDbType = SqlDbType.VarChar;
            p7.Size = 26;
            p7.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p7);


            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@subscripiton";
            p8.DbType = DbType.Byte;
            p8.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p8);

            SqlParameter p9 = new SqlParameter();
            p9.ParameterName = "@administrator";
            p9.DbType = DbType.Byte;
            p9.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p9);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();

            Global.logged_id = int.Parse(p2.Value.ToString());
            Global.logged_first_name = p3.Value.ToString();
            Global.logged_last_name = p4.Value.ToString();
            Global.logged_type = p5.Value.ToString();
            Global.logged_password = p6.Value.ToString();
            Global.logged_email = p7.Value.ToString();
            Global.logged_subscription = p8.Value.ToString();
            Global.administrator = p9.Value.ToString();

        }

        //Checking if account exists in the datebase procedure
        public bool loginProcedure()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "login";

            SqlParameter p1 = new SqlParameter();
            p1.Value = textbox_Email.Text;
            p1.ParameterName = "@email";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = textbox_Password.Text;
            p2.ParameterName = "@password";
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@result";
            p3.DbType = DbType.Byte;
            p3.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p3);

            Global.con.Open();
            cmd.ExecuteScalar();
            Global.con.Close();

            if(p3.Value.ToString() =="1")
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

    }
}
