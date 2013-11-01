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
    /// Interaction logic for RestorativeMovement.xaml
    /// </summary>
    public partial class RestorativeMovement : Page
    {
        public RestorativeMovement()
        {
            InitializeComponent();
        }

        private void OpenRestorativeMovementInfo(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.restorativeMovement;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenRule300(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.rule300;
            NavigationService.Navigate(healthyFoodPage);
        }

        #region Head Position

        private void OpenHeadPosition(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.headPosition;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenOverTheShoulders(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.overTheShoulders;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Head Position


        #region Natural Movement

        private void OpenNaturalMovement(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.naturalMovement;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenClimbing(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.climbing;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenContinious(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.continious;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenSquat(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.squat;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenWalking(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.walking;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Natural Movement


        #region Seated Position

        private void OpenSeatedPosition(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.seatedPosition;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenBreathing(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.breathing;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenNeck(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.neck;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenOnFloor(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.onFloor;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenOnPelvis(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.onPelvis;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Seated Position


        #region Stretching

        private void OpenStretching(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.stretching;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenSport(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.sport;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenBalance(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.balance;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenTwoTimes(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.twoTimes;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenWalkingFiveKm(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.walkingFiveKm;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Stretching


        #region Uprigth Position

        private void OpenUprigthPosition(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.uprigthPosition;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenShouldersAboveFeet(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.shouldersAboveFeet;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenWeigthOnHeels(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.weigthOnHeels;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenWorkingUprigth(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.workingUprigth;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Uprigth Position

    }
}
