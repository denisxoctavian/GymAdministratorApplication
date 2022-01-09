
namespace MyGYM
{
    partial class Form11
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
            this.components = new System.ComponentModel.Container();
            this.label_PageTitle = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Update = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.AutoSize = true;
            this.label_PageTitle.BackColor = System.Drawing.Color.White;
            this.label_PageTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_PageTitle.Location = new System.Drawing.Point(345, 135);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(323, 40);
            this.label_PageTitle.TabIndex = 2;
            this.label_PageTitle.Text = "How can we help you?";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.White;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Name.Location = new System.Drawing.Point(367, 175);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(266, 20);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Feel free to contact us for any problem";
            // 
            // button_Update
            // 
            this.button_Update.BorderRadius = 5;
            this.button_Update.CheckedState.Parent = this.button_Update;
            this.button_Update.CustomImages.Parent = this.button_Update;
            this.button_Update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.HoverState.Parent = this.button_Update;
            this.button_Update.Location = new System.Drawing.Point(399, 253);
            this.button_Update.Name = "button_Update";
            this.button_Update.ShadowDecoration.Parent = this.button_Update;
            this.button_Update.Size = new System.Drawing.Size(207, 46);
            this.button_Update.TabIndex = 20;
            this.button_Update.Text = "Contact us";
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = null;
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
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 720);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_PageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PageTitle;
        private System.Windows.Forms.Label label_Name;
        private Guna.UI2.WinForms.Guna2Button button_Update;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}