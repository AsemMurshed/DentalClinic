using System;
using System.Data;
using System.Windows.Forms;
using SQLib;

namespace DentalClinic
{
    public partial class frmCLI : Form
    {
        public frmCLI()
        {
            InitializeComponent();
        }

        private void frmCLI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                WinForms.Patient.Show();
            }
        }

        private void frmCLI_Load(object sender, EventArgs e)
        {
            txtDataProvider.Text = globals.DataProvider;
            txtDataSource.Text = globals.DataSource;
        }

        private void btnSQLExec_Click(object sender, EventArgs e)
        {
            if(txtCommand.Text != "")
            {
                //sQuery = new SQLLib(txtDataProvider.Text, txtDataSource.Text);
                DataTable dt = globals.FillDataGridView(txtCommand.Text);
                dbGrid.DataSource = dt;

            }            
        }

        
        private void txtDataProvider_TextChanged(object sender, EventArgs e)
        {
            globals.DataProvider = txtDataProvider.Text;
        }

        private void txtDataSource_TextChanged(object sender, EventArgs e)
        {
            globals.DataSource = txtDataSource.Text;
        }

        private void txtDataProvider_Click(object sender, EventArgs e)
        {
            txtDataProvider.SelectAll();
        }

        private void txtDataSource_Click(object sender, EventArgs e)
        {
            txtDataSource.SelectAll();
        }

        private void frmCLI_SizeChanged(object sender, EventArgs e)
        {
            //var width = this.Width;
            //dbGrid.Width = (int)(width * 0.90);
        }
    }
}
