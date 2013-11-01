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
    public partial class HealthyFood : Page
    {
        public HealthyFood()
        {
            InitializeComponent();
        }

        private void OpenHealthyFoodInfo(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.healthyFoodInfo;
            NavigationService.Navigate(healthyFoodPage);
        }

        #region Caloric Intake

        private void OpenCaloricIntake(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.caloricIntake;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenBMIIndex(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.bmiIndex;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Caloric Intake


        #region Food Influence

        private void OpenFoodInfluence(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.foodInfluence;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenCaffeine(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.caffeine;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenCarbohydratesHealthy(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.carboHealthy;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenFats(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.fats;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenProteinsHealth(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.protHealthy;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenSugar(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.sugar;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Food Influence

        #region Good Practices

        private void OpenGoodPractices(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.goodPractices;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenAlternation(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.alternation;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenFiveTimesHealthy(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.fiveHealthy;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenFluid(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.fluid;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenTurnHabit(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.turnHabit;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Good Practices

        #region Pyramid

        private void OpenPyramid(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.pyramid;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Pyramid

        #region Stress Handling

        private void OpenStressHandling(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.stressHandling;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Stress Handling

        #region Super Foods

        private void OpenSuperFoods(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.superFoods;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenAlgae(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.algae;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenAnimal(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.animal;
            NavigationService.Navigate(healthyFoodPage);
        }

        private void OpenPlant(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.plant;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Super Foods

        #region Vitamins and Minerals

        private void OpenVitaminsAndMinerals(object sender, RoutedEventArgs e)
        {
            DisplayPage healthyFoodPage = new DisplayPage();
            DisplayPage.dBubble = BubbleTreeLoader.vitaminsAndMinerals;
            NavigationService.Navigate(healthyFoodPage);
        }

        #endregion Vitamins and Minerals
    }
}
