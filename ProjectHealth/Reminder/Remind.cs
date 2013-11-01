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
using WPFGrowlNotification;

namespace ProjectHealth.Reminder
{
    public class Remind
    {
        private static int counterAlarms = 0;
        private double interval60Minutes = 60 * 60 * 1000 * 1 / 60  ; // milliseconds to one hour - twenty minutes

        public void CheckReminder()
        {
            Timer checkForTime = new Timer(interval60Minutes);
            checkForTime.Elapsed += new ElapsedEventHandler(checkForTime_Elapsed);
            checkForTime.Enabled = true;
        }

        private void checkForTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (true)
            {
                CheckDates();
            }
        }


        private void CheckDates()
        {
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
                        MessageBox.ShowInformation(remindString);
                        StaticRemind.growlNotifications.AddNotification(new Notification { Title = "Your Health Reminder", ImageUrl = "pack://application:,,,/WPFGrowNotifications/Resources/notification-icon.png", Message = remindString });
                        
                        MainWindow.raisedEvent.Enqueue(savedDate);
                    }

                    if (savedDate.DatetimeEvent > dayPlusMin && savedDate.DatetimeEvent < dayPlusMax)
                    {
                        string remindString = String.Format("Notification:\nYour Event: {0} will raise tomorrow ({1:dd/MM/yyyy})", savedDate.Title, dayPlusMax);                        
                        //MessageBox.ShowInformation(remindString);
                        StaticRemind.growlNotifications.AddNotification(new Notification { Title = "Your Health Reminder", ImageUrl = "pack://application:,,,/WPFGrowNotifications/Resources/notification-icon.png", Message = remindString });
                    }
                }

                foreach (var eventNod in MainWindow.raisedEvent)
                {
                    counterAlarms++;
                    int transferMins = (int)(eventNod.DatetimeEvent - nowTime).Minutes;
                    IMyJob myJob = new MyJob();
                    JobDetailImpl jobDetail = new JobDetailImpl(counterAlarms.ToString(), null, myJob.GetType());
                    SimpleTriggerImpl trigger2 = new SimpleTriggerImpl("Trigger" + counterAlarms.ToString(), null, DateTime.Now.AddSeconds(transferMins * 60), null, 0, TimeSpan.Zero);
                    RaiseReminder(myJob, jobDetail, trigger2);
                }
            }
        }

        private void RaiseReminder(IMyJob myJob, JobDetailImpl jobDetail, SimpleTriggerImpl trigger2)
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
                    //MessageBox.ShowInformation(remindString);          
                    StaticRemind.growlNotifications.AddNotification(new Notification { Title = "Your Health Reminder", ImageUrl = "pack://application:,,,/WPFGrowNotifications/Resources/notification-icon.png", Message = remindString });
                }                              
                //DoMoreWork();
            }

            //public void DoMoreWork()
            //{

            //}
        }

        internal interface IMyJob : IJob
        {
        }
    }
}
