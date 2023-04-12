using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3 || textBox1.Text.Length > 30)
            {
                button1.Text = "Неверное имя";
                return;
            }

            if (textBox2.Text.Length < 2 || textBox2.Text.Length > 35)
            {
                button1.Text = "Неверная фамилия";
                return;
            }

            try
            {
                int x = Int32.Parse(textBox3.Text);
                if (x < 0)
                    button1.Text = "jnhbxfntkmysq";
            }
            catch(Exception ex)
            {
                button1.Text = ex.Message;
            }
        }
    }
}
