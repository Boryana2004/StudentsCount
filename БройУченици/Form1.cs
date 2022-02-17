using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БройУченици
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
            int count = 0; 
            int g8a = int.Parse(girls8a_textBox.Text); 
            int g8b = int.Parse(girls8b_textBox.Text); 
            int b8a = int.Parse(boys8a_textBox.Text); 
            int b8b = int.Parse(boys8b_textBox.Text); 
            if (radioButton_Girls.Checked == true) 
            { 
                if (checkBox_8a.Checked == true && checkBox_8b.Checked == true) 
                {
                    count = g8a + g8b; 
                } 
                if (checkBox_8a.Checked == true && checkBox_8b.Checked == false) 
                {
                    count = g8a; 
                } 
                if (checkBox_8a.Checked == false && checkBox_8b.Checked == true) 
                {
                    count = g8b; 
                } 
            }

            if (radioButtonBoys.Checked == true)
            {
                if (checkBox_8a.Checked == true && checkBox_8b.Checked == true)
                {
                    count = b8a + b8b;
                }
                if (checkBox_8a.Checked == true && checkBox_8b.Checked == false)
                {
                    count = b8a;
                }
                if (checkBox_8a.Checked == false && checkBox_8b.Checked == true)
                {
                    count = b8b;
                }
            }
            if (radioButtonTotal.Checked == true)
            {
                count = g8a + g8b + b8a + b8b;
            }
            label_count.Text = "Брой: " + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            girls8a_textBox.Text = "";
            girls8b_textBox.Text = "";
            boys8a_textBox.Text = "";
            boys8b_textBox.Text = "";
            radioButton_Girls.Checked = false;
            radioButtonBoys.Checked = false;
            radioButtonTotal.Checked = false;
            checkBox_8a.Checked = false;
            checkBox_8b.Checked = false;

        }

        private void radioButtonBoys_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
