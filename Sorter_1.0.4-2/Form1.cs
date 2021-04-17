using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter_1._0._4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            roundButton1.Text = "Русский";
            roundButton2.Text = "English";
            ControlBox = false;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

            Sorter form2 = new Sorter();
            {
                form2.textBox1.Text = "1";
            }
            form2.Show();
            this.Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

            Sorter form2 = new Sorter();
            {
                form2.textBox1.Text = "-1";
            }
            form2.Show();
            this.Hide();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
