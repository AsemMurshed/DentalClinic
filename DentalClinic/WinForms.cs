using System;
using System.Windows.Forms;

namespace DentalClinic
{
    class WinForms
    {
        private static Form main;
        public static Form Main
        {
            get
            {
                if (main == null)
                {
                    main = new frmMain();
                }
                return main;
            }
        }

      

        private static Form cli;
        public static Form CommandLineInterface
        {
            get
            {
                if (cli == null)
                {
                    cli = new frmCLI();
                }
                return cli;
            }
        }

        private static Form patient;
        public static Form Patient
        {
            get
            {
                if (patient == null)
                {
                    patient = new frmEmployee();
                }
                return patient;
            }
        }


        private static Form addEditPatient;
        public static Form AddEditPatient(string Id = null)
        {
            if (Id == null)
            {
                addEditPatient = new AddEditPatient();
            }
            else
            {
                addEditPatient = new AddEditPatient(Id);
            }
            return addEditPatient;
        }


        private static Form patientRecord;
        public static Form PatientRecord(string id)
        {           
            patientRecord = new PatientRecord(id);            
            return patientRecord;
        }


        private static Form addAppointment;
        public static Form AddAppointment(string id, string Pid = null)
        {
            if (Pid == null)
            {
                addAppointment = new AddAppointment(id);
            }
            else
            {
                addAppointment = new AddAppointment(id,Pid);
            }

            return addAppointment;
        }



        private static Form consultation;
        public static Form Consultation(string Id, string PatientId = null)
        {    
            if(PatientId == null)
            {
                consultation = new Consultation(Id);
            }
            else
            {
                consultation = new Consultation(Id,PatientId);
            }                                   
                return consultation;
        }


        private static Form bill;
        public static Form Bill (string Cid,string Pid)
        {                           
            bill = new bill(Cid,Pid);                
            return bill;
        }

        private static Form addBill;
        public static Form AddBill(string Cid, string BillID = null, 
            string TotalAmount = null, string Discount = null, string PaidFor = null, string PaymentStatus = null, string Pid = null)
        {
            if (TotalAmount == null)
            {
                addBill = new AddBill(Cid, Pid);
            }
            else
            {
                addBill = new AddBill(Cid, BillID, TotalAmount, Discount, PaidFor, PaymentStatus);
            }
            return addBill;
        }

        private static Form addPayment;
        public static Form AddPayment(string Bid, string Amount = null, string PaidBy = null)
        {
            if (Amount == null)
            {
                addPayment = new AddPayment(Bid);
            }
            else
            {
                addPayment = new AddPayment(Bid, Amount, PaidBy);
            }
            return addPayment;
        }

        private static Form appointment;
        public static Form Appointment()
        {                 
            appointment = new Appointment();                
            return appointment;                      
        }

        private static Form addStaff;
        public static Form AddStaff(string id = null)
        {            
            if (id == null)
            {
                addStaff = new AddStaff();
            }
            else
            {
                addStaff = new AddStaff(id);
            }
                return addStaff;            
        }

       
   
        private static Form staff;
        public static Form Staff
        {
            get
            {
                if (staff == null)
                {
                    staff = new Staff();
                }
                return staff;
            }
        }


        
       
    }
}
