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
    /// Main nodes buttons assignemt
    /// Secondary nodes buttons assignent
    /// Third leaf nodes buttons assignemnt
    /// </summary>
    public partial class EffectiveComunication : Page
    {
        public EffectiveComunication()
        {
            InitializeComponent();
        }

        private void OpenComunicationInfo(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.comunication;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenDesireInfo(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.desire;
            NavigationService.Navigate(comunicationPage);
        }


        #region Approach

        private void OpenApproach(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.approach;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenEgocentrism(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.egocentrism;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenHealthySelfishness(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.healthySelfishness;
            NavigationService.Navigate(comunicationPage);
        }

        #endregion Approach

        #region Cycle

        private void OpenCycle(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.cycle;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenQualityOfFunctioning(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.qualityOfFunctioning;
            NavigationService.Navigate(comunicationPage);
        }

        #endregion Cycle

        #region Models

        private void OpenModels(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.models;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenAdaptation(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.adaptation;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenAggresion(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.aggresion;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenHumility(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.humility;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenSeduction(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.seduction;
            NavigationService.Navigate(comunicationPage);
        }

        #endregion Models

        #region Stages

        private void OpenStages(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.stages;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenClosing(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.closing;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenConnection(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.connection;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenDifferentiation(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.differentiation;
            NavigationService.Navigate(comunicationPage);
        }

        #endregion Stages

        #region Techniques

        private void OpenTechniques(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.techniques;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenClearDesire(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.clearDesire;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenDisclaimer(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.disclaimer;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenEffectiveSolutions(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.effectiveSolutions;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenLimits(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.limits;
            NavigationService.Navigate(comunicationPage);
        }

        private void OpenPositiveAttitude(object sender, RoutedEventArgs e)
        {
            DisplayPage comunicationPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.positiveAttitude;
            NavigationService.Navigate(comunicationPage);
        }

        #endregion Techniques
    }
}
