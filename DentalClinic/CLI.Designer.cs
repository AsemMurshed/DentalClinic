namespace DentalClinic
{
    partial class frmCLI
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
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSQLExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataProvider = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Location = new System.Drawing.Point(23, 69);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dbGrid.Size = new System.Drawing.Size(768, 382);
            this.dbGrid.TabIndex = 0;
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(23, 470);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(768, 126);
            this.txtCommand.TabIndex = 1;
            // 
            // btnSQLExec
            // 
            this.btnSQLExec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSQLExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLExec.Location = new System.Drawing.Point(357, 618);
            this.btnSQLExec.Name = "btnSQLExec";
            this.btnSQLExec.Size = new System.Drawing.Size(90, 30);
            this.btnSQLExec.TabIndex = 2;
            this.btnSQLExec.Text = "SQL Exec";
            this.btnSQLExec.UseVisualStyleBackColor = true;
            this.btnSQLExec.Click += new System.EventHandler(this.btnSQLExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Provider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Source";
            // 
            // txtDataProvider
            // 
            this.txtDataProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataProvider.Location = new System.Drawing.Point(109, 8);
            this.txtDataProvider.Name = "txtDataProvider";
            this.txtDataProvider.Size = new System.Drawing.Size(656, 20);
            this.txtDataProvider.TabIndex = 6;
            this.txtDataProvider.Text = "AsemAlmoliki";
            this.txtDataProvider.Click += new System.EventHandler(this.txtDataProvider_Click);
            this.txtDataProvider.TextChanged += new System.EventHandler(this.txtDataProvider_TextChanged);
            // 
            // txtDataSource
            // 
            this.txtDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataSource.Location = new System.Drawing.Point(109, 33);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(656, 20);
            this.txtDataSource.TabIndex = 7;
            this.txtDataSource.Text = "DentalClinic";
            this.txtDataSource.Click += new System.EventHandler(this.txtDataSource_Click);
            this.txtDataSource.TextChanged += new System.EventHandler(this.txtDataSource_TextChanged);
            // 
            // frmCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 661);
            this.Controls.Add(this.txtDataSource);
            this.Controls.Add(this.txtDataProvider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSQLExec);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.dbGrid);
            this.Name = "frmCLI";
            this.Text = "CLI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCLI_FormClosing);
            this.Load += new System.EventHandler(this.frmCLI_Load);
            this.SizeChanged += new System.EventHandler(this.frmCLI_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnSQLExec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataProvider;
        private System.Windows.Forms.TextBox txtDataSource;
    }
}