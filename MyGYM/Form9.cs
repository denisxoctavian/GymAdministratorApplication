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
    public partial class Form9 : Form
    {
        public Form activeForm = null;
        
        //Form9 constructor.
        public Form9()
        {
            InitializeComponent();
        }

        //Form9 Load event - This event loads DGV + CBX.
        private void Form9_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadComboBox();
        }

        //This method loads data in DGV.
        public void LoadDGV()
        {
            Global.ds.Clear();
            Global.daUsers = new SqlDataAdapter("select user_id,user_first_name,user_last_name,user_type,user_password,user_email,subscrition from tUsers ", Global.con);
            Global.daUsers.Fill(Global.ds, "Users");
            dgv_Members.DataSource = Global.ds;
            dgv_Members.DataMember = "Users";
          
        }

        //This method loads items in ComboBoxes.
        public void LoadComboBox()
        {
            
            combobox_FilterBy.Items.Add("Only trainers");
            combobox_FilterBy.Items.Add("Only members");
        }

        //Clear button event - This event clear filters.
        private void button_Clear_Click(object sender, EventArgs e)
        {
            Global.daUsers = new SqlDataAdapter("select user_id,user_first_name,user_last_name,user_type,user_password,user_email,subscrition from tUsers ", Global.con);
            Global.ds = new DataSet();
            Global.daUsers.Fill(Global.ds, "Users");
            dgv_Members.DataSource = Global.ds;
            dgv_Members.DataMember = "Users";

            combobox_FilterBy.SelectedIndex = -1;
        }

        //Filter combobox event - This event filter the DGV.
        private void combobox_FilterBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Trainer


            if (combobox_FilterBy.SelectedIndex == 0)
            {
                Global.daUsers = new SqlDataAdapter("select user_id, user_first_name, user_last_name, user_type, user_password, user_email, subscrition from tUsers where user_type = 'Trainer' ", Global.con);
                Global.ds = new DataSet();
                Global.daUsers.Fill(Global.ds, "Users");
                dgv_Members.DataSource = Global.ds;
                dgv_Members.DataMember = "Users";
            }

            //Member



            if (combobox_FilterBy.SelectedIndex == 1)
            {
                Global.daUsers = new SqlDataAdapter("select user_id, user_first_name, user_last_name, user_type, user_password, user_email, subscrition from tUsers where user_type = 'Member' ", Global.con);
                Global.ds = new DataSet();
                Global.daUsers.Fill(Global.ds, "Users");
                dgv_Members.DataSource = Global.ds;
                dgv_Members.DataMember = "Users";
            }
        }

        //Members DGV Click - This event open the user profile.
        private void dgv_Members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 f4 = new Form4();
            int subscription;
            DataGridView dgv = sender as DataGridView;

            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {

                f4.label_PageTitle.Text = dgv_Members.Rows[e.RowIndex].Cells[0].Value.ToString();
                f4.textbox_Name.Text = dgv_Members.Rows[e.RowIndex].Cells[1].Value.ToString()+" "+dgv_Members.Rows[e.RowIndex].Cells[2].Value.ToString();
                f4.textbox_Email.Text = dgv_Members.Rows[e.RowIndex].Cells[5].Value.ToString();
                f4.textbox_Password.Text = dgv_Members.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (Convert.ToBoolean(dgv_Members.Rows[e.RowIndex].Cells[6].Value) == true)
                {
                    f4.combobox_Sub.SelectedIndex = 0;
                }
                else
                {
                    f4.combobox_Sub.SelectedIndex = 1;
                }
                
                f4.panel_Height.Visible = false;
                f4.panel_MuscleMass.Visible = false;
                f4.panel_Weight.Visible = false;
                f4.label_PageSubtitle.Visible = false;
                f4.guna2Separator1.Visible = false;
                f4.button_Update.Visible = true;
                f4.guna2Button1.Visible = true;
                f4.button_UpdateDetails.Visible = false;
                f4.picture_UserList.Visible = true;
              

            }
            dgv_Members.Visible = false;
            guna2Panel1.Visible = false;
            
            Global.openChildForm(f4, activeForm, openChildForm);
        }

        //Exit button event - This event close the application.
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
