﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using MessageBox = WPFMessageBox.MessageBox;
using ProjectHealth.Scheduler;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;
using System.Reflection;
using System.Windows.Forms;
using WPFGrowlNotification;
using ProjectHealth;
using ProjectHealth.Reminder;

namespace WPFGrowlNotification
{
    public partial class GrowlNotifiactions
    {
        private const byte MAX_NOTIFICATIONS = 4;
        private int count;
        public Notifications Notifications = new Notifications();
        private readonly Notifications buffer = new Notifications();

        public GrowlNotifiactions()
        {
            InitializeComponent();
            NotificationsControl.DataContext = Notifications;
        }

        public void AddNotification(Notification notification)
        {
            notification.Id = count++;
            if (Notifications.Count + 1 > MAX_NOTIFICATIONS)
                buffer.Add(notification);
            else
                Notifications.Add(notification);

            //Show window if there're notifications
            if (Notifications.Count > 0 && !IsActive)
                Show();
        }

        public void RemoveNotification(Notification notification)
        {
            if (Notifications.Contains(notification))
                Notifications.Remove(notification);

            if (buffer.Count > 0)
            {
                Notifications.Add(buffer[0]);
                buffer.RemoveAt(0);
            }

            //Close window if there's nothing to show
            if (Notifications.Count < 1)
                Hide();
        }

        private void NotificationWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Height != 0.0)
                return;
            var element = sender as Grid;
            RemoveNotification(Notifications.First(n => n.Id == Int32.Parse(element.Tag.ToString())));
        }
    }
}
