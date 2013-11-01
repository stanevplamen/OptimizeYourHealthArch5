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
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Page
    {
        public Welcome()
        {
            InitializeComponent();
        }
        void OpenBasicPage(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("MainPages/BasicRulez.xaml", UriKind.Relative));

            //MessageBox.Show(BubbleTreeLoader.basicPrinciples.Story()); // TODO display on separate page
            // TODO do the other classes like this
        }

        void OpenRestorativeMove(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("MainPages/RestorativeMovement.xaml", UriKind.Relative));
        }

        void OpenHealthyFood(object sender, RoutedEventArgs args) 
        {
            this.NavigationService.Navigate(new Uri("MainPages/HealthyFood.xaml", UriKind.Relative));
        }

        void OpenEffectiveComunication(object sender, RoutedEventArgs args) 
        {
            this.NavigationService.Navigate(new Uri("MainPages/EffectiveComunication.xaml", UriKind.Relative));
        }

        void OpenWorkAndLive(object sender, RoutedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("MainPages/WorkAndLive.xaml", UriKind.Relative));
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

        private void OpenBubbleSearchPage(object sender, RoutedEventArgs e)
        {
            SearchBubblePage basicSearchPage = new SearchBubblePage();
            NavigationService.Navigate(basicSearchPage);
        }
    }
}
