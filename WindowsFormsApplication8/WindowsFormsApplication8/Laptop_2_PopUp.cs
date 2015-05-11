using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;

namespace WindowsFormsApplication8
{
    public partial class Laptop_2_PopUp : Form
    {
        // Pass checkbox values from Form 1 to Form 2
        private string Nm;
        public string PassValue
        {
            get { return Nm; }
            set { Nm = value; }
        }

        public Laptop_2_PopUp()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           


        }

        
        
        private void Laptop_2_PopUp_Load(object sender, EventArgs e)
        {
            // Get Current Technician Information
            UserPrincipal user = UserPrincipal.Current;
            string FirstName = user.GivenName;
            string LastName = user.Surname;
            string Email = user.EmailAddress;
            string TelephoneNumber = user.VoiceTelephoneNumber;

            // Set Current Technician Information

            textBox4.Text = Email;
            textBox5.Text = FirstName;
            textBox6.Text = LastName;
            textBox7.Text = TelephoneNumber;

            textBox9.Text = Nm;
        
            
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
               
                // Create the Outlook Application
                Outlook.Application oApp = new Outlook.Application();
                // Create NameSpace
                Outlook.NameSpace oNS = (Outlook.NameSpace)oApp.GetNamespace("MAPI");
                oNS.Logon(null, null, false, false);
                // Get DDS Service Desk Calendar
                Outlook.MAPIFolder oFolder;
                Outlook.Recipient oRecipient;
                string calendarName = "jacky.lam@dds.ca.gov";
                
                
                // Create a new appointment item
                Outlook.AppointmentItem oMsg = (Outlook.AppointmentItem)oApp.CreateItem(Outlook.OlItemType.olAppointmentItem);
                // Set Recipients
                oRecipient = oNS.CreateRecipient(calendarName);
                oRecipient.Resolve();
                oFolder = oNS.GetSharedDefaultFolder(oRecipient, Outlook.OlDefaultFolders.olFolderCalendar);
                // Set Appointment Start Time and End Time
                oMsg = oFolder.Items.Add("IPM.Appointment") as Outlook.AppointmentItem;
                oMsg.Start = DateTime.Parse(dateTimePicker1.Text + " " + comboBox1.Text);
                oMsg.End = DateTime.Parse(dateTimePicker2.Text + " " + comboBox2.Text);            
                //Set the Body
                string message = "The Below Is Information Regarding The IT Equipment Reservation" + Environment.NewLine;
                oMsg.Body = "The Below Is Information Regarding The IT Equipment Reservation" + Environment.NewLine + Environment.NewLine +
                    "Requester Information:" + Environment.NewLine +
                    "Email:" + " " + textBox1.Text + Environment.NewLine +
                    "First Name:" + " " + textBox2.Text + Environment.NewLine +
                    "Last Name:" + " " + textBox3.Text + Environment.NewLine + Environment.NewLine +
                    "Reservation Information:" + Environment.NewLine +
                    "Pick-Up Time:" + " " + comboBox1.Text + " " + "to" + " " + comboBox2.Text + Environment.NewLine +
                    "Pick-Up Date:" + " " + dateTimePicker1.Text + " " + "to" + " " + dateTimePicker2.Text + Environment.NewLine +
                    "Service Request Number:" + " " + textBox8.Text + Environment.NewLine + Environment.NewLine +
                    "Service Request Link:" + " " + "http://oasis.dds.ca.gov/applications/ISDRequests_Staff/index.cfm?pageAction=ShowDetail&RequestNum=" + textBox8.Text + Environment.NewLine +
                    "Reserved By Technician:" + Environment.NewLine +
                    "Email:" + " " + textBox4.Text + Environment.NewLine +
                    "First Name:" + " " + textBox5.Text + Environment.NewLine +
                    "Last Name:" + " " + textBox6.Text + Environment.NewLine +
                    "Telephone Number:" + " " + textBox7.Text + Environment.NewLine + Environment.NewLine +
                    "Comments" + Environment.NewLine +
                    richTextBox1.Text;
                //Set the Subject
                oMsg.Subject = "SR #" + " " + textBox8.Text + " " + textBox2.Text + " " + textBox3.Text + "-" + " Pick Up" + " " + textBox9.Text;
                //Set the location
                oMsg.Location = "DDS Service Desk -- HQ";
                //save the appointment
                oMsg.Save();
                //Show Confirmation Message
                MessageBox.Show("Successful");
            }
            catch (System.Exception ex)
            {
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // change format of dateTimePicker to be compatible with Outlook
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // change format of dateTimePicker to be compatible with Outlook
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
