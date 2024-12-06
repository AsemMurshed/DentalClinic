namespace DentalClinic
{
    partial class AddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaff));
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.txtEmpUser = new System.Windows.Forms.TextBox();
            this.txtEmpContact = new System.Windows.Forms.TextBox();
            this.txtEmpAdd = new System.Windows.Forms.TextBox();
            this.txtEmpLName = new System.Windows.Forms.TextBox();
            this.txtEmpFName = new System.Windows.Forms.TextBox();
            this.cboEmpRestriction = new System.Windows.Forms.ComboBox();
            this.txtEmpMName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(277, 453);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(90, 30);
            this.btnSignup.TabIndex = 9;
            this.btnSignup.Text = "حفظ";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(85, 453);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 30);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "مسح الكل";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "القيد:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "الاسم الأول:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "الاسم الأخير:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "العنوان:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "رقم الجوال:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "اسم المستخدم:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "كلمة السر:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPass.Location = new System.Drawing.Point(75, 333);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.PasswordChar = '*';
            this.txtEmpPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpPass.Size = new System.Drawing.Size(200, 26);
            this.txtEmpPass.TabIndex = 7;
            this.txtEmpPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpPass_KeyPress);
            // 
            // txtEmpUser
            // 
            this.txtEmpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpUser.Location = new System.Drawing.Point(75, 283);
            this.txtEmpUser.Name = "txtEmpUser";
            this.txtEmpUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpUser.Size = new System.Drawing.Size(200, 26);
            this.txtEmpUser.TabIndex = 6;
            this.txtEmpUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpUser_KeyPress);
            // 
            // txtEmpContact
            // 
            this.txtEmpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpContact.Location = new System.Drawing.Point(75, 233);
            this.txtEmpContact.MaxLength = 7;
            this.txtEmpContact.Name = "txtEmpContact";
            this.txtEmpContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpContact.Size = new System.Drawing.Size(200, 26);
            this.txtEmpContact.TabIndex = 5;
            this.txtEmpContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpContact_KeyPress);
            // 
            // txtEmpAdd
            // 
            this.txtEmpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAdd.Location = new System.Drawing.Point(75, 183);
            this.txtEmpAdd.Name = "txtEmpAdd";
            this.txtEmpAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpAdd.Size = new System.Drawing.Size(200, 26);
            this.txtEmpAdd.TabIndex = 4;
            this.txtEmpAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpAdd_KeyPress);
            // 
            // txtEmpLName
            // 
            this.txtEmpLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpLName.Location = new System.Drawing.Point(75, 133);
            this.txtEmpLName.Name = "txtEmpLName";
            this.txtEmpLName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpLName.Size = new System.Drawing.Size(200, 26);
            this.txtEmpLName.TabIndex = 3;
            this.txtEmpLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpLName_KeyPress);
            // 
            // txtEmpFName
            // 
            this.txtEmpFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpFName.Location = new System.Drawing.Point(75, 33);
            this.txtEmpFName.Name = "txtEmpFName";
            this.txtEmpFName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpFName.Size = new System.Drawing.Size(200, 26);
            this.txtEmpFName.TabIndex = 1;
            this.txtEmpFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpFName_KeyPress);
            // 
            // cboEmpRestriction
            // 
            this.cboEmpRestriction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpRestriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpRestriction.FormattingEnabled = true;
            this.cboEmpRestriction.Items.AddRange(new object[] {
            "مستخدم",
            "مسؤول",
            "طبيب"});
            this.cboEmpRestriction.Location = new System.Drawing.Point(75, 383);
            this.cboEmpRestriction.Name = "cboEmpRestriction";
            this.cboEmpRestriction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboEmpRestriction.Size = new System.Drawing.Size(200, 28);
            this.cboEmpRestriction.TabIndex = 8;
            this.cboEmpRestriction.SelectedIndexChanged += new System.EventHandler(this.cboEmpRestriction_SelectedIndexChanged);
            // 
            // txtEmpMName
            // 
            this.txtEmpMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpMName.Location = new System.Drawing.Point(75, 83);
            this.txtEmpMName.Name = "txtEmpMName";
            this.txtEmpMName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpMName.Size = new System.Drawing.Size(200, 26);
            this.txtEmpMName.TabIndex = 2;
            this.txtEmpMName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpMName_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "الاسم الأوسط:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(181, 453);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 30);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txtEmpMName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboEmpRestriction);
            this.Controls.Add(this.txtEmpFName);
            this.Controls.Add(this.txtEmpLName);
            this.Controls.Add(this.txtEmpAdd);
            this.Controls.Add(this.txtEmpContact);
            this.Controls.Add(this.txtEmpUser);
            this.Controls.Add(this.txtEmpPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSignup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "إضافة موظف";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.TextBox txtEmpUser;
        private System.Windows.Forms.TextBox txtEmpContact;
        private System.Windows.Forms.TextBox txtEmpAdd;
        private System.Windows.Forms.TextBox txtEmpLName;
        private System.Windows.Forms.TextBox txtEmpFName;
        private System.Windows.Forms.ComboBox cboEmpRestriction;
        private System.Windows.Forms.TextBox txtEmpMName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCancel;
    }
}