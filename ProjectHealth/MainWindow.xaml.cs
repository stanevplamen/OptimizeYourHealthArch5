using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjectHealth.Bubbles;
using ProjectHealth.Scheduler;
using System.Collections.ObjectModel;
using System.Timers;
using ProjectHealth.Reminder;
using Quartz;
using Quartz.Impl;
using MessageBox = WPFMessageBox.MessageBox;
using WPFGrowlNotification;


namespace ProjectHealth
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static IScheduler _scheduler;
        public static bool isFirstStart = true;
        public static EventSchedule mainScheduler;
        public static EventSchedule remindScheduler;
        public Remind mainReminder = new Remind();
        public static Queue<EventNode> raisedEvent;
  
        public MainWindow()
        {
            InitializeComponent();

            raisedEvent = new Queue<EventNode>();
            BubbleTreeLoader.InitializeTree();
            mainScheduler = new EventSchedule();
            mainFrame.Navigate(new DatesSchedulePage());
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            _scheduler = schedulerFactory.GetScheduler();
            _scheduler.Start();

            remindScheduler = new EventSchedule();
            mainReminder.CheckReminder();
            MinimizeToTray.Enable(this);

        }

        void OnHomeButtonClick(object sender, RoutedEventArgs args)
        {
            mainFrame.Navigate(new Welcome());         
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            //base.OnClosing(e);
            e.Cancel = true;
            //Environment.Exit(0);
            MessageBoxResult askResult = MessageBox.ShowQuestion("Do you want to Exit?", "The scheduler cannot remind you during offline mode!\nYes: Exit (offline mode)\nNo: Minimize to tray (working reminder)\nCancel: Cancel command", true);
            if (askResult == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            if (askResult == MessageBoxResult.No)
            {
                WindowState = WindowState.Minimized;
            }
            //this.Hide();
            //
        }

        private void OnExitButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult askResult = MessageBox.ShowQuestion("Do you want to Exit?", "The scheduler cannot remind you during offline mode!\nYes: Exit (offline mode)\nNo: Minimize to tray (working reminder)\nCancel: Cancel command", true);
            if (askResult == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            if (askResult == MessageBoxResult.No)
            {
                WindowState = WindowState.Minimized;
            }
        }

        private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
  