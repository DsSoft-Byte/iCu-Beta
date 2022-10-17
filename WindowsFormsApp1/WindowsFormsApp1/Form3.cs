using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Xml;
using System.Web;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("https://github.com/DsSoft-Byte/iCu/blob/main/version.txt");
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            var sr = new System.IO.StreamReader(response.GetResponseStream());

            string newestversions = sr.ReadToEnd();
            string currentversion = Application.ProductVersion;
            //MessageBox.Show(newestversions);

            if (newestversions.Contains(currentversion))
            {
                MessageBox.Show("You are up to date!");
            }
            else
            {
                using (var client = new WebClient())
                    if (File.Exists(@"C:\iCuPlus.zip"))
                        MessageBox.Show("Update file detected ERROR 2");
                    else

                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://raw.githubusercontent.com/DsSoft-Byte/iCu/main/iCures_Updater.zip", @"C:\iCuPlus.zip");
                        string zipPath = @"C:\iCuPlus.zip";
                        string extractPath = @"C:\UpdateData";
                        System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);

                        Form2 form2 = new Form2();

                        form2.Show();
                    }
            }
        }
    }
}

