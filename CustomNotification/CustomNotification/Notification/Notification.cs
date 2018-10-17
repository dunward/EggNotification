using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomNotification
{
    public class Notification
    {
        NotificationWindow notificationWindow;

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

        public void SetMessage(string message)
        {
            notificationWindow.Message.Text = message;
        }
    }
}
