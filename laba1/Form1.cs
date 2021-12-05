using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
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

        private void button1_ok_Click(object sender, EventArgs e)
        {
            if (textBox1_login.Text == "Serhii" && textBox2_password.Text == "2810")
            {
                label3.BackColor = Color.Green;
                MessageBox.Show("Login successful");
            }
            else
            {
                label3.BackColor = Color.Red;
                MessageBox.Show("Error: wrong username or password");
            }
        }
    }
}
