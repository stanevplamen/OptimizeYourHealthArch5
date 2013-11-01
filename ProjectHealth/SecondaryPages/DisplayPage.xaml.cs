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

namespace ProjectHealth
{
    /// <summary>
    /// Interaction logic for DisplayPage.xaml
    /// </summary>
    public partial class DisplayPage : Page
    {
        public static Bubble dBubble;

        public DisplayPage()
        {
            InitializeComponent();
        }

        private void OpenCalendarPage(object sender, RoutedEventArgs e)
        {
            DateCreatePage basicDateCreatePage = new DateCreatePage();
            DateCreatePage.dBubbleTransfer = dBubble;
            NavigationService.Navigate(basicDateCreatePage);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            titleOne.Text = dBubble.Name;
            subtitleRunText.Text = dBubble.Story();
            secondaryRunText.Text = dBubble.SecondaryStory();
            thirdlyRunText.Text = dBubble.ThirdlyStory();

            try
            {
                Uri uri = new Uri(dBubble.Image(), UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);
                subtitleRunImage.Source = imgSource;
            }
            catch (Exception)
            {

            }

            try
            {
                Uri uri = new Uri(dBubble.SecondaryImage(), UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);
                secondaryRunImage.Source = imgSource;

            }
            catch (Exception)
            {
                
            }
        }
    }
}
