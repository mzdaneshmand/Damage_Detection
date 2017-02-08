using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureProgram
{
    public partial class SettingWindow : Form
    {
        Form1 form1;
        public SettingWindow(Form form)
        {
            InitializeComponent();

            form1 = (Form1) form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.camera[0] = textBox1.Text;
            form1.camera[1] = textBox2.Text;
            form1.camera[2] = textBox3.Text;
            form1.camera[3] = textBox4.Text;
            form1.camera[4] = textBox5.Text;
            form1.camera[5] = textBox6.Text;
            form1.camera[6] = textBox7.Text;
            form1.camera[7] = textBox8.Text;
            form1.camera[8] = textBox9.Text;
            form1.camera[9] = textBox10.Text;

            System.IO.File.WriteAllLines("ipaddresses.txt", form1.camera);
            this.Hide();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            textBox1.Text = form1.camera[0];
            textBox2.Text = form1.camera[1];
            textBox3.Text = form1.camera[2];
            textBox4.Text = form1.camera[3];
            textBox5.Text = form1.camera[4];
            textBox6.Text = form1.camera[5];
            textBox7.Text = form1.camera[6];
            textBox8.Text = form1.camera[7];
            textBox9.Text = form1.camera[8];
            textBox10.Text = form1.camera[9];
        }
    }
}
