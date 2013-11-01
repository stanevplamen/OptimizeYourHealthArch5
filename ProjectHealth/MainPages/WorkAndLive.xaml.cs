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
    /// Interaction logic for WorkAndLive.xaml
    /// </summary>
    public partial class WorkAndLive : Page
    {
        public WorkAndLive()
        {
            InitializeComponent();
        }


        private void OpenWorkAndLiveInfo(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.workAndLive;
            NavigationService.Navigate(healthyFoodPage);
        }

        #region Bad Practices Work

        private void OpenBadPracticesWork(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.badPracticesWork;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenBadEffect(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.badEffect;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenFatigue(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.fatigue;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenGrizzing(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.grizzling;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenNigthWorking(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.nigthWorking;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenNoFreeTime(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.noFreeTime;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenNoLunchBreak(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.noLunchBreak;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenNoRest(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.noRest;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenTemperLoss(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.temperLoss;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Bad Practices Work

        #region Care For Ourselves

        private void OpenCareForOurSelves(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.careForOurselves;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenFavouritePeople(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.favouritePeople;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenHealthCare(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.healthCare;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenJourneys(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.journeys;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenVacations(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.vacantion;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Care For Ourselves

        #region Control in work

        private void OpenControlInWork(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.controlInWork;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenDelegation(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.delegation;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenSayingNo(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.sayingNo;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenTimePlan(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.timePlan;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenTodoLists(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.todoLists;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Control in work


        #region Do More Happy

        private void OpenDoMoreHappy(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.doMoreHappy;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenBodyCare(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.bodyCare;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenFamilyCare(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.familyCare;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenFinanceCare(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.financeCare;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenHealthyNutrition(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.healthyNutrition;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenMindDevelopment(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.mindDevelopment;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenSocialNetworking(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.socialNetworking;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Do More Happy

        #region Stress measures

        private void OpenStressMeasures(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.stressMeasures;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenRest(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.restTime;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenDissolution(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.dissolition;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenExersises(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.exercises;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenNoOverloads(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.noOverloads;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenRelaxation(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.relaxation;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Stress measures
    }
}
