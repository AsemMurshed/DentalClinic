using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class PatientRecord : Form
    {
        string PatientID; 
                       
        public PatientRecord(string Id)
        {
            InitializeComponent();
            PatientID = Id;
            update();            
            
            string comand ="select PatientID,concat( P_FName,' ',P_MName,' ',P_LName) as FullName" +
                    " from Patient where PatientID= '" + Id + "'";          
            DataTable dt = globals.FillDataGridView(comand);            
            labPateintName.Text = dt.Rows[0]["FullName"].ToString();
        }    


        void update()
        {            
            string comand = "select ConsultID,DentistId,(select concat( S_Fname,' ',S_Mname,' ',S_LName) as FullName" +
                    " from Staff where StaffID =Consultation.DentistId) as 'اسم الطبيب',ChiefComplaint as 'الشكوى الرئيسية'" +
                    ",MedicalHistory as 'التاريخ الطبي',PastDentalHistory as 'المعالجة السنية السابقة',Diagnosis as 'التشخيص'" +
                    ",Treatment as 'تفاصيل المعالجة',ConsultatDate as 'التاريخ' from Consultation where PatientId='"+PatientID+"'";
            DataTable dt = globals.FillDataGridView(comand);
            
            dt.Columns[1].ColumnMapping = MappingType.Hidden;
            dataConsultation.DataSource = dt;            
            
            txtConsultID.DataBindings.Clear();
            txtConsultID.DataBindings.Add("text", dt, "ConsultID");
            
            txtDentistID.DataBindings.Clear();
            txtDentistID.DataBindings.Add("text", dt, "DentistId");            
        }


        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if(dataConsultation.Rows.Count > 0)
            {               
                //var ChiefComplaint = dataConsultation.SelectedRows[0].Cells[1].Value.ToString();
                //var History = dataConsultation.SelectedRows[0].Cells[2].Value.ToString();
                //var PDhistory = dataConsultation.SelectedRows[0].Cells[3].Value.ToString();
                //var Diagnosis = dataConsultation.SelectedRows[0].Cells[4].Value.ToString();
                //var Treatment = dataConsultation.SelectedRows[0].Cells[5].Value.ToString();
                //var date = dataConsultation.SelectedRows[0].Cells[6].Value.ToString();
                //var ConsultDate = DateTime.Parse(date);

                WinForms.Consultation(txtConsultID.Text, PatientID).Show();
                
                //Consultation = new Consultation(txtConsultID.Text, PatientID, txtDentistID.Text, ConsultDate, ChiefComplaint, History, PDhistory, Diagnosis, Treatment);
                //Consultation.Show();
                this.Hide();
            }            
        }
        

        private void PatientRecord_FormClosing(object sender, FormClosingEventArgs e)
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

       
        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {            
            WinForms.AddAppointment(PatientID).Show();
            this.Hide();
        }
        

        private void PatientRecord_Load(object sender, EventArgs e)
        {
            if (globals.isAdministrator())
            {
                BtnDelete.Visible = true;
            }
            else
                BtnDelete.Visible = false;
        }

        private void BtnAddConsult_Click_1(object sender, EventArgs e)
        {
            WinForms.Consultation(PatientID).Show();             
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {            
            WinForms.Patient.Show();
            this.Hide();
        }

        private void PatientRecord_SizeChanged(object sender, EventArgs e)
        {
            var width = this.Width;
            dataConsultation.Width = (int)(width * 0.8);
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            string command = "select * from Bill where ConsultationID='" + txtConsultID.Text + "'";
            try
            {
                DataTable dt = globals.FillDataGridView(command);
                if (dt.Rows.Count > 0)
                {
                    WinForms.Bill(txtConsultID.Text, PatientID).Show();
                    this.Hide();
                }
                else
                {
                    DialogResult choice = WinForms.AddBill(txtConsultID.Text, PatientID).ShowDialog();
                    if(choice == DialogResult.OK)
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void dataConsultation_SelectionChanged(object sender, EventArgs e)
        {
            string command = "select * from Bill where ConsultationID='" + txtConsultID.Text + "'";
            DataTable dt = globals.FillDataGridView(command);
            if (dt.Rows.Count > 0)
            {BtnBill.Text = "تفاصيل الفاتورة";}
            else
            {BtnBill.Text = "إصدار فاتورة";}
        }
    }





    

}
