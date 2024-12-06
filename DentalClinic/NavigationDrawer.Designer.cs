namespace DentalClinic
{
    partial class NavigationDrawer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationDrawer));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnStaff = new System.Windows.Forms.Button();
            this.BtnAppointment = new System.Windows.Forms.Button();
            this.BtnBill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Cyan;
            this.flowLayoutPanel1.Controls.Add(this.BtnPatient);
            this.flowLayoutPanel1.Controls.Add(this.BtnStaff);
            this.flowLayoutPanel1.Controls.Add(this.BtnAppointment);
            this.flowLayoutPanel1.Controls.Add(this.BtnBill);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 468);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackColor = System.Drawing.Color.White;
            this.BtnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPatient.Image = ((System.Drawing.Image)(resources.GetObject("BtnPatient.Image")));
            this.BtnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPatient.Location = new System.Drawing.Point(0, 0);
            this.BtnPatient.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(200, 49);
            this.BtnPatient.TabIndex = 4;
            this.BtnPatient.Text = "قائمة المرضى";
            this.BtnPatient.UseVisualStyleBackColor = false;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnStaff
            // 
            this.BtnStaff.BackColor = System.Drawing.Color.White;
            this.BtnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnStaff.Image = ((System.Drawing.Image)(resources.GetObject("BtnStaff.Image")));
            this.BtnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStaff.Location = new System.Drawing.Point(0, 49);
            this.BtnStaff.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStaff.Name = "BtnStaff";
            this.BtnStaff.Size = new System.Drawing.Size(200, 49);
            this.BtnStaff.TabIndex = 5;
            this.BtnStaff.Text = "قائمة الموظفين";
            this.BtnStaff.UseVisualStyleBackColor = false;
            this.BtnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // BtnAppointment
            // 
            this.BtnAppointment.BackColor = System.Drawing.Color.White;
            this.BtnAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAppointment.Image = ((System.Drawing.Image)(resources.GetObject("BtnAppointment.Image")));
            this.BtnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAppointment.Location = new System.Drawing.Point(0, 98);
            this.BtnAppointment.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAppointment.Name = "BtnAppointment";
            this.BtnAppointment.Size = new System.Drawing.Size(200, 49);
            this.BtnAppointment.TabIndex = 7;
            this.BtnAppointment.Text = "قائمةالمواعيد.";
            this.BtnAppointment.UseVisualStyleBackColor = false;
            this.BtnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // BtnBill
            // 
            this.BtnBill.BackColor = System.Drawing.Color.White;
            this.BtnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBill.Image = ((System.Drawing.Image)(resources.GetObject("BtnBill.Image")));
            this.BtnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBill.Location = new System.Drawing.Point(0, 147);
            this.BtnBill.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.Size = new System.Drawing.Size(200, 49);
            this.BtnBill.TabIndex = 6;
            this.BtnBill.Text = "واجهة التقارير";
            this.BtnBill.UseVisualStyleBackColor = false;
            this.BtnBill.Click += new System.EventHandler(this.BtnBill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NavigationDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(200, 4000);
            this.MinimumSize = new System.Drawing.Size(40, 600);
            this.Name = "NavigationDrawer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(200, 600);
            this.Load += new System.EventHandler(this.NavigationDrawer_Load);
            this.Click += new System.EventHandler(this.NavigationDrawer_Click);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnAppointment;
        private System.Windows.Forms.Button BtnBill;
        private System.Windows.Forms.Button BtnStaff;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
