using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Additional
using System.IO;
using System.Reflection;
using openalprnet;


namespace part1
{
    public partial class frm_page2 : Form
    {

        public Storage carImages;
        public string directory;

        public frm_page2(String directory)
        {
            InitializeComponent();
            this.directory = directory;
            carImages = new Storage(directory + "//Car_Rented//", "jpg");

            pb_cam_11.Load(carImages.getLocation(1, 1));
            pictureBox1.Load(carImages.getLocation(2, 1));
            pictureBox2.Load(carImages.getLocation(3, 1));
            pictureBox3.Load(carImages.getLocation(4, 1));
            pictureBox4.Load(carImages.getLocation(5, 1));
            pictureBox5.Load(carImages.getLocation(6, 1));


            pictureBox6.Load(carImages.getLocation(1, 2));
            pictureBox7.Load(carImages.getLocation(2, 2));
            pictureBox8.Load(carImages.getLocation(3, 2));
            pictureBox9.Load(carImages.getLocation(4, 2));
            pictureBox10.Load(carImages.getLocation(5, 2));
            pictureBox11.Load(carImages.getLocation(6, 2));

            pictureBox12.Load(carImages.getLocation(1, 3));
            pictureBox13.Load(carImages.getLocation(2, 3));
            pictureBox14.Load(carImages.getLocation(3, 3));
            pictureBox15.Load(carImages.getLocation(4, 3));
            pictureBox16.Load(carImages.getLocation(5, 3));
            pictureBox17.Load(carImages.getLocation(6, 3));

            pictureBox18.Load(carImages.getLocation(1, 4));
            pictureBox19.Load(carImages.getLocation(2, 4));
            pictureBox20.Load(carImages.getLocation(3, 4));
            pictureBox21.Load(carImages.getLocation(4, 4));
            pictureBox22.Load(carImages.getLocation(5, 4));
            pictureBox23.Load(carImages.getLocation(6, 4));


            pictureBox24.Load(carImages.getLocation(1, 5));
            pictureBox25.Load(carImages.getLocation(2, 5));
            pictureBox26.Load(carImages.getLocation(3, 5));
            pictureBox27.Load(carImages.getLocation(4, 5));
            pictureBox28.Load(carImages.getLocation(5, 5));
            pictureBox29.Load(carImages.getLocation(6, 5));

            pictureBox30.Load(carImages.getLocation(1, 6));
            pictureBox31.Load(carImages.getLocation(2, 6));
            pictureBox32.Load(carImages.getLocation(3, 6));
            pictureBox33.Load(carImages.getLocation(4, 6));
            pictureBox34.Load(carImages.getLocation(5, 6));
            pictureBox35.Load(carImages.getLocation(6, 6));

            pictureBox36.Load(carImages.getLocation(1, 7));
            pictureBox37.Load(carImages.getLocation(2, 7));
            pictureBox38.Load(carImages.getLocation(3, 7));
            pictureBox39.Load(carImages.getLocation(4, 7));
            pictureBox40.Load(carImages.getLocation(5, 7));
            pictureBox41.Load(carImages.getLocation(6, 7));

            pictureBox42.Load(carImages.getLocation(1, 8));
            pictureBox43.Load(carImages.getLocation(2, 8));
            pictureBox44.Load(carImages.getLocation(3, 8));
            pictureBox45.Load(carImages.getLocation(4, 8));
            pictureBox46.Load(carImages.getLocation(5, 8));
            pictureBox47.Load(carImages.getLocation(6, 8));

            pictureBox48.Load(carImages.getLocation(1, 9));
            pictureBox49.Load(carImages.getLocation(2, 9));
            pictureBox50.Load(carImages.getLocation(3, 9));
            pictureBox51.Load(carImages.getLocation(4, 9));
            pictureBox52.Load(carImages.getLocation(5, 9));
            pictureBox53.Load(carImages.getLocation(6, 9));

            this.Show();
        }

        private void btn_plt_nr_Click(object sender, EventArgs e)
        {
            frm_page2_plt frm_page2_plt = new frm_page2_plt(this);
            frm_page2_plt.Show();
            
        }

        private void dgv_image_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_page2_Load(object sender, EventArgs e)
        {
            processImageFile(carImages.carFront("jpg"));

        }

        private Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }



        private void lbl_cam_grp6_Click(object sender, EventArgs e)
        {

        }

        private void pb_cam_11_Click(object sender, EventArgs e)
        {
            frm_pic_max11 frm_pic_max11 = new frm_pic_max11((PictureBox) sender);
            frm_pic_max11.Show();
        }

        private void btn_status_car_Click(object sender, EventArgs e)
        {
            int status = 0;
            var directories = CustomSearcher.GetDirectories(directory);

            foreach (string backdirectory in directories)
            {
                if (backdirectory.Contains("Car_Back")) // Will match once.
                {
                    status = 1;
                }
            }

            frm_stat_car frm_stat_car = new frm_stat_car(directory,status, this);


            frm_stat_car.Show();
        }

        private void pb_license_Click(object sender, EventArgs e)
        {

        }

        private void tb_license_TextChanged(object sender, EventArgs e)
        {

        }

        // ---------------------------------------------------------------------------------------------------
        // ------------------------------ Additional Codes ---------------------------------------------------
        // ---------------------------------------------------------------------------------------------------

        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }


        public Rectangle boundingRectangle(List<Point> points)
        {
            // Add checks here, if necessary, to make sure that points is not null,
            // and that it contains at least one (or perhaps two?) elements

            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);

            return new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }


        public static Bitmap combineImages(List<Image> images)
        {
            //read all images into memory
            Bitmap finalImage = null;

            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }

                //create a bitmap to hold the combined image
                finalImage = new Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (var g = Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(Color.Black);

                    //go through each image and draw it on the final image
                    var offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //clean up memory
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }


        private void processImageFile(string fileName)
        {
            
            var region = "eu";
            String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
            String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");
            using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
            {
                if (!alpr.IsLoaded())
                {
                    //lbxPlates.Items.Add("Error initializing OpenALPR");
                    return;
                }
                //picOriginal.ImageLocation = fileName;
                //picOriginal.Load();

                var results = alpr.Recognize(fileName);

                var images = new List<Image>(results.Plates.Count());
                var i = 1;
                foreach (var result in results.Plates)
                {
                    var rect = boundingRectangle(result.PlatePoints);
                    var img = Image.FromFile(fileName);
                    var cropped = cropImage(img, rect);
                    images.Add(cropped);

                    //lbxPlates.Items.Add("\t\t-- Plate #" + i++ + " --");
                    foreach (var plate in result.TopNPlates)
                    {
                        /*lbxPlates.Items.Add(string.Format(@"{0} {1}% {2}",
                                                          plate.Characters.PadRight(12),
                                                          plate.OverallConfidence.ToString("N1").PadLeft(8),
                                                          plate.MatchesTemplate.ToString().PadLeft(8)));*/
                        tb_license.Text = plate.Characters.PadRight(12);
                        break;
                    }
                }

                if (images.Any())
                {
                    pb_license.Image = combineImages(images);
                }
            }
        }

        private void frm_page2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
