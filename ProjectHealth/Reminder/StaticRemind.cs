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

namespace ProjectHealth.Reminder
{
    public static class StaticRemind
    {
        private static int counterAlarmsOnce = 0;
        private const double topOffset = 20;
        private const double leftOffset = 380;
        readonly public static GrowlNotifiactions growlNotifications = new GrowlNotifiactions();

        public static void CheckDates()
        {
            growlNotifications.Top = SystemParameters.WorkArea.Top + topOffset;
            growlNotifications.Left = SystemParameters.WorkArea.Left + SystemParameters.WorkArea.Width - leftOffset;
            if (MainWindow.remindScheduler.scheduleStructure != null && MainWindow.remindScheduler.scheduleStructure.Count > 0)
            {
                DateTime nowTime = DateTime.Now;
                DateTime plusHourTime = nowTime.AddMinutes(60);

                DateTime dayPlusMax = nowTime.AddMinutes(1470);
                DateTime dayPlusMin = nowTime.AddMinutes(1410);

                foreach (var savedDate in MainWindow.remindScheduler.scheduleStructure)
                {
                    if (savedDate.DatetimeEvent > nowTime && savedDate.DatetimeEvent < plusHourTime)
                    {
                        string remindString = String.Format("Notification:\nYour Event: {0} will raise in {1:mm} minutes", savedDate.Title, savedDate.DatetimeEvent - nowTime);
                        //MessageBox.Show(remindString);
                        //MessageBox.ShowInformation(remindString);
                        growlNotifications.AddNotification(new Notification { Title = "Your Health Reminder", ImageUrl = "pack://application:,,,/WPFGrowNotifications/Resources/notification-icon.png", Message = remindString });

                        MainWindow.raisedEvent.Enqueue(savedDate);
                    }

                    if (savedDate.DatetimeEvent > dayPlusMin && savedDate.DatetimeEvent < dayPlusMax)
                    {
                        string remindString = String.Format("Notification:\nYour Event: {0} will raise tomorrow ({1:dd/MM/yyyy})", savedDate.Title, dayPlusMax);
                        //MessageBox.ShowInformation(remindString);
                        growlNotifications.AddNotification(new Notification { Title = "Your Health Reminder", ImageUrl = "pack://application:,,,/WPFGrowNotifications/Resources/notification-icon.png", Message = remindString });
                    }
                }

                foreach (var eventNod in MainWindow.raisedEvent)
                {
                    counterAlarmsOnce++;
                    int transferMins = (int)(eventNod.DatetimeEvent - nowTime).Minutes;
                    IMyJob myJob = new MyJob();
                    JobDetailImpl jobDetail = new JobDetailImpl(counterAlarmsOnce.ToString(), null, myJob.GetType());
                    SimpleTriggerImpl trigger2 = new SimpleTriggerImpl("Trigger" + counterAlarmsOnce.ToString(), null, DateTime.Now.AddSeconds(transferMins * 60), null, 0, TimeSpan.Zero);
                    RaiseReminder(myJob, jobDetail, trigger2);
                }
            }
        }

        private static void RaiseReminder(IMyJob myJob, JobDetailImpl jobDetail, SimpleTriggerImpl trigger2)
        {
            AddJob(jobDetail, trigger2);
        }

        public static void AddJob(JobDetailImpl jobDetail, SimpleTriggerImpl trigger2)
        {
            MainWindow._scheduler.ScheduleJob(jobDetail, trigger2);
        }

        public class MyJob : IMyJob
        {
            public void Execute(IJobExecutionContext context)
            {
                if (MainWindow.raisedEvent.Count > 0)
                {
                    EventNode savedDate = MainWindow.raisedEvent.Dequeue();
                    DateTime nowTime = DateTime.Now;
                    string remindString = String.Format("Alarm:\nLast reminding about Event: {0} is raising at the moment!)", savedDate.Title);
                    MessageBox.ShowInformation(remindString);
                    //MessageBox.ShowInformation(new Form() { TopMost = true }, "I'm still on top, YEAH");                    
                    //growlNotifications.AddNotification(new Notification { Title = "Your Health Reminder", ImageUrl = "pack://application:,,,/WPFGrowNotifications/Resources/notification-icon.png", Message = remindString });

                    SimpleDelegate d = new SimpleDelegate(TestMethod);
                    d(remindString);
                }
                //DoMoreWork();
            }

            //public void DoMoreWork()
            //{

            //}
        }

        static void TestMethod(string remindString)
        {
            growlNotifications.AddNotification(new Notification { Title = "Your Health Reminder", ImageUrl = "pack://application:,,,/WPFGrowNotifications/Resources/notification-icon.png", Message = remindString });
        }

        internal interface IMyJob : IJob
        {
        }

        public delegate void SimpleDelegate(string param);
    }
}
