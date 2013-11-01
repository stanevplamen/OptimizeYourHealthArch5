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
using MessageBox = WPFMessageBox.MessageBox;

namespace ProjectHealth
{
    /// <summary>
    /// Interaction logic for DateCreatePage.xaml
    /// </summary>
    public partial class DateCreatePage : Page
    {
        public static Bubble dBubbleTransfer;

        public DateCreatePage()
        {
            InitializeComponent();
        }

        private void OpenAddToSchedule(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime eventDate = DateTime.Parse(dateTextBox.Text);
                MainWindow.mainScheduler.Add(new EventNode(eventDate, titleTextBox.Text, descriptionTextBox.Text)); 
                //MessageBox.Show("The event has been added successfully to the scheduler");
                MessageBox.ShowInformation(String.Format("The event {0} has been added successfully to the scheduler!", titleTextBox.Text));
                OpenSchedulePage(sender, e);
            }
            catch (Exception)
            {
                try
                {
                    throw new Exception("The event can not be added to the scheduler.\nClick on details for more information.");
                }
                catch (Exception ex)
                {
                    MessageBox.ShowError(ex);
                } 
                //MessageBox.Show("The event can not be added to the scheduler due to invalid date format");
            }
        }

        private void OpenClearText(object sender, RoutedEventArgs e)
        {
            DateTime newDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);

            dateTextBox.Text = newDate.ToString();
            titleTextBox.Text = String.Empty;
            descriptionTextBox.Text = String.Empty;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString();
            titleTextBox.Text = dBubbleTransfer.Name;      
        }

        private void OpenSchedulePage(object sender, RoutedEventArgs e)
        {
            DatesSchedulePage basicShedulePage = new DatesSchedulePage();
            NavigationService.Navigate(basicShedulePage);
        }
    }
}
