namespace DentalClinic
{
    partial class AddEditPatient
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePatientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPatientFName = new System.Windows.Forms.TextBox();
            this.cboPatientSex = new System.Windows.Forms.ComboBox();
            this.txtPatientMName = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.txtPatientLName = new System.Windows.Forms.TextBox();
            this.txtPatientContact = new System.Windows.Forms.TextBox();
            this.txtPatientAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(271, 397);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 30);
            this.saveBtn.TabIndex = 45;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = ":الاسم الأول";
            // 
            // dateTimePatientBirthDate
            // 
            this.dateTimePatientBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePatientBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePatientBirthDate.Location = new System.Drawing.Point(75, 183);
            this.dateTimePatientBirthDate.Name = "dateTimePatientBirthDate";
            this.dateTimePatientBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePatientBirthDate.RightToLeftLayout = true;
            this.dateTimePatientBirthDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePatientBirthDate.TabIndex = 44;
            this.dateTimePatientBirthDate.ValueChanged += new System.EventHandler(this.dateTimePatientBirthDate_ValueChanged);
            // 
            // txtPatientFName
            // 
            this.txtPatientFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientFName.Location = new System.Drawing.Point(75, 33);
            this.txtPatientFName.Name = "txtPatientFName";
            this.txtPatientFName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientFName.Size = new System.Drawing.Size(200, 26);
            this.txtPatientFName.TabIndex = 29;
            this.txtPatientFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientFName_KeyPress);
            // 
            // cboPatientSex
            // 
            this.cboPatientSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatientSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatientSex.FormattingEnabled = true;
            this.cboPatientSex.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cboPatientSex.Location = new System.Drawing.Point(75, 233);
            this.cboPatientSex.Name = "cboPatientSex";
            this.cboPatientSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPatientSex.Size = new System.Drawing.Size(200, 28);
            this.cboPatientSex.TabIndex = 43;
            // 
            // txtPatientMName
            // 
            this.txtPatientMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientMName.Location = new System.Drawing.Point(75, 83);
            this.txtPatientMName.Name = "txtPatientMName";
            this.txtPatientMName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientMName.Size = new System.Drawing.Size(200, 26);
            this.txtPatientMName.TabIndex = 30;
            this.txtPatientMName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientMName_KeyPress);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(175, 397);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(90, 30);
            this.clearBtn.TabIndex = 42;
            this.clearBtn.Text = "محو الكل";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // txtPatientLName
            // 
            this.txtPatientLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientLName.Location = new System.Drawing.Point(75, 133);
            this.txtPatientLName.Name = "txtPatientLName";
            this.txtPatientLName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientLName.Size = new System.Drawing.Size(200, 26);
            this.txtPatientLName.TabIndex = 31;
            this.txtPatientLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientLName_KeyPress);
            // 
            // txtPatientContact
            // 
            this.txtPatientContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientContact.Location = new System.Drawing.Point(75, 333);
            this.txtPatientContact.MaxLength = 7;
            this.txtPatientContact.Name = "txtPatientContact";
            this.txtPatientContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientContact.Size = new System.Drawing.Size(200, 26);
            this.txtPatientContact.TabIndex = 41;
            this.txtPatientContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientContact_KeyPress);
            // 
            // txtPatientAdd
            // 
            this.txtPatientAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientAdd.Location = new System.Drawing.Point(75, 283);
            this.txtPatientAdd.Name = "txtPatientAdd";
            this.txtPatientAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientAdd.Size = new System.Drawing.Size(200, 26);
            this.txtPatientAdd.TabIndex = 33;
            this.txtPatientAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientAdd_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = ":رقم الجوال";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = ":الاسم الأخير";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = ":العنوان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = ":الاسم الأوسط";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = ":الجنس";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAge.Location = new System.Drawing.Point(303, 187);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(78, 21);
            this.labAge.TabIndex = 37;
            this.labAge.Text = ":تاريخ الميلاد";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 47;
            this.button1.Text = "إلغاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePatientBirthDate);
            this.Controls.Add(this.txtPatientFName);
            this.Controls.Add(this.cboPatientSex);
            this.Controls.Add(this.txtPatientMName);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.txtPatientLName);
            this.Controls.Add(this.txtPatientContact);
            this.Controls.Add(this.txtPatientAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labAge);
            this.Name = "AddEditPatient";
            this.Text = "إضافة مريض";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditPatient_FormClosing);
            this.Load += new System.EventHandler(this.AddEditPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePatientBirthDate;
        private System.Windows.Forms.TextBox txtPatientFName;
        private System.Windows.Forms.ComboBox cboPatientSex;
        private System.Windows.Forms.TextBox txtPatientMName;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox txtPatientLName;
        private System.Windows.Forms.TextBox txtPatientContact;
        private System.Windows.Forms.TextBox txtPatientAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Button button1;
    }
}