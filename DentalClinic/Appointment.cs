using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Appointment : Form
    {
        /// <summary>
        /// Connection String
        /// </summary>
                
        string AppointmentID = "";

        string sortBy = "";

        public Appointment()
        {
            InitializeComponent();
            comboSortBy.SelectedIndex = 0;
            update();
            updateAppointmentStatus();
        }
        public Appointment(string id)
        {
            InitializeComponent();
            AppointmentID = id;            
        }

        public void update()
        {
           string comand = "select A.AppointmentID," +
                "concat( P.P_FName,' ',P.P_MName,' ',P.P_LName) as 'اسم المريض' " +
                ",AppointmentDate as 'تاريخ الموعد',A.AppointmentType as 'نوع الموعد'" +
                ",(concat_ws('', S.S_Fname,' ',S.S_Mname,' ',S.S_LName)) as 'الطبيب'" +
                ",A.AppointmentFee as 'الرسوم',A.Status as 'حالة الموعد'" +
                " from Appointment A inner join Staff S on A.DentistId= S.StaffID  " +
                "inner join Patient P on P.PatientID = A.PatientId" +
                " "+sortBy+"";
            DataTable dt = globals.FillDataGridView(comand);

            dataAppointment.DataSource = dt;
            txtAppointmentID.DataBindings.Clear();
            txtAppointmentID.DataBindings.Add("text", dt, "AppointmentID");
        }             
            

        private void updateAppointmentStatus()
        {
            string comand = "UPDATE Appointment SET Status='فائت' " +
                "where AppointmentDate < '" + DateTime.Now + "'";
            globals.InsertUpdateSqlComand(comand);            
        }

        private void frmDentist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("هل تريد إغلاق البرنامج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.ExitThread();
                    e.Cancel = false;
                }
                else { e.Cancel = true; }
            }
            else { e.Cancel = true; }
        }
                      

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

      
        private void frmDentist_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelAppointment_Click(object sender, EventArgs e)
        {
            if(txtAppointmentID.Text != "")
            {
                globals.DeleteSqlComand("Appointment", "AppointmentID", txtAppointmentID.Text);
                update();
            }            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(txtAppointmentID.Text != "")
            {
                WinForms.AddAppointment(txtAppointmentID.Text, "Pid").ShowDialog();
                //AddAppointment = new AddAppointment(txtAppointmentID.Text, "Pid");
                //AddAppointment.ShowDialog();
                update();
            }            
        }

        private void frmDentist_SizeChanged(object sender, EventArgs e)
        {
            var width = this.Width;
            groupBox1.Width = (int)(width * 0.82);
            dataAppointment.Width = (int)(width * 0.8);
        }

        private void comboSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSortBy.SelectedIndex == 0)
                sortBy = "where A.AppointmentDate < DATEADD(day,1,CONVERT(VARCHAR,GETDATE(),101)) and A.AppointmentDate >= CONVERT(VARCHAR,GETDATE(),101)";
            else if (comboSortBy.SelectedIndex == 1)
                sortBy = "where A.AppointmentDate < DATEADD(day,7,CONVERT(VARCHAR,GETDATE(),101)) and A.AppointmentDate >= CONVERT(VARCHAR,GETDATE(),101)";
            else if (comboSortBy.SelectedIndex == 2)
                sortBy = "where A.AppointmentDate < DATEADD(day,30,GETDATE()) and A.AppointmentDate >= CONVERT(VARCHAR,GETDATE(),101)";
            else if (comboSortBy.SelectedIndex == 3)
                sortBy = "where A.AppointmentDate < CONVERT(VARCHAR,GETDATE(),101)";
            else if (comboSortBy.SelectedIndex == 4)
                sortBy = "";
            update();
        }
    }
}
