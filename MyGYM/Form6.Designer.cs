
namespace MyGYM
{
    partial class Form6
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_ErrorW = new System.Windows.Forms.Label();
            this.label_ErrorH = new System.Windows.Forms.Label();
            this.label_Information = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_BMI = new System.Windows.Forms.Label();
            this.picture_Calculator = new Guna.UI2.WinForms.Guna2PictureBox();
            this.button_Calculate = new Guna.UI2.WinForms.Guna2Button();
            this.picture_Weight = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textbox_Weight = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Weight = new System.Windows.Forms.Label();
            this.picture_Height = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textbox_Height = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Height = new System.Windows.Forms.Label();
            this.label_PageTitle = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Calculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Height)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.label_ErrorW);
            this.guna2Panel1.Controls.Add(this.label_ErrorH);
            this.guna2Panel1.Controls.Add(this.label_Information);
            this.guna2Panel1.Controls.Add(this.label_Result);
            this.guna2Panel1.Controls.Add(this.label_BMI);
            this.guna2Panel1.Controls.Add(this.picture_Calculator);
            this.guna2Panel1.Controls.Add(this.button_Calculate);
            this.guna2Panel1.Controls.Add(this.picture_Weight);
            this.guna2Panel1.Controls.Add(this.textbox_Weight);
            this.guna2Panel1.Controls.Add(this.label_Weight);
            this.guna2Panel1.Controls.Add(this.picture_Height);
            this.guna2Panel1.Controls.Add(this.textbox_Height);
            this.guna2Panel1.Controls.Add(this.label_Height);
            this.guna2Panel1.Controls.Add(this.label_PageTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1072, 720);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label_ErrorW
            // 
            this.label_ErrorW.AutoSize = true;
            this.label_ErrorW.BackColor = System.Drawing.Color.White;
            this.label_ErrorW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ErrorW.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorW.Location = new System.Drawing.Point(139, 227);
            this.label_ErrorW.Name = "label_ErrorW";
            this.label_ErrorW.Size = new System.Drawing.Size(0, 20);
            this.label_ErrorW.TabIndex = 42;
            // 
            // label_ErrorH
            // 
            this.label_ErrorH.AutoSize = true;
            this.label_ErrorH.BackColor = System.Drawing.Color.White;
            this.label_ErrorH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ErrorH.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorH.Location = new System.Drawing.Point(139, 131);
            this.label_ErrorH.Name = "label_ErrorH";
            this.label_ErrorH.Size = new System.Drawing.Size(0, 20);
            this.label_ErrorH.TabIndex = 41;
            // 
            // label_Information
            // 
            this.label_Information.AutoSize = true;
            this.label_Information.BackColor = System.Drawing.Color.White;
            this.label_Information.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Information.ForeColor = System.Drawing.Color.Gray;
            this.label_Information.Location = new System.Drawing.Point(70, 586);
            this.label_Information.Name = "label_Information";
            this.label_Information.Size = new System.Drawing.Size(211, 80);
            this.label_Information.TabIndex = 40;
            this.label_Information.Text = "Underweight = <18.5\r\nNormal weight = 18.5–24.9\r\nOverweight = 25–29.9\r\nObesity = B" +
    "MI of 30 or greater";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.White;
            this.label_Result.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_Result.Location = new System.Drawing.Point(263, 414);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 25);
            this.label_Result.TabIndex = 39;
            // 
            // label_BMI
            // 
            this.label_BMI.AutoSize = true;
            this.label_BMI.BackColor = System.Drawing.Color.White;
            this.label_BMI.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_BMI.Location = new System.Drawing.Point(214, 414);
            this.label_BMI.Name = "label_BMI";
            this.label_BMI.Size = new System.Drawing.Size(53, 25);
            this.label_BMI.TabIndex = 38;
            this.label_BMI.Text = "BMI:";
            this.label_BMI.Visible = false;
            // 
            // picture_Calculator
            // 
            this.picture_Calculator.Image = global::MyGYM.Properties.Resources._3353181;
            this.picture_Calculator.Location = new System.Drawing.Point(521, 41);
            this.picture_Calculator.Name = "picture_Calculator";
            this.picture_Calculator.ShadowDecoration.Parent = this.picture_Calculator;
            this.picture_Calculator.Size = new System.Drawing.Size(539, 437);
            this.picture_Calculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Calculator.TabIndex = 37;
            this.picture_Calculator.TabStop = false;
            // 
            // button_Calculate
            // 
            this.button_Calculate.BorderRadius = 5;
            this.button_Calculate.CheckedState.Parent = this.button_Calculate;
            this.button_Calculate.CustomImages.Parent = this.button_Calculate;
            this.button_Calculate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Calculate.ForeColor = System.Drawing.Color.White;
            this.button_Calculate.HoverState.Parent = this.button_Calculate;
            this.button_Calculate.Location = new System.Drawing.Point(160, 344);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.ShadowDecoration.Parent = this.button_Calculate;
            this.button_Calculate.Size = new System.Drawing.Size(207, 46);
            this.button_Calculate.TabIndex = 36;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // picture_Weight
            // 
            this.picture_Weight.BackColor = System.Drawing.Color.White;
            this.picture_Weight.Image = global::MyGYM.Properties.Resources.weight_scale;
            this.picture_Weight.Location = new System.Drawing.Point(74, 254);
            this.picture_Weight.Name = "picture_Weight";
            this.picture_Weight.ShadowDecoration.Parent = this.picture_Weight;
            this.picture_Weight.Size = new System.Drawing.Size(25, 30);
            this.picture_Weight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Weight.TabIndex = 35;
            this.picture_Weight.TabStop = false;
            // 
            // textbox_Weight
            // 
            this.textbox_Weight.Animated = true;
            this.textbox_Weight.BorderRadius = 5;
            this.textbox_Weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Weight.DefaultText = "";
            this.textbox_Weight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Weight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Weight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Weight.DisabledState.Parent = this.textbox_Weight;
            this.textbox_Weight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Weight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Weight.FocusedState.Parent = this.textbox_Weight;
            this.textbox_Weight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Weight.HoverState.Parent = this.textbox_Weight;
            this.textbox_Weight.Location = new System.Drawing.Point(65, 251);
            this.textbox_Weight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_Weight.Name = "textbox_Weight";
            this.textbox_Weight.PasswordChar = '\0';
            this.textbox_Weight.PlaceholderText = "";
            this.textbox_Weight.SelectedText = "";
            this.textbox_Weight.ShadowDecoration.Parent = this.textbox_Weight;
            this.textbox_Weight.Size = new System.Drawing.Size(425, 44);
            this.textbox_Weight.TabIndex = 34;
            this.textbox_Weight.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.BackColor = System.Drawing.Color.White;
            this.label_Weight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Weight.Location = new System.Drawing.Point(70, 227);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(56, 20);
            this.label_Weight.TabIndex = 33;
            this.label_Weight.Text = "Weight";
            // 
            // picture_Height
            // 
            this.picture_Height.BackColor = System.Drawing.Color.White;
            this.picture_Height.Image = global::MyGYM.Properties.Resources.height1;
            this.picture_Height.Location = new System.Drawing.Point(74, 161);
            this.picture_Height.Name = "picture_Height";
            this.picture_Height.ShadowDecoration.Parent = this.picture_Height;
            this.picture_Height.Size = new System.Drawing.Size(25, 30);
            this.picture_Height.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Height.TabIndex = 32;
            this.picture_Height.TabStop = false;
            // 
            // textbox_Height
            // 
            this.textbox_Height.Animated = true;
            this.textbox_Height.BorderRadius = 5;
            this.textbox_Height.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Height.DefaultText = "";
            this.textbox_Height.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Height.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Height.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Height.DisabledState.Parent = this.textbox_Height;
            this.textbox_Height.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Height.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Height.FocusedState.Parent = this.textbox_Height;
            this.textbox_Height.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Height.HoverState.Parent = this.textbox_Height;
            this.textbox_Height.Location = new System.Drawing.Point(65, 155);
            this.textbox_Height.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_Height.Name = "textbox_Height";
            this.textbox_Height.PasswordChar = '\0';
            this.textbox_Height.PlaceholderText = "";
            this.textbox_Height.SelectedText = "";
            this.textbox_Height.ShadowDecoration.Parent = this.textbox_Height;
            this.textbox_Height.Size = new System.Drawing.Size(425, 44);
            this.textbox_Height.TabIndex = 14;
            this.textbox_Height.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.BackColor = System.Drawing.Color.White;
            this.label_Height.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Height.Location = new System.Drawing.Point(61, 131);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(54, 20);
            this.label_Height.TabIndex = 13;
            this.label_Height.Text = "Height";
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.AutoSize = true;
            this.label_PageTitle.BackColor = System.Drawing.Color.White;
            this.label_PageTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_PageTitle.Location = new System.Drawing.Point(34, 41);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(398, 40);
            this.label_PageTitle.TabIndex = 3;
            this.label_PageTitle.Text = "Body Mass Index Calculator";
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 720);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Calculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Height)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label_PageTitle;
        private System.Windows.Forms.Label label_Height;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Height;
        private Guna.UI2.WinForms.Guna2PictureBox picture_Height;
        private System.Windows.Forms.Label label_Weight;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Weight;
        private Guna.UI2.WinForms.Guna2PictureBox picture_Weight;
        private Guna.UI2.WinForms.Guna2Button button_Calculate;
        private Guna.UI2.WinForms.Guna2PictureBox picture_Calculator;
        private System.Windows.Forms.Label label_BMI;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_Information;
        private System.Windows.Forms.Label label_ErrorW;
        private System.Windows.Forms.Label label_ErrorH;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}