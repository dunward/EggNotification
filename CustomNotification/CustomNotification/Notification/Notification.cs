using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CustomNotification
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

            notificationWindow.Show();
        }

        public void SetBackgroundColor(Color color)
        {
            Brush brush = new SolidColorBrush(color);
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
    }
}