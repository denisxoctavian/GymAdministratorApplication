
namespace MyGYM
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Members = new Guna.UI2.WinForms.Guna2DataGridView();
            this.combobox_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.openChildForm = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.openChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Members
            // 
            this.dgv_Members.AllowUserToAddRows = false;
            this.dgv_Members.AllowUserToDeleteRows = false;
            this.dgv_Members.AllowUserToResizeColumns = false;
            this.dgv_Members.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Members.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Members.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Members.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Members.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Members.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Members.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Members.ColumnHeadersHeight = 4;
            this.dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Members.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Members.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Members.EnableHeadersVisualStyles = false;
            this.dgv_Members.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Members.Location = new System.Drawing.Point(0, 100);
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.ReadOnly = true;
            this.dgv_Members.RowHeadersVisible = false;
            this.dgv_Members.RowHeadersWidth = 51;
            this.dgv_Members.RowTemplate.Height = 24;
            this.dgv_Members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Members.Size = new System.Drawing.Size(1072, 620);
            this.dgv_Members.TabIndex = 0;
            this.dgv_Members.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Members.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Members.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Members.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Members.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Members.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Members.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Members.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Members.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Members.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Members.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Members.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Members.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Members.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_Members.ThemeStyle.ReadOnly = true;
            this.dgv_Members.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Members.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Members.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Members.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Members.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Members.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Members.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Members.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Members_CellClick);
            // 
            // combobox_FilterBy
            // 
            this.combobox_FilterBy.BackColor = System.Drawing.Color.Transparent;
            this.combobox_FilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_FilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.combobox_FilterBy.FocusedState.Parent = this.combobox_FilterBy;
            this.combobox_FilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_FilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_FilterBy.FormattingEnabled = true;
            this.combobox_FilterBy.HoverState.Parent = this.combobox_FilterBy;
            this.combobox_FilterBy.ItemHeight = 30;
            this.combobox_FilterBy.ItemsAppearance.Parent = this.combobox_FilterBy;
            this.combobox_FilterBy.Location = new System.Drawing.Point(12, 18);
            this.combobox_FilterBy.Name = "combobox_FilterBy";
            this.combobox_FilterBy.ShadowDecoration.Parent = this.combobox_FilterBy;
            this.combobox_FilterBy.Size = new System.Drawing.Size(250, 36);
            this.combobox_FilterBy.TabIndex = 43;
            this.combobox_FilterBy.SelectionChangeCommitted += new System.EventHandler(this.combobox_FilterBy_SelectionChangeCommitted);
            // 
            // button_Clear
            // 
            this.button_Clear.BorderRadius = 5;
            this.button_Clear.CheckedState.Parent = this.button_Clear;
            this.button_Clear.CustomImages.Parent = this.button_Clear;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.HoverState.Parent = this.button_Clear;
            this.button_Clear.Location = new System.Drawing.Point(901, 18);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.ShadowDecoration.Parent = this.button_Clear;
            this.button_Clear.Size = new System.Drawing.Size(86, 36);
            this.button_Clear.TabIndex = 20;
            this.button_Clear.Text = "Clear filter";
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.button_Clear);
            this.guna2Panel1.Controls.Add(this.combobox_FilterBy);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label_Email);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label_Id);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1072, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1044, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(25, 25);
            this.guna2ControlBox2.TabIndex = 65;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(291, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "LAST NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(925, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "SUBSCRIPTION";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.BackColor = System.Drawing.Color.White;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Email.Location = new System.Drawing.Point(763, 77);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(51, 20);
            this.label_Email.TabIndex = 37;
            this.label_Email.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(609, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(459, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "TYPE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(130, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "FIRST NAME";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.BackColor = System.Drawing.Color.White;
            this.label_Id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Id.Location = new System.Drawing.Point(3, 77);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(24, 20);
            this.label_Id.TabIndex = 33;
            this.label_Id.Text = "ID";
            // 
            // openChildForm
            // 
            this.openChildForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openChildForm.Controls.Add(this.guna2Panel1);
            this.openChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openChildForm.Location = new System.Drawing.Point(0, 0);
            this.openChildForm.Name = "openChildForm";
            this.openChildForm.ShadowDecoration.Parent = this.openChildForm;
            this.openChildForm.Size = new System.Drawing.Size(1072, 100);
            this.openChildForm.TabIndex = 2;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 720);
            this.Controls.Add(this.openChildForm);
            this.Controls.Add(this.dgv_Members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.openChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_Members;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_FilterBy;
        private Guna.UI2.WinForms.Guna2Button button_Clear;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Id;
        private Guna.UI2.WinForms.Guna2Panel openChildForm;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}