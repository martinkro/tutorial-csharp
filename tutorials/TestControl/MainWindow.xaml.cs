using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.ComponentModel;
using System.Threading;
namespace TestControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pbStatus.Visibility = Visibility.Hidden;
        }

        private void ButtonClick(object sender, RoutedEventArgs args)
        {
            btnTest.IsEnabled = false;
            pbStatus.Visibility = Visibility.Visible;
            pbStatus.IsIndeterminate = true;
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += BackgroundWorker_DoWork;
            worker.ProgressChanged += BackgroundWorker_ProgressChanged;
            worker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            
            worker.RunWorkerAsync();
        }

        void BackgroundWorker_DoWork(object sender, DoWorkEventArgs args)
        {
            for(int i = 0; i< 1000; i++)
            {
                Thread.Sleep(10);
                (sender as BackgroundWorker).ReportProgress(i);
            }
        }

        void BackgroundWorker_ProgressChanged(object sender,ProgressChangedEventArgs args)
        {

        }

        void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbStatus.Visibility = Visibility.Hidden;
            btnTest.IsEnabled = true;
        }
    }
}
