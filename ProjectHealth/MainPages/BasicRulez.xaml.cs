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
    public partial class BasicRulez : Page
    {
        public BasicRulez()
        {
            InitializeComponent();
        }

        private void BasicHealthInfo(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.basicHealthInfo;
            NavigationService.Navigate(basicRulesPage);
        }

        #region Nutrition

        private void OpenNutrition(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.nutrition;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenCarbohydrates(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.carbohydrates;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenDifferentFood(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.differentFood;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenFiveTimes(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.fiveTimes;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenHoneyLemon(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.honeyLemon;
            NavigationService.Navigate(basicRulesPage);
        }


        private void OpenProteins(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.proteins;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenRawFood(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.rawFood;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenTwoHours(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.twoHBefore;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenWater(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.water;
            NavigationService.Navigate(basicRulesPage);
        }

        #endregion Nutrition

        #region Sport

        private void OpenSport(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.sport;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenAchievableGoals(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.achievableGoals;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenExtremeSports(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.extremeSports;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenJoggingFitness(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.joggingFitness;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenPersonalPreferences(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.personalPreferences;
            NavigationService.Navigate(basicRulesPage);
        }

        #endregion Sport

        #region Rest Time

        private void OpenRestTime(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.restTime;
            NavigationService.Navigate(basicRulesPage);
        }

        #endregion Rest Time

        #region Same days

        private void OpenSameDays(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.sameDays;
            NavigationService.Navigate(basicRulesPage);
        }

        #endregion Same days

        #region Rules

        private void OpenRules(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.rules;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenBalancedDiet(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.balancedDiet;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenHoney(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.honey;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenLessSalt(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.lessSalt;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenMoreWater(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.moreWater;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenRegularMeals(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.regularMeals;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenSweets(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.sweets;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenVariedDiet(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.variedDiet;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenVariedFats(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.variedFats;
            NavigationService.Navigate(basicRulesPage);
        }

        private void OpenWholemeals(object sender, RoutedEventArgs e)
        {
            DisplayPage basicRulesPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.wholemeals;
            NavigationService.Navigate(basicRulesPage);
        }

        #endregion Rules
    }
}
