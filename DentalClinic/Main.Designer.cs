namespace DentalClinic
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpUser = new System.Windows.Forms.TextBox();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEmpRestriction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(216, 395);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "دخول";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "كلمة السر";
            // 
            // txtEmpUser
            // 
            this.txtEmpUser.Location = new System.Drawing.Point(127, 252);
            this.txtEmpUser.Name = "txtEmpUser";
            this.txtEmpUser.Size = new System.Drawing.Size(152, 20);
            this.txtEmpUser.TabIndex = 6;
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.Location = new System.Drawing.Point(127, 288);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.PasswordChar = '*';
            this.txtEmpPass.Size = new System.Drawing.Size(152, 20);
            this.txtEmpPass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "القيد";
            // 
            // cboEmpRestriction
            // 
            this.cboEmpRestriction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpRestriction.FormattingEnabled = true;
            this.cboEmpRestriction.Items.AddRange(new object[] {
            "مستخدم",
            "مسؤول",
            "طبيب"});
            this.cboEmpRestriction.Location = new System.Drawing.Point(127, 324);
            this.cboEmpRestriction.Name = "cboEmpRestriction";
            this.cboEmpRestriction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboEmpRestriction.Size = new System.Drawing.Size(152, 21);
            this.cboEmpRestriction.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.cboEmpRestriction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpPass);
            this.Controls.Add(this.txtEmpUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dental Clinic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpUser;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEmpRestriction;
    }
}

