using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace part1
{
    public partial class frm_stat_car : Form
    {
        private int status;
        private Form form1;
        private string directory;

        public frm_stat_car(string directory, int status, Form form)
        {
            InitializeComponent();
            this.status = status;
            this.directory = directory;
            if(status == 1) {
                lbl_stat_in.Text = "The Car is returned from rent";
                btn_report.Text = "Generate Report";
                this.form1 = form;
                lbl_damage.Show();
                txtbox_damage.Show();
            } else
            {
                lbl_damage.Hide();
                txtbox_damage.Hide();
                lbl_stat_in.Text = "The Car is still in the rent";
                btn_report.Text = "Return";
            }
            
        }

        private void btn_ok_stat_Click(object sender, EventArgs e)
        {
            if(status == 1) {
                //btn_report.Visible = false;
                //pictureBox1.Visible = true;
                // Create the MATLAB instance 
                if(!Directory.Exists(directory + "//Car_Checked"))
                {
                    try
                    {
                        MLApp.MLApp matlab = new MLApp.MLApp();

                        // Change to the directory where the function is located 
                        matlab.Execute(@"cd C:\cars\matlab\");

                        // Define the output 
                        object result = null;
                        System.IO.Directory.CreateDirectory(directory + "//Car_Checked");
                        matlab.Feval("iRental", 0, out result, directory, txtbox_damage.Text);
                    }
                    catch (System.Runtime.InteropServices.COMException ex)
                    {
                        //this happens if no Matlab instances were running
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }

                }



                frm_report frm_report = new frm_report(directory,this);
                this.form1.Hide();
                //frm_report.Show();
            } else
            {
                this.Close();
            }
        }

        private void frm_stat_car_Load(object sender, EventArgs e)
        {

        }
    }
}
