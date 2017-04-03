using System;
using System.IO;
using System.Windows;


namespace CleanXprez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string TempPath = @"C:\Windows\Temp";

        private string HidTempPath = Environment.GetFolderPath(
            Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Temp";

        private string PrefetchPath = @"C:\Windows\Prefetch";

        private string RecentPath = Environment.GetFolderPath(
            Environment.SpecialFolder.UserProfile) + @"\Recent";

        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show(GetSize(TempPath).ToString());
            MessageBox.Show(GetSize(HidTempPath).ToString());
            MessageBox.Show(GetSize(PrefetchPath).ToString());
            MessageBox.Show(GetSize(RecentPath).ToString());
        }

        double GetSize(string Path)
        {
            string[] Files = Directory.GetFiles((Path));
            long Size = 0;
            foreach (string VARIABLE in Files)
            {
                Size+=new FileInfo(VARIABLE).Length;
            }
            return Size/1048576.0;
        }
    }
}
