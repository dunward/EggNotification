using System.Media;
using System.Windows;

namespace CustomNotification
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NotificationWindow notificationWindow = new NotificationWindow();

            notificationWindow.Width = SystemParameters.PrimaryScreenWidth / 4;
            notificationWindow.Height = SystemParameters.PrimaryScreenHeight / 8;

            notificationWindow.Left = SystemParameters.PrimaryScreenWidth - (SystemParameters.PrimaryScreenWidth / 4) - 20;
            notificationWindow.Top = SystemParameters.PrimaryScreenHeight - (SystemParameters.PrimaryScreenHeight / 8) - 20;

            SystemSounds.Asterisk.Play();

            notificationWindow.Show();
        }
    }
}
