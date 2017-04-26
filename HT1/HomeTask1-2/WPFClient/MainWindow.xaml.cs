using System.Windows;

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BttnOk_OnClick(object sender, RoutedEventArgs e)
        {
            var client = new WPFDiskInfo.DiskInfoClient("NetTcpBinding_IDiskInfo");

            lstBxRezult.ItemsSource = client.GetDiskInfo(@txtBxPath.Text);

        }
    }
}
