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
    public partial class frm_page2_plt : Form
    {
        private frm_page2 mainForm = null;
        public frm_page2_plt(frm_page2 callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as frm_page2;
            tb_license_up.Text = this.mainForm.tb_license.Text;
        }

        private void btn_license_up_Click(object sender, EventArgs e)
        {
            this.mainForm.tb_license.Text = tb_license_up.Text;
            this.Close();
        }

        private void tb_license_up_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
