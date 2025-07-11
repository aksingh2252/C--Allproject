using LoginAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u_name = textBox1.Text;
            string u_pswd = textBox2.Text;

            Authentication auth = new Authentication();
            bool b = auth.userlogin(u_name, u_pswd);
            if (b != false)
            {
                MessageBox.Show("Login Succesfully " + auth.getusername(u_name));
                clearTextbox();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
                clearTextbox();
            }

        }

        private void clearTextbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
