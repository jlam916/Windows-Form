using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class ISD_Equipment_Management : Form
    {
        public ISD_Equipment_Management()
        {
            InitializeComponent();
            timer1.Start();
        }

        private Laptop_2_PopUp SecondForm = new Laptop_2_PopUp();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ISD_Equipment_Management_Load(object sender, EventArgs e)
        {

        }

        private void btn_Laptop2_Click(object sender, EventArgs e)
        {
            
            SecondForm.ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Pull CheckBox Values if checked to Invisible Textbox
            // Laptop Checkbox
            if (checkBox1.Checked)
            {
                textBox1.Text = checkBox1.Text;
            }
            else
                textBox1.Text = null;
            if (checkBox2.Checked)
            {
                textBox2.Text = checkBox2.Text;
            }
            else
                textBox2.Text = null;

            if (checkBox3.Checked)
            {
                textBox3.Text = checkBox3.Text;
            }
            else
                textBox3.Text = null;

            if (checkBox4.Checked)
            {
                textBox4.Text = checkBox4.Text;
            }
            else
                textBox4.Text = null;
            if (checkBox5.Checked)
            {
                textBox5.Text = checkBox5.Text;
            }
            else
                textBox5.Text = null;
            if (checkBox6.Checked)
            {
                textBox6.Text = checkBox6.Text;
            }
            else
                textBox6.Text = null;
            if (checkBox7.Checked)
            {
                textBox7.Text = checkBox7.Text;
            }
            else
                textBox7.Text = null;
            // Long-Term Laptops Checkbox
            if (checkBox8.Checked)
            {
                textBox8.Text = checkBox8.Text;
            }
            else
                textBox8.Text = null;
            if (checkBox9.Checked)
            {
                textBox9.Text = checkBox9.Text;
            }
            else
                textBox9.Text = null;
            if (checkBox10.Checked)
            {
                textBox10.Text = checkBox10.Text;
            }
            else
                textBox10.Text = null;
            // Projectors Checkbox
            if (checkBox11.Checked)
            {
                textBox11.Text = checkBox11.Text;
            }
            else
                textBox11.Text = null;
            if (checkBox12.Checked)
            {
                textBox12.Text = checkBox12.Text;
            }
            else
                textBox12.Text = null;
            if (checkBox13.Checked)
            {
                textBox13.Text = checkBox13.Text;
            }
            else
                textBox13.Text = null;
            if (checkBox14.Checked)
            {
                textBox14.Text = checkBox14.Text;
            }
            else
                textBox14.Text = null;
            // USB Flash Drives CheckBox
            if (checkBox15.Checked)
            {
                textBox15.Text = checkBox15.Text;
            }
            else
                textBox15.Text = null;
            if (checkBox16.Checked)
            {
                textBox16.Text = checkBox16.Text;
            }
            else
                textBox16.Text = null;
            if (checkBox17.Checked)
            {
                textBox17.Text = checkBox17.Text;
            }
            else
                textBox17.Text = null;
            if (checkBox18.Checked)
            {
                textBox18.Text = checkBox18.Text;
            }
            else
                textBox18.Text = null;
            if (checkBox19.Checked)
            {
                textBox19.Text = checkBox19.Text;
            }
            else
                textBox19.Text = null;
            if (checkBox20.Checked)
            {
                textBox20.Text = checkBox20.Text;
            }
            else
                textBox20.Text = null;
            if (checkBox21.Checked)
            {
                textBox21.Text = checkBox21.Text;
            }
            else
                textBox21.Text = null;
            // Peripherals
            if (checkBox22.Checked)
            {
                textBox22.Text = checkBox22.Text;
            }
            else
                textBox22.Text = null;
            if (checkBox23.Checked)
            {
                textBox23.Text = checkBox23.Text;
            }
            else
                textBox23.Text = null;
            if (checkBox24.Checked)
            {
                textBox24.Text = checkBox24.Text;
            }
            else
                textBox24.Text = null;
            if (checkBox25.Checked)
            {
                textBox25.Text = checkBox25.Text;
            }
            else
                textBox25.Text = null;
            // Headphones
            if (checkBox26.Checked)
            {
                textBox26.Text = checkBox26.Text;
            }
            else
                textBox26.Text = null;
           
            // pass the checkbox & textbox values to Laptop_2_PopUp form
            SecondForm.PassValue = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text +
                " " + textBox7.Text + " " + textBox8.Text + " " + textBox9.Text + " " + textBox10.Text + " " + textBox11.Text + " " + textBox12.Text + " " + textBox13.Text +
                " " + textBox14.Text + " " + textBox15.Text + " " + textBox16.Text + " " + textBox17.Text + " " + textBox18.Text + " " + textBox19.Text + " " + textBox20.Text +
                " " + textBox21.Text + " " + textBox22.Text + " " + textBox23.Text + " " + textBox24.Text + " " + textBox25.Text + " " + textBox26.Text;
            SecondForm.ShowDialog();
            
            
           

        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pull CheckBox Values if checked to Invisible Textbox
            // Laptop Checkbox
            if (checkBox1.Checked)
            {
                SecondForm.PassValue = checkBox1.Text;
            }
            else
                SecondForm.PassValue = null;
            if (checkBox2.Checked)
            {
                SecondForm.PassValue = checkBox2.Text;
            }
            else
                textBox2.Text = null;

            if (checkBox3.Checked)
            {
                SecondForm.PassValue = checkBox3.Text;
            }
            else
                SecondForm.PassValue = null;

            if (checkBox4.Checked)
            {
                SecondForm.PassValue = checkBox4.Text;
            }
            else
                SecondForm.PassValue = null;
            if (checkBox5.Checked)
            {
                SecondForm.PassValue = checkBox5.Text;
            }
            else
                SecondForm.PassValue = null;
            if (checkBox6.Checked)
            {
                SecondForm.PassValue = checkBox6.Text;
            }
            else
                textBox6.Text = null;
            if (checkBox7.Checked)
            {
                SecondForm.PassValue = checkBox7.Text;
            }
            else
                textBox7.Text = null;
            // Long-Term Laptops Checkbox
            if (checkBox8.Checked)
            {
                SecondForm.PassValue = checkBox8.Text;
            }
            else
                textBox8.Text = null;
            if (checkBox9.Checked)
            {
                SecondForm.PassValue = checkBox9.Text;
            }
            else
                textBox9.Text = null;
            if (checkBox10.Checked)
            {
                SecondForm.PassValue = checkBox10.Text;
            }
            else
                textBox10.Text = null;
            // Projectors Checkbox
            if (checkBox11.Checked)
            {
                SecondForm.PassValue = checkBox11.Text;
            }
            else
                textBox11.Text = null;
            if (checkBox12.Checked)
            {
                SecondForm.PassValue = checkBox12.Text;
            }
            else
                textBox12.Text = null;
            if (checkBox13.Checked)
            {
                SecondForm.PassValue = checkBox13.Text;
            }
            else
                textBox13.Text = null;
            if (checkBox14.Checked)
            {
                SecondForm.PassValue = checkBox14.Text;
            }
            else
                textBox14.Text = null;
            // USB Flash Drives CheckBox
            if (checkBox15.Checked)
            {
                SecondForm.PassValue = checkBox15.Text;
            }
            else
                textBox15.Text = null;
            if (checkBox16.Checked)
            {
                SecondForm.PassValue = checkBox16.Text;
            }
            else
                textBox16.Text = null;
            if (checkBox17.Checked)
            {
                SecondForm.PassValue = checkBox17.Text;
            }
            else
                textBox17.Text = null;
            if (checkBox18.Checked)
            {
                SecondForm.PassValue = checkBox18.Text;
            }
            else
                textBox18.Text = null;
            if (checkBox19.Checked)
            {
                SecondForm.PassValue = checkBox19.Text;
            }
            else
                textBox19.Text = null;
            if (checkBox20.Checked)
            {
                SecondForm.PassValue = checkBox20.Text;
            }
            else
                textBox20.Text = null;
            if (checkBox21.Checked)
            {
                SecondForm.PassValue = checkBox21.Text;
            }
            else
                textBox21.Text = null;
            // Peripherals
            if (checkBox22.Checked)
            {
                SecondForm.PassValue = checkBox22.Text;
            }
            else
                textBox22.Text = null;
            if (checkBox23.Checked)
            {
                SecondForm.PassValue = checkBox23.Text;
            }
            else
                textBox23.Text = null;
            if (checkBox24.Checked)
            {
                SecondForm.PassValue = checkBox24.Text;
            }
            else
                textBox24.Text = null;
            if (checkBox25.Checked)
            {
                textBox25.Text = checkBox25.Text;
            }
            else
                textBox25.Text = null;
            // Headphones
            if (checkBox26.Checked)
            {
                SecondForm.PassValue = checkBox26.Text;
            }
            else
                SecondForm.PassValue = null;

            SecondForm.ShowDialog();
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label8.Text = dateTime.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        

        
    }
}
