using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part1
{
    public partial class frm_report : Form
    {
        public string directory;
        public Storage carImages;
        private XColor backColor;
        private XPen borderPen;

        public frm_report(string directory, Form form)
        {
            this.directory = directory;
            InitializeComponent();
            carImages = new Storage(directory + "//Car_Checked//", "jpg");

            // ---------------------------------------------------------------------------
            // [Group 1] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 1)))
            {
                pReport_11.Load(carImages.getLocation(1, 1));
                checkBox1.Checked = true;
                checkBox1.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 1)))
            {
                pReport_21.Load(carImages.getLocation(2, 1));
                checkBox2.Checked = true;
                checkBox2.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 1)))
            {
                pReport_31.Load(carImages.getLocation(3, 1));
                checkBox3.Checked = true;
                checkBox3.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 1)))
            {
                pReport_41.Load(carImages.getLocation(4, 1));
                checkBox4.Checked = true;
                checkBox4.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 1)))
            {
                pReport_51.Load(carImages.getLocation(5, 1));
                checkBox5.Checked = true;
                checkBox5.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 1)))
            {
                pReport_61.Load(carImages.getLocation(6, 1));
                checkBox6.Checked = true;
                checkBox6.Enabled = true;
            }

            // ---------------------------------------------------------------------------
            // [Group 2] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 2)))
            {
                pReport_12.Load(carImages.getLocation(1, 2));
                checkBox7.Checked = true;
                checkBox7.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 2)))
            {
                pReport_22.Load(carImages.getLocation(2, 2));
                checkBox8.Checked = true;
                checkBox8.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 2)))
            {
                pReport_32.Load(carImages.getLocation(3, 2));
                checkBox9.Checked = true;
                checkBox9.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 2)))
            {
                pReport_42.Load(carImages.getLocation(4, 2));
                checkBox10.Checked = true;
                checkBox10.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 2)))
            {
                pReport_52.Load(carImages.getLocation(5, 2));
                checkBox11.Checked = true;
                checkBox11.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 2)))
            {
                pReport_62.Load(carImages.getLocation(6, 2));
                checkBox12.Checked = true;
                checkBox12.Enabled = true;
            }


            // ---------------------------------------------------------------------------
            // [Group 3] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 3)))
            {
                pReport_13.Load(carImages.getLocation(1, 3));
                checkBox13.Checked = true;
                checkBox13.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 3)))
            {
                pReport_23.Load(carImages.getLocation(2, 3));
                checkBox14.Checked = true;
                checkBox14.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 3)))
            {
                pReport_33.Load(carImages.getLocation(3, 3));
                checkBox15.Checked = true;
                checkBox15.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 3)))
            {
                pReport_43.Load(carImages.getLocation(4, 3));
                checkBox16.Checked = true;
                checkBox16.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 3)))
            {
                pReport_53.Load(carImages.getLocation(5, 3));
                checkBox17.Checked = true;
                checkBox17.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 3)))
            {
                pReport_63.Load(carImages.getLocation(6, 3));
                checkBox18.Checked = true;
                checkBox18.Enabled = true;
            }


            // ---------------------------------------------------------------------------
            // [Group 4] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 4)))
            {
                pReport_14.Load(carImages.getLocation(1, 4));
                checkBox19.Checked = true;
                checkBox19.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 4)))
            {
                pReport_24.Load(carImages.getLocation(2, 4));
                checkBox20.Checked = true;
                checkBox20.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 4)))
            {
                pReport_34.Load(carImages.getLocation(3, 4));
                checkBox21.Checked = true;
                checkBox21.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 4)))
            {
                pReport_44.Load(carImages.getLocation(4, 4));
                checkBox22.Checked = true;
                checkBox22.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 4)))
            {
                pReport_54.Load(carImages.getLocation(5, 4));
                checkBox23.Checked = true;
                checkBox23.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 4)))
            {
                pReport_64.Load(carImages.getLocation(6, 4));
                checkBox24.Checked = true;
                checkBox24.Enabled = true;
            }



            // ---------------------------------------------------------------------------
            // [Group 5] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 5)))
            {
                pReport_15.Load(carImages.getLocation(1, 5));
                checkBox25.Checked = true;
                checkBox25.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 5)))
            {
                pReport_25.Load(carImages.getLocation(2, 5));
                checkBox26.Checked = true;
                checkBox26.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 5)))
            {
                pReport_35.Load(carImages.getLocation(3, 5));
                checkBox27.Checked = true;
                checkBox27.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 5)))
            {
                pReport_45.Load(carImages.getLocation(4, 5));
                checkBox28.Checked = true;
                checkBox28.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 5)))
            {
                pReport_55.Load(carImages.getLocation(5, 5));
                checkBox29.Checked = true;
                checkBox29.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 5)))
            {
                pReport_65.Load(carImages.getLocation(6, 5));
                checkBox30.Checked = true;
                checkBox30.Enabled = true;
            }


            // ---------------------------------------------------------------------------
            // [Group 6] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 6)))
            {
                pReport_16.Load(carImages.getLocation(1, 6));
                checkBox31.Checked = true;
                checkBox31.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 6)))
            {
                pReport_26.Load(carImages.getLocation(2, 6));
                checkBox32.Checked = true;
                checkBox32.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 6)))
            {
                pReport_36.Load(carImages.getLocation(3, 6));
                checkBox33.Checked = true;
                checkBox33.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 6)))
            {
                pReport_46.Load(carImages.getLocation(4, 6));
                checkBox34.Checked = true;
                checkBox34.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 6)))
            {
                pReport_56.Load(carImages.getLocation(5, 6));
                checkBox35.Checked = true;
                checkBox35.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 6)))
            {
                pReport_66.Load(carImages.getLocation(6, 6));
                checkBox36.Checked = true;
                checkBox36.Enabled = true;
            }


            // ---------------------------------------------------------------------------
            // [Group 7] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 7)))
            {
                pReport_17.Load(carImages.getLocation(1, 7));
                checkBox37.Checked = true;
                checkBox37.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 7)))
            {
                pReport_27.Load(carImages.getLocation(2, 7));
                checkBox38.Checked = true;
                checkBox38.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 7)))
            {
                pReport_37.Load(carImages.getLocation(3, 7));
                checkBox39.Checked = true;
                checkBox39.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 7)))
            {
                pReport_47.Load(carImages.getLocation(4, 7));
                checkBox40.Checked = true;
                checkBox40.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 7)))
            {
                pReport_57.Load(carImages.getLocation(5, 7));
                checkBox41.Checked = true;
                checkBox41.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 7)))
            {
                pReport_67.Load(carImages.getLocation(6, 7));
                checkBox42.Checked = true;
                checkBox42.Enabled = true;
            }



            // ---------------------------------------------------------------------------
            // [Group 8] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 8)))
            {
                pReport_18.Load(carImages.getLocation(1, 8));
                checkBox43.Checked = true;
                checkBox43.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 8)))
            {
                pReport_28.Load(carImages.getLocation(2, 8));
                checkBox44.Checked = true;
                checkBox44.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 8)))
            {
                pReport_38.Load(carImages.getLocation(3, 8));
                checkBox45.Checked = true;
                checkBox45.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 8)))
            {
                pReport_48.Load(carImages.getLocation(4, 8));
                checkBox46.Checked = true;
                checkBox46.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 8)))
            {
                pReport_58.Load(carImages.getLocation(5, 8));
                checkBox47.Checked = true;
                checkBox47.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 8)))
            {
                pReport_68.Load(carImages.getLocation(6, 8));
                checkBox48.Checked = true;
                checkBox48.Enabled = true;
            }

            // ---------------------------------------------------------------------------
            // [Group 9] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 9)))
            {
                pReport_19.Load(carImages.getLocation(1, 9));
                checkBox49.Checked = true;
                checkBox49.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(2, 9)))
            {
                pReport_29.Load(carImages.getLocation(2, 9));
                checkBox50.Checked = true;
                checkBox50.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(3, 9)))
            {
                pReport_39.Load(carImages.getLocation(3, 9));
                checkBox51.Checked = true;
                checkBox51.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(4, 9)))
            {
                pReport_49.Load(carImages.getLocation(4, 9));
                checkBox52.Checked = true;
                checkBox52.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(5, 9)))
            {
                pReport_59.Load(carImages.getLocation(5, 9));
                checkBox53.Checked = true;
                checkBox53.Enabled = true;
            }

            if (Storage.isExist(carImages.getLocation(6, 9)))
            {
                pReport_69.Load(carImages.getLocation(6, 9));
                checkBox54.Checked = true;
                checkBox54.Enabled = true;
            }

            form.Hide();

            this.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmp = (PictureBox)sender;
            if (tmp.Image != null)
            {
                frm_pic_max11 frm_pic_max11 = new frm_pic_max11(tmp);
                frm_pic_max11.Show();
            }
        }

        private void btn_nxt_rep_prnt_Click(object sender, EventArgs e)
        {

            string filename = String.Format("{0}_report.pdf", Guid.NewGuid().ToString("D").ToUpper());
            PdfDocument document = new PdfDocument();

            DrawImages(document);

            
            // Save the s_document...
            document.Save(filename);
            // ...and start a viewer
            Process.Start(filename);

        }

        void DrawImages(PdfDocument document)
        {
            PdfPage page;
            // ---------------------------------------------------------------------------
            // [Group 1] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 1)))
            {
                if (checkBox1.Enabled)
                { 
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 1), 50, 50, 500,500);
                }

            }

            if (Storage.isExist(carImages.getLocation(2, 1)))
            {
                if (checkBox2.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 1), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 1)))
            {
                if (checkBox3.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 1), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 1)))
            {
                if (checkBox4.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 1), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 1)))
            {
                if (checkBox5.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 1), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 1)))
            {
                if (checkBox6.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 1), 50, 50, 500,500);
                }
            }

            // ---------------------------------------------------------------------------
            // [Group 2] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 2)))
            {
                if (checkBox7.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 2), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 2)))
            {
                if (checkBox8.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 2), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 2)))
            {
                if (checkBox9.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 2), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 2)))
            {
                if (checkBox10.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 2), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 2)))
            {
                if (checkBox11.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 2), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 2)))
            {
                if (checkBox12.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 2), 50, 50, 500,500);
                }
            }


            // ---------------------------------------------------------------------------
            // [Group 3] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 3)))
            {
                if (checkBox13.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 3), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 3)))
            {
                if (checkBox14.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 3), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 3)))
            {
                if (checkBox15.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 3), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 3)))
            {
                if (checkBox16.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 3), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 3)))
            {
                if (checkBox17.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 3), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 3)))
            {
                if (checkBox18.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 3), 50, 50, 500,500);
                }
            }


            // ---------------------------------------------------------------------------
            // [Group 4] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 4)))
            {
                if (checkBox19.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 4), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 4)))
            {
                if (checkBox20.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 4), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 4)))
            {
                if (checkBox21.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 4), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 4)))
            {
                if (checkBox22.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 4), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 4)))
            {
                if (checkBox23.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 4), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 4)))
            {
                if (checkBox24.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 4), 50, 50, 500,500);
                }
            }



            // ---------------------------------------------------------------------------
            // [Group 5] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 5)))
            {
                if (checkBox25.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 5), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 5)))
            {
                if (checkBox26.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 5), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 5)))
            {
                if (checkBox27.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 5), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 5)))
            {
                if (checkBox28.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 5), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 5)))
            {
                if (checkBox29.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 5), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 5)))
            {
                if (checkBox30.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 5), 50, 50, 500,500);
                }
            }


            // ---------------------------------------------------------------------------
            // [Group 6] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 6)))
            {
                if (checkBox31.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 6), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 6)))
            {
                if (checkBox32.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 6), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 6)))
            {
                if (checkBox33.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 6), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 6)))
            {
                if (checkBox34.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 6), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 6)))
            {
                if (checkBox35.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 6), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 6)))
            {
                if (checkBox36.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 6), 50, 50, 500,500);
                }
            }


            // ---------------------------------------------------------------------------
            // [Group 7] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 7)))
            {
                if (checkBox37.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 7), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 7)))
            {
                if (checkBox38.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 7), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 7)))
            {
                if (checkBox39.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 7), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 7)))
            {
                if (checkBox40.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 7), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 7)))
            {
                if (checkBox41.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 7), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 7)))
            {
                if (checkBox42.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 7), 50, 50, 500,500);
                }
            }



            // ---------------------------------------------------------------------------
            // [Group 8] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 8)))
            {
                if (checkBox43.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 8), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 8)))
            {
                if (checkBox44.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 8), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 8)))
            {
                if (checkBox45.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 8), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 8)))
            {
                if (checkBox46.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 8), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 8)))
            {
                if (checkBox47.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 8), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 8)))
            {
                if (checkBox48.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 8), 50, 50, 500,500);
                }
            }

            // ---------------------------------------------------------------------------
            // [Group 9] Checked 1_1
            if (Storage.isExist(carImages.getLocation(1, 9)))
            {
                if (checkBox49.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(1, 9), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(2, 9)))
            {
                if (checkBox50.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(2, 9), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(3, 9)))
            {
                if (checkBox51.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(3, 9), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(4, 9)))
            {
                if (checkBox52.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(4, 9), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(5, 9)))
            {
                if (checkBox53.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(5, 9), 50, 50, 500,500);
                }
            }

            if (Storage.isExist(carImages.getLocation(6, 9)))
            {
                if (checkBox54.Enabled)
                {
                    // Create an empty page or load existing
                    page = document.AddPage();
                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, carImages.getLocation(6, 9), 50, 50, 500,500);
                }
            }
        }

        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        private void frm_report_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frm_report_Load(object sender, EventArgs e)
        {

        }
    }
}
