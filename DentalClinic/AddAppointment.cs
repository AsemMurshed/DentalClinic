using System;
using System.Data;
using System.Windows.Forms;
using DentalClinic.Internals;

namespace DentalClinic
{
    public partial class AddAppointment : Form
    {
        string AppointmentID = "";
        bool dentistChange = false;
      
        public AddAppointment(string Id)
        {
            InitializeComponent();
            var id = Id;
            txtPatientID.Text = id;
           
            comboAppointmentStatus.Enabled = false;

            string comand ="select concat( P_FName,' ',P_MName,' ',P_LName) as FullName" +
                    " from Patient where PatientID= '" + txtPatientID.Text + "'";                        
            DataTable dt = globals.FillDataGridView(comand);

            txtPatientName.Text = dt.Rows[0]["FullName"].ToString();

            string comand1 = "select StaffID, concat( S_Fname,' ',S_Mname,' ',S_LName) as FullName" +
                    " from Staff where S_Restriction ='طبيب'";
            DataTable dt1 = globals.FillDataGridView(comand1);            
            
            comboBoxDentistNames.DataSource = null;
            comboBoxDentistNames.DataSource = dt1;
            comboBoxDentistNames.DisplayMember = "FullName";
            comboBoxDentistNames.ValueMember = "StaffID";
            txtDentistID.Text = comboBoxDentistNames.SelectedValue.ToString();

            comboAppointmentStatus.SelectedIndex = 0;
            comboAppointmentType.SelectedIndex = 0;
        }


        public AddAppointment(string Id,string Pid)
        {
            InitializeComponent();
            AppointmentID = Id;

            string comand = "select StaffID, concat( S_Fname,' ',S_Mname,' ',S_LName) as FullName" +
                    " from Staff where S_Restriction ='طبيب'";
            DataTable dt1 = globals.FillDataGridView(comand);
            comboBoxDentistNames.DataSource = null;
            comboBoxDentistNames.DataSource = dt1;
            comboBoxDentistNames.DisplayMember = "FullName";
            comboBoxDentistNames.ValueMember = "StaffID";

            comand = "select AppointmentID," +
                "(select concat( P_FName,' ',P_MName,' ',P_LName))" +
                ",AppointmentType,(select concat(S_Fname,' ',S_Mname,' ',S_LName)) as Dname" +
                ",AppointmentFee,Status,P.PatientId,AppointmentDate" +                
                " from Appointment A inner join Staff S on A.DentistId= S.StaffID" +
                " inner join Patient P on A.PatientId=P.PatientID " +
                "where A.AppointmentID= '"+Id+"';";
            
            DataTable dt = globals.FillDataGridView(comand);

            DateTime date = DateTime.Now;
            DateTime.TryParse(dt.Rows[0][7].ToString(), out date);
            DateTimeAppointment.Value = date;
            txtPatientID.Text = dt.Rows[0][6].ToString();
            txtPatientName.Text = dt.Rows[0][1].ToString();
            comboAppointmentType.Text = dt.Rows[0][2].ToString();
            comboAppointmentStatus.Text = dt.Rows[0][5].ToString();
            var Dname = dt.Rows[0][3].ToString();
           
            for (int i = 0; i < comboBoxDentistNames.Items.Count; i++)
            {                
                comboBoxDentistNames.SelectedIndex=i;                
                if(comboBoxDentistNames.Text == Dname)
                {
                    comboBoxDentistNames.SelectedIndex = i ;
                    break;
                }                
            }            
            if ((bool)dt.Rows[0][4] == true)
            {
                checkFee.Checked = true;
            }       
        }      


        private void AddAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppointmentID == "")
            {                
                WinForms.PatientRecord(txtPatientID.Text).Show();
            }
            else
            {
                                
            }
        }

        private void comboBoxDentistNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           txtDentistID.Text = comboBoxDentistNames.SelectedValue.ToString();
            dentistChange = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(AppointmentID == "")
            {
               WinForms.PatientRecord(txtPatientID.Text).Show();    
            }
            else
            {
                                         
            }            
        }


        private void addAppintment()
        {
            var Checked = (checkFee.Checked==true)?1:0;
                        
            if (txtPatientID.Text != "" && txtDentistID.Text != "" && dentistChange == true && comboAppointmentType.Text != ""
                && comboAppointmentStatus.Text != "" && DateTimeAppointment.Checked == true)
            {               
                string comand = "INSERT INTO Appointment (PatientId,DentistId,AppointmentDate,AppointmentType,StaffID,Status,AppointmentFee) VALUES " +
                    "('" + txtPatientID.Text + "' , '" + txtDentistID.Text + "' , '" + DateTimeAppointment.Value + "' , '" + comboAppointmentType.Text + "' ," +
                    " '" + Credentials.StaffID + "' ,'" + comboAppointmentStatus.Text + "' ," + Checked  + ")";

                globals.InsertUpdateSqlComand(comand);           
                this.Hide();
                WinForms.Appointment().Show();
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }

        private void editAppointment()
        {
            var Checked = (checkFee.Checked == true) ? 1 : 0;
            if (AppointmentID != "" && txtDentistID.Text != "" && comboAppointmentType.Text != ""
                && comboAppointmentStatus.Text != "" && DateTimeAppointment.Checked == true)
            {
                string comand = "UPDATE Appointment SET DentistId='" + txtDentistID.Text + "', " +
                    "AppointmentDate='" + DateTimeAppointment.Value + "',AppointmentType='" + comboAppointmentType.Text + "'," +
                    "Status='" + comboAppointmentStatus.Text + "', AppointmentFee='" + Checked +"' "+
                    "WHERE PatientID='" + txtPatientID.Text + "'";

                globals.InsertUpdateSqlComand(comand);
                this.Hide();
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           if(AppointmentID == "")
            {
                addAppintment();                
            }
           else
                editAppointment();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    } }
