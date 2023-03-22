using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            //checkbox1=japan
            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";

            }
             //checkbox2=philippines
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " ";
            }
             //checkbox3=thailand
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";
            }
             //checkbox4=australia
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " ";
            }
            //checkbox5= others
            if (checkBox5.Checked == true)
            {
                str = str + checkBox5.Text;
                str += " ";
            }
            if (str != null)
            {
                MessageBox.Show("You Selected : \n" + str + "\nThank You!", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                label3.Visible = true;
                otherstext.Visible = true;
            }
            else
            {
                label3.Visible = false;
                otherstext.Visible = false;
            }

        
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
