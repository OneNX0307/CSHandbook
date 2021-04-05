using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BackgroundWorkerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker worker = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();

            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            this.btnStart.Click += btnStart_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.btnReset.Click += btnReset_Click;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                this.btnStart.IsEnabled = true;
                this.btnCancel.IsEnabled = false;
                this.btnReset.IsEnabled = false;
            });

            this.pb.Value = 0;
            this.tb.Text = 0.ToString();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                this.btnReset.IsEnabled = true;
            });
            this.btnCancel.IsEnabled = false;
        }

        private void worker_Cancel()
        {
            worker.CancelAsync();
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Dispatcher.Invoke(() => 
            {
                this.pb.Value = e.ProgressPercentage;
                this.tb.Text = e.ProgressPercentage.ToString();
            });
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Dispatcher.Invoke(() => 
            {
                this.btnStart.IsEnabled = false;
                this.btnCancel.IsEnabled = true;
            });
            for (int i = 0; i <= 100; i++)
            {
                if (((BackgroundWorker)sender).CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                worker.ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                this.btnReset.IsEnabled = false;
            });
            worker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke(() => 
            {
                this.btnStart.IsEnabled = false;
                this.btnCancel.IsEnabled = false;
                this.btnReset.IsEnabled = false;
            });
            worker.CancelAsync();
        }
    }
}
