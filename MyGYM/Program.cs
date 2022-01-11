using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGYM
{
    static class Global
    {   
        //This method open a new form in the same form.
        public static void openChildForm(Form childForm, Form activeForm, Panel panelChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        
        //SQL Database Informations.
        public static string stringConection = @"Data Source = DESKTOP-QJ7R9S5; Initial Catalog = dbGym; Integrated Security = SSPI";
        public static SqlConnection con;
        public static SqlDataAdapter daUsers;
        public static DataSet ds;
        public static SqlCommandBuilder cb;


        //Logged User Account Informations.
        public static int logged_id;
        public static string logged_first_name;
        public static string logged_last_name;
        public static string logged_type;
        public static string logged_password;
        public static string logged_email;
        public static string logged_subscription;
        public static string administrator;
        public static int logged_bodymass;
        public static int logged_height;
        public static int logged_musclemass;
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
