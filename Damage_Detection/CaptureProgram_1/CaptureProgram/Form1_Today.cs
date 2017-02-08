using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Timers;

using openalprnet;
using System.Reflection;
using System.Net.Sockets;
using System.Threading;
using Ionic.Zip;
using System.Threading.Tasks;

namespace CaptureProgram
{
    public partial class Form1 : Form
    {
        SettingWindow m_SettingWindow;

        public string[] camera = new string[10];



        string region = "eu";
        String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
        String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");
        bool timerflag = false;

        public Form1()
        {
            InitializeComponent();
            m_SettingWindow = new SettingWindow(this);
            button2.Enabled = false;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            //aTimer.Enabled = true;
            timerflag = true;
            UpdateProcessText("Process has been started.");

            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            var progress = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                progressBar1.Value = v;
            });
            var buttons = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                button1.Enabled = true;
                button2.Enabled = false;
            });

            var processText = new Progress<string>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                labelProcess.Text = v;
            });


            // Run operation in another thread
            await Task.Run(() => DoWork(progress, buttons, processText));
        }

        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        public void DoWork(IProgress<int> progress, IProgress<int> button, IProgress<string> processText)
        {
            // This method is executed in the context of
            // another thread (different than the main UI thread),
            // so use only thread-safe code
            while (timerflag)
            {
                //UpdateProcessText("Shoot Request");
                //labelProcess.Text = "Shoot Request";
                var Client = new UdpClient();
                var RequestData = Encoding.ASCII.GetBytes("shoot");
                var ServerEp = new IPEndPoint(IPAddress.Any, 0);
                string platenumber;

                Client.EnableBroadcast = true;
                Client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Broadcast, 5000));
                Client.Close();

                Thread.Sleep(80);
                Response response1 = GetRequest(camera[0]);
                if (response1 == null)
                {
                    timerflag = false;
                    button.Report(1);
                    processText.Report("Process was failed.");
                    break;
                }
                Response response2 = GetRequest(camera[1]);
                if (response2 == null)
                {
                    timerflag = false;
                    button.Report(1);
                    processText.Report("Process was failed.");
                    break;
                }

                processText.Report("Camera 1 image is saved.");
                SaveTempFile("Camera1.jpg",response1);
                SaveTempFile("Camera2.jpg", response2);
                processText.Report("Camera 2 image is saved.");
                UpdateProcessText("License Plate Searching");
                platenumber = processImageFile("Camera1.jpg");
                if (platenumber != null)
                {
                    processText.Report("License Plate is found : " + platenumber);
                    progress.Report(30);
                    ProcessStart(response1, platenumber,progress);
                    progress.Report(100);
					Thread.Sleep(10000);
                }
                else
                {
                    platenumber = processImageFile("Camera2.jpg");
                    if (platenumber != null)
                    {
                        processText.Report("License Plate is found : " + platenumber);
                        progress.Report(30);
                        ProcessStart(response2, platenumber,progress);
                        progress.Report(100);
						Thread.Sleep(10000);
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //aTimer.Enabled = false;
            timerflag = false;
            UpdateProcessText("Process has been stopped.");
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void UpdateProcessText(string text)
        {
            labelProcess.Text = text;
        }

        private string processImageFile(string fileName)
        {
            string platenumber = null;
            var alpr = new AlprNet(region, config_file, runtime_data_dir);

            if (!alpr.IsLoaded())
            {
                return platenumber;
            }

            var results = alpr.Recognize(fileName);

            var images = new List<Image>(results.Plates.Count());
            foreach (var result in results.Plates)
            {
                foreach (var plate in result.TopNPlates)
                {
                    /*
                    if ((plate.Characters[0] >= '0' && plate.Characters[0] <= '9') &&
                        (plate.Characters[1] >= '0' && plate.Characters[1] <= '9') &&
                        (plate.Characters[2] >= '0' && plate.Characters[2] <= '9') &&
                        (plate.Characters[3] >= 'A' && plate.Characters[0] <= 'a' &&
                        plate.Characters[3] <= 'z' && plate.Characters[0] <= 'Z') &&
                        (plate.Characters[4] <= 'A' && plate.Characters[4] <= 'a' &&
                        plate.Characters[4] <= 'z' && plate.Characters[4] <= 'Z') &&
                        (plate.Characters[5] <= 'A' && plate.Characters[5] <= 'a' &&
                        plate.Characters[5] <= 'z' && plate.Characters[5] <= 'Z'))
                    {*/
                        platenumber = plate.Characters.ToString();
                        break;
                    //}
                }
            }
            return platenumber;
        }

        private void ProcessStart(Response response, string platenumber, IProgress<int> progress)
        {
            //labelProcess.Text = "The license plate numeber has been found : " + platenumber;

            string subPath = "C://cars//" + platenumber; // your code goes here

            bool exists = System.IO.Directory.Exists(subPath);

            if (exists)
            {
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddDirectory(subPath, platenumber);
                    string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    string documents = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string path = documents + "\\" + platenumber + timestamp + ".zip";
                    zip.Save(path);

                }

                System.IO.DirectoryInfo di = new DirectoryInfo(subPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }

            System.IO.Directory.CreateDirectory(subPath);

            string subCarPath = subPath;
            if (radioButton1.Checked)
            {
                subCarPath += "//Car_Rented";
            }
            else
            {
                subCarPath += "//Car_Back";
            }

            System.IO.Directory.CreateDirectory(subCarPath);

            SaveTempFile(subCarPath + "//car.jpg", response);

            //labelProcess.Text = "Saving the all files.";

            SaveFiles(subCarPath);

            //labelProcess.Text = "Saving Process is done.";

            timerflag = true;
            return;
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_SettingWindow.Show();
        }

        private Response GetRequest(String cameranumber)
        {
            Response JSONResponse = null;
            try
            {
                string url = cameranumber;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Timeout = 50000;
                httpWebRequest.ReadWriteTimeout = 50000;
                httpWebRequest.Method = WebRequestMethods.Http.Get;
                httpWebRequest.Accept = "text/json";
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    string text = sr.ReadToEnd();
                    JSONResponse = JsonConvert.DeserializeObject<Response>(text);
                }
                
            } catch(WebException e)
            {
                if (e.Status == WebExceptionStatus.Timeout)
                {
                    MessageBox.Show("Please check your network settings. Request cannot be sent.", "Camera Connection",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else throw;
            }

            return JSONResponse;
        }

        public void SaveTempFile(string filename, Response response)
        {
            byte[] bytes = System.Convert.FromBase64String(response.image);
            File.WriteAllBytes(filename, bytes);
        }

        public void SaveFiles(string subPath)
        {
            var Client = new UdpClient();
            var RequestData = Encoding.ASCII.GetBytes("shoot");
			var RequestVideo = Encoding.ASCII.GetBytes("captureVideo");
            var ServerEp = new IPEndPoint(IPAddress.Any, 0);

            Client.EnableBroadcast = true;

            for (int i = 1; i < 7; i++)
            {
                Client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Broadcast, 5000));
                Thread.Sleep(2000);

                SaveTempFile(subPath + "//" + i.ToString() + "_1.jpg", GetRequest(camera[0]));

                Thread.Sleep(500);
            }
			
			Client.Send(RequestVideo, RequestVideo.Length, new IPEndPoint(IPAddress.Broadcast, 5000));
            Thread.Sleep(2000);
            SaveTempFile(subPath + "//1.h264", GetRequest(camera[0]));
            Thread.Sleep(500);

            Client.Close();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            var filestream = new System.IO.FileStream("ipaddresses.txt",
                                                      System.IO.FileMode.Open,
                                                      System.IO.FileAccess.Read,
                                                      System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
            for(int i = 0; i < 10; i++)
            {
                camera[i] = file.ReadLine();
            }

            // plate detection

            
        }


    }
}
