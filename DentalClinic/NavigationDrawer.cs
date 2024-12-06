using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class NavigationDrawer : UserControl
    {
        public NavigationDrawer()
        {
            InitializeComponent();

            

            
        }

        private void NavigationDrawer_Load(object sender, EventArgs e)
        {
            //this.Size = MinimumSize;
            //var height = this.Parent.Height;
            //MessageBox.Show(height.ToString());
            //this.Height = height;
            this.Width = 40;
            if (globals.isAdministrator())
            {
                BtnStaff.Visible = true;
            }else
                BtnStaff.Visible = false;

        }

        private void NavigationDrawer_Click(object sender, EventArgs e)
        {
            if (this.Width == 40)
            {
                this.Width = 200;
            }
            else
            {
                this.Width = 40;
            }


        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
            //Form.ActiveForm.Hide();
            WinForms.Appointment().Show();
            
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            //Form.ActiveForm.Hide();
            this.Parent.Hide();
            WinForms.Patient.Show();
            

        }

        private void BtnStaff_Click(object sender, EventArgs e)
        { 
            //Form.ActiveForm.Hide();
            this.Parent.Hide();
            WinForms.Staff.Show();
           
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
            WinForms.CommandLineInterface.Show();
        }
    }
}
