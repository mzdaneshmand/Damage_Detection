using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part1
{
    public partial class frm_page1 : Form
    {

        public string location = "C:\\cars\\";
        public frm_page1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            frm_page2 frm_page2 = new frm_page2(location + comboBox1.SelectedItem.ToString());
            //frm_page2.Show();
            this.Hide();
        }

        private void frm_page1_Load(object sender, EventArgs e)
        {
            int counter = 0;
            var directories = CustomSearcher.GetDirectories(location);

            foreach (string backdirectory in directories)
            {
                if (!backdirectory.Substring(8).Contains("matlab"))
                {
                    comboBox1.Items.Add(backdirectory.Substring(8));
                    counter++;
                }
            }
            if(counter > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            //comboBox1.DataSource = directories;
        }
    }
}
