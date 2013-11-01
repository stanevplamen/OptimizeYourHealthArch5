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
using ProjectHealth.Scheduler;
using ProjectHealth.Bubbles;

namespace ProjectHealth
{
    /// <summary>
    /// Interaction logic for ReadingPage.xaml
    /// </summary>
    public partial class ReadingPage : Page
    {
        public static EventNode workNodeTransfer;

        public ReadingPage()
        {
            InitializeComponent();
        }

        private void OpenSchedulePage(object sender, RoutedEventArgs e)
        {
            DatesSchedulePage basicShedulePage = new DatesSchedulePage();
            NavigationService.Navigate(basicShedulePage);
        }

        private void OpenEventPage(object sender, RoutedEventArgs e)
        {
            DateCreatePage basicDateCreatePage = new DateCreatePage();
            DateCreatePage.dBubbleTransfer = new BasicHealthPrinciples(0, "No title");
            NavigationService.Navigate(basicDateCreatePage);
        }

        private void OpenStartPage(object sender, RoutedEventArgs e)
        {
            Welcome startPage = new Welcome();
            NavigationService.Navigate(startPage);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dateTextBox.Text = workNodeTransfer.DatetimeEvent.ToString();
            titleTextBox.Text = workNodeTransfer.Title;
            descriptionTextBox.Text = workNodeTransfer.Description;
        }
    }
}
