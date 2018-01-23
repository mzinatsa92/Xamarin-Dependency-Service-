using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LearnDepency.Droid
{
    public class Notify : INotify
    {
        const string tag = "Notify";
        PendingIntent pendingIntent;
        const int NotificationID = 10000;
        public Notification notification = new Notification();

        public void UpdateNotification(string title, string text)
        {
            // Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(Application.Context)
                .SetContentTitle(title).SetContentText(text)
            .SetSmallIcon(Resource.Drawable.abc_edit_text_material);

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager =
            Application.Context.GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = NotificationID;
            notificationManager.Notify(notificationId, notification);


        }
    }
}