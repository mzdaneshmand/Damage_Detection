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
    public partial class frm_pic_max11 : Form
    {
        public frm_pic_max11(PictureBox pictureBox)
        {
            InitializeComponent();
            pb_max_11.Image = pictureBox.Image;
        }

        private void pb_max_11_Click(object sender, EventArgs e)
        {

        }
    }
}
