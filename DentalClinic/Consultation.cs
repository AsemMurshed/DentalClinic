using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DentalClinic
{
    public partial class Consultation : Form
    {
        string PatientID = "";
        string ConsultID = "";        
                
        ImageList imgs = new ImageList();
        int ImageIndex = 0;
        ImageList newImgs = new ImageList();        

        List<string> DeletedImages = new List<string>();
        
        
        public Consultation(string Id)
        {            
            InitializeComponent();
            clear();
            PatientID = Id;
            ListviewPropreties();   
                                            
            string comand = "select PatientID,concat( P_FName,' ',P_MName,' ',P_LName) as FullName" +
                    " from Patient where PatientID= '" + PatientID + "'";
            DataTable dt = globals.FillDataGridView(comand);                        
            txtPatientName.Text = dt.Rows[0]["FullName"].ToString() ;

            string comand2 = "select StaffID, concat( S_Fname,' ',S_Mname,' ',S_LName) as FullName" +
                    " from Staff where S_Restriction ='طبيب'";
            DataTable dt2 = globals.FillDataGridView(comand2);            
            
            comboBoxDentistNames.DataSource = null;
            comboBoxDentistNames.DataSource = dt2;
            comboBoxDentistNames.DisplayMember = "FullName";
            comboBoxDentistNames.ValueMember = "StaffID";
            txtDentistID.Text = comboBoxDentistNames.SelectedValue.ToString();
        }
       
        public Consultation(string ConsultId,string PatientId)
        {
            InitializeComponent();            
            dateTimeConsult.Visible = true;
            labDate.Visible = true;
            BtnBill.Visible = true;
            BtnDeleteImage.Enabled = true;

            string comand = "select ConsultID,PatientId,DentistId,ChiefComplaint " +
                    ",MedicalHistory,PastDentalHistory,Diagnosis " +
                    ",Treatment,ConsultatDate from Consultation where ConsultID='" + ConsultId + "'";
            DataTable dt = globals.FillDataGridView(comand);            

            dateTimeConsult.Value = DateTime.Parse(dt.Rows[0]["ConsultatDate"].ToString()); 
            richTxtChiefComplaint.Text = dt.Rows[0]["ChiefComplaint"].ToString();
            richTxtPastDentalHistory.Text = dt.Rows[0]["PastDentalHistory"].ToString();
            richTxtDiagnosis.Text = dt.Rows[0]["Diagnosis"].ToString();
            richTxtHistory.Text = dt.Rows[0]["MedicalHistory"].ToString();
            richTxtTreatment.Text = dt.Rows[0]["Treatment"].ToString(); ;
            ConsultID = ConsultId;
            PatientID = dt.Rows[0]["PatientId"].ToString();
            var DentistID = dt.Rows[0]["DentistId"].ToString();

            string comand1 = "select StaffID, concat_ws('', S_Fname,' ',S_Mname,' ',S_LName) as FullName" +
                  " from Staff where StaffID= '" + DentistID + "'";
            DataTable dt1 = globals.FillDataGridView(comand1);
            
            comboBoxDentistNames.DataSource = null;
            comboBoxDentistNames.DataSource = dt1;
            comboBoxDentistNames.DisplayMember = "FullName";
            comboBoxDentistNames.ValueMember = "StaffID";

            string comand2 = "select PatientID,concat( P_FName,' ',P_MName,' ',P_LName) as FullName" +
                    " from Patient where PatientID= '" + PatientID + "'";
            DataTable dt2 = globals.FillDataGridView(comand2);            
            txtPatientName.Text = dt2.Rows[0]["FullName"].ToString();

            LoadImagesToListview();            
        }


        private void comboBoxDentistNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDentistID.Text = comboBoxDentistNames.SelectedValue.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ConsultID == "")
            {AddConsultation();}
            else
            {EditConsultation();}
        }

        void AddConsultation()
        {            
            if (PatientID != "" && txtDentistID.Text != "" && richTxtTreatment.Text != ""
                && richTxtHistory.Text != "" && richTxtDiagnosis.Text != "" && richTxtPastDentalHistory.Text != "")
            {               
                string command = "INSERT INTO Consultation (PatientId,DentistId,ConsultatDate,ChiefComplaint" +
                    ",MedicalHistory,Diagnosis,Treatment,PastDentalHistory) VALUES " +
                    "('"+PatientID+"','"+txtDentistID.Text+"','"+DateTime.Now+"','"+richTxtChiefComplaint.Text+"'"+
                    ",'"+richTxtHistory.Text+"','"+richTxtDiagnosis.Text+"','"+richTxtTreatment.Text+"'"+
                    ",'"+richTxtPastDentalHistory.Text+"'); ";                                
                
                    DialogResult choice = MessageBox.Show("هل تريد فعلاً إضافة استشارة؟", "تأكيد",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1                    
                        );
                    if (choice == DialogResult.Yes)
                    {                        
                        ConsultID = globals.InsertUpdateSqlComand(command);
                        SaveImges();                     
                        BtnBill.Visible = true;
                    }
                    else
                    {  }                
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }

        void EditConsultation()
        {            
            if (richTxtHistory.Text != "" && richTxtDiagnosis.Text != "" && richTxtTreatment.Text != "" && richTxtPastDentalHistory.Text != "")
            {                
                string comand = "UPDATE Consultation SET " +
                    "ChiefComplaint='"+richTxtChiefComplaint.Text+"',MedicalHistory='"+richTxtHistory.Text+"',"+
                    "Diagnosis='"+ richTxtDiagnosis.Text + "', Treatment = '" + richTxtTreatment.Text + "'," +
                    "PastDentalHistory ='"+richTxtPastDentalHistory.Text+"' WHERE ConsultID='" + ConsultID + "'";
                globals.InsertUpdateSqlComand(comand);
                SaveImges();
                if(DeletedImages.Count > 0)
                {
                    foreach(string name in DeletedImages)
                    {
                        globals.DeleteSqlComand("Image", "Path", name);                       
                    }
                }               
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }


        void SaveImges()
        {
            if (newImgs.Images.Count > 0)
            {
                foreach(string fullPath in newImgs.Images.Keys)
                {
                    string subPath, imageName;
                    string add = DateTime.Now.ToString("yyyyMMddHHmmss");                    
                    subPath = fullPath.Substring(fullPath.LastIndexOf(@"\") + 1);
                    imageName = subPath.Insert(subPath.LastIndexOf("."), add);
                    var tempImg = Image.FromFile(fullPath);
                    var img = new Bitmap(tempImg);
                    img.Save("../../ConsultationImages/" + imageName);
                    string command = "INSERT INTO Image (ConsultID,Path) VALUES (" + ConsultID + ",'" + imageName + "');";
                    globals.InsertUpdateSqlComand(command);                    
                }
                newImgs.Images.Clear();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            WinForms.PatientRecord(PatientID).Show();            
            this.Hide();
        }

        private void Consultation_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinForms.PatientRecord(PatientID).Show();         
            this.Hide();
            e.Cancel = true;
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {  
            string command = "select * from Bill where ConsultationID='"+ConsultID+"'";
            try
            {  
                DataTable dt = globals.FillDataGridView(command);
                if (dt.Rows.Count > 0)
                {
                    WinForms.Bill(ConsultID, PatientID).Show();                    
                    this.Hide();
                }
                else
                {
                    DialogResult choice = WinForms.AddBill(ConsultID,PatientID).ShowDialog();
                    if (choice == DialogResult.OK)
                    this.Hide();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }

        private void Consultation_Load(object sender, EventArgs e)
        {            
            string command = "select * from Bill where ConsultationID='" + ConsultID + "'";
            DataTable dt = globals.FillDataGridView(command);
            if (dt.Rows.Count > 0)
            {BtnBill.Text = "تفاصيل الفاتورة";}
            else
            {BtnBill.Text = "إصدار فاتورة";}
        }

       
        void ListviewPropreties()
        {
            listConsultImages.View = View.LargeIcon;
            listConsultImages.Columns.Add("Spacecraft", 150);
            listConsultImages.AutoResizeColumn(0,ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void LoadImagesToListview()
        {            
            imgs.ImageSize = new Size(150,150);                                
            try
            {                
                string comand ="select ImageID,Path from Image where ConsultID= "+ConsultID+"";
                DataTable paths = globals.FillDataGridView(comand);
                foreach (DataRow path in paths.Rows)
                {
                    imgs.Images.Add(path["Path"].ToString(), Image.FromFile("../../ConsultationImages/" + path["Path"].ToString()));                                        
                    ListViewItem item = new ListViewItem(path["Path"].ToString());
                    item.ImageIndex = ImageIndex;
                    listConsultImages.Items.Add(item);
                    ImageIndex++;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {               
                listConsultImages.LargeImageList = imgs;
            }
        }
    

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog newImage = new OpenFileDialog();            
            imgs.ImageSize = new Size(150, 150);
            try
            {
                newImage.Title = "إضافة صورة";
                newImage.Filter = "Images Files(*.png;*.jpeg;*.jpg;)|*.png;*.jpeg;*.jpg;";
                DialogResult choice= newImage.ShowDialog();
                if (choice == DialogResult.OK)
                {                  
                    Image image = new Bitmap(newImage.FileName);
                    var ImageName = newImage.FileName;                    
                    newImgs.Images.Add(ImageName, image);
                    imgs.Images.Add(ImageName, image);
                    ListViewItem item = new ListViewItem(ImageName);
                    item.ImageIndex = ImageIndex;
                    ImageIndex++;
                    
                    listConsultImages.LargeImageList = imgs;
                    listConsultImages.Items.Add(item);
                    BtnDeleteImage.Enabled = true;
                }                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                        
        }

        private void BtnDeleteImage_Click(object sender, EventArgs e)
        {
            if (listConsultImages.Items.Count > 0)
            {
                var selectedImage = listConsultImages.SelectedItems[0].Index;
                var selectedImageName = listConsultImages.SelectedItems[0].Text;
                DeletedImages.Add(selectedImageName);
                imgs.Images.RemoveAt(selectedImage);
                listConsultImages.SelectedItems[0].Remove();
            }
        }

        private void listConsultImages_DoubleClick(object sender, EventArgs e)
        {
            if(listConsultImages.Items.Count > 0)
            {
                var selectedImage = listConsultImages.SelectedItems[0].Index;
                string path = Environment.CurrentDirectory + "/../../ConsultationImages/" + listConsultImages.Items[selectedImage].Text;
                System.Diagnostics.Process.Start(path);
            }
        }

        private void richTxtChiefComplaint_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            richTxtChiefComplaint.Height = e.NewRectangle.Height + 10;            
        }

        private void richTxtHistory_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            richTxtHistory.Height = e.NewRectangle.Height + 10;            
        }

        private void richTxtPastDentalHistory_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            richTxtPastDentalHistory.Height = e.NewRectangle.Height + 10;            
        }

        private void richTxtDiagnosis_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            richTxtDiagnosis.Height = e.NewRectangle.Height + 10;            
        }

        private void richTxtTreatment_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            richTxtTreatment.Height = e.NewRectangle.Height + 10;
        }

        private void Consultation_SizeChanged(object sender, EventArgs e)
        {
            var width = this.Width;
            flowLayoutPanel1.Width = (int)(width * 0.8);
            richTxtTreatment.Width = (int)(width * 0.79);
            richTxtDiagnosis.Width = (int)(width * 0.79);
            richTxtHistory.Width = (int)(width * 0.79);
            richTxtChiefComplaint.Width = (int)(width * 0.79);
            richTxtPastDentalHistory.Width = (int)(width * 0.79);
            listConsultImages.Width = (int)(width * 0.79);
        }

       void clear()
        {
            richTxtDiagnosis.Text = "";
            richTxtChiefComplaint.Text = "";
            richTxtHistory.Text = "";
            richTxtTreatment.Text = "";
            richTxtPastDentalHistory.Text = "";
            txtDentistID.Text = "";
            PatientID = "";
            ConsultID = "";
            listConsultImages.Items.Clear();
            imgs.Images.Clear();
        } 
    }
}
