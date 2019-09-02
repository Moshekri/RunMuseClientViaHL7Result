using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_run_Window
{
    public enum TestTypes
    {
        ECG = 1,
        HiRes = 3,
        Stress,
        Holter

    }
    public partial class Form1 : Form
    {

        URLData data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOpenMuse.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblPatientID.Text = lblTestDate.Text = lblTestTime.Text = lblTestType.Text = "";
            try
            {
                data = UrlDataExtractor.GetData(txtSource.Text, CultureInfo.CreateSpecificCulture(ConfigurationManager.AppSettings["culture"]));
                if (data==null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            lblPatientID.Text = data.PID;
            lblTestType.Text = data.TestType;
            lblTestDate.Text = data.ParesedDateTime.ToLongDateString();
            lblTestTime.Text = data.ParesedDateTime.ToLongTimeString();

            btnOpenMuse.Enabled = lblPatientID.Text != "" && lblTestDate.Text != "" & lblTestTime.Text != "" && lblTestType.Text != "";


        }
   

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenMuse_Click(object sender, EventArgs e)
        {
                                                                          
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = ConfigurationManager.AppSettings["WorkingDirectory"];
            startInfo.FileName = Path.Combine(startInfo.WorkingDirectory, "museeditor.exe");

            startInfo.Arguments += $"/PID:{data.PID}";
            startInfo.Arguments += $" /Site:{data.Site}";
            startInfo.Arguments += $" /TestType:{(int)Enum.Parse(typeof(TestTypes), data.TestType, true)}";
            startInfo.Arguments += $" /TestDateTime:{data.TestDateTime}";
            startInfo.UseShellExecute = true;
           


            using (Process proc = new Process())
            {
               
                proc.StartInfo = startInfo;
                proc.Start();
            }

        }

        private void TxtSource_DragDrop(object sender, DragEventArgs e)
        {
            var s = "s";
            var data = e.Data.GetFormats(true);
            var n = e.Data.GetData("FileName",true) as string[];
           
            var text = File.ReadAllText(n[0]);
            txtSource.Text = text;

        }

        private void TxtSource_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
