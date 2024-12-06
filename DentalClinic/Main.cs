using System;
using System.Windows.Forms;
using SQLib;
using System.Data.SqlClient;
using System.Data;

namespace DentalClinic
{
    public partial class frmMain : Form
    {
 
        SQLLib sQuery = new SQLLib("AsemAlmoliki", "DentalClinic");
        public frmMain()
        {
            InitializeComponent();            
            cboEmpRestriction.SelectedIndex = 0;            
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("هل تريد إغلاق البرنامج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else { e.Cancel = true; }
            }
            else { e.Cancel = true; }
        }
                

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(sQuery.ConnectString());
            string command = @"select * from Staff where S_Username = '"+txtEmpUser.Text+"' AND" +
                " S_Password = '"+txtEmpPass.Text+"' AND S_Restriction = '"+cboEmpRestriction.Text+"'";

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(sQuery.Command, con);
                //SqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dt = globals.FillDataGridView(command);
                if (dt.Rows.Count>0)
                {
                    if (cboEmpRestriction.Text == "مسؤول")
                    {
                        var staffID = "";
                        staffID = dt.Rows[0]["StaffID"].ToString();
                            //staffID = dataReader["StaffID"].ToString();
                        
                        globals.setCredentials(txtEmpUser.Text, txtEmpPass.Text, "مسؤول", staffID);
                        WinForms.Main.Hide();
                        WinForms.Patient.Show();                   
                    }
                    else if (cboEmpRestriction.Text == "طبيب")
                    {
                        var staffID = "";
                        staffID = dt.Rows[0]["StaffID"].ToString();
                        //if (dataReader.Read())
                        //{
                        //    staffID = dataReader["StaffID"].ToString();
                        //}

                        globals.setCredentials(txtEmpUser.Text, txtEmpPass.Text, "طبيب", staffID);                        
                        WinForms.Main.Hide();
                        WinForms.Patient.Show();
                    }
                    else if (cboEmpRestriction.Text == "مستخدم")
                    {
                        var staffID = "";
                        staffID = dt.Rows[0]["StaffID"].ToString();
                        //if (dataReader.Read())
                        //{
                        //    staffID = dataReader["StaffID"].ToString();
                        //}
                        globals.setCredentials(txtEmpUser.Text, txtEmpPass.Text, "مستخدم", staffID);
                        WinForms.Main.Hide();
                        WinForms.Patient.Show();
                    }                    
                }
                else
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيح", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpUser.Focus();
                    txtEmpPass.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //con.Close();
            }            
        }
    }
}
