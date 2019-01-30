using CustomNotification;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace EggNotification
{
    public class Notification
    {
        #region Private Member

        NotificationWindow notificationWindow;
        #endregion

        #region Public Member
        public NotificationAnchor anchor = NotificationAnchor.RightBottom;
        #endregion

        public Notification()
        {
            notificationWindow = new NotificationWindow();

            notificationWindow.Width = SystemParameters.PrimaryScreenWidth / 4;
            notificationWindow.Height = SystemParameters.PrimaryScreenHeight / 8;

            notificationWindow.Left = SystemParameters.PrimaryScreenWidth - (SystemParameters.PrimaryScreenWidth / 4) - 20;
            notificationWindow.Top = SystemParameters.PrimaryScreenHeight - (SystemParameters.PrimaryScreenHeight / 8) - 20;

            SystemSounds.Asterisk.Play();
        }

        public void SetBackgroundColor(System.Windows.Media.Color color)
        {
            System.Windows.Media.Brush brush = new SolidColorBrush(color);
            notificationWindow.background.Background = brush;
        }

        public void SetMessage(string message)
        {
            notificationWindow.Message.Text = message;
        }

        public void SetRadius(int radius)
        {
            CornerRadius cornerRadius = new CornerRadius(radius);
            notificationWindow.background.CornerRadius = cornerRadius;
        }

        public void SetFontFamily(System.Windows.Media.FontFamily font)
        {
            notificationWindow.Message.FontFamily = font;
        }

        public void SetFontSize(int size)
        {
            notificationWindow.Message.FontSize = size;
        }

        public void Show()
        {
            notificationWindow.Show();
        }

        public void SetImage(Bitmap image)
        {
            ImageSourceConverter source = new ImageSourceConverter();

            notificationWindow.icon.Source = source.ConvertFrom(image) as ImageSource;
        }
    }
}