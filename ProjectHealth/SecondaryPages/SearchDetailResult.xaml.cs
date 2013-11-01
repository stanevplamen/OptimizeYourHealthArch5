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
using MessageBox = WPFMessageBox.MessageBox;

namespace ProjectHealth
{
    /// <summary>
    /// Interaction logic for SearchDetailResult.xaml
    /// </summary>
    public partial class SearchDetailResult : Page
    {
        public static string transferString;

        public SearchDetailResult()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            titleOne.Text = "Results for: " + transferString;
            if (transferString != null)
            {
                if (transferString.Trim() != String.Empty )
	            {
                    SearchWordsMatches(transferString);
	            }
            }
        }

        private void OpenBubbleSearch(object sender, RoutedEventArgs e) 
        {
            SearchBubblePage basicSearchPage = new SearchBubblePage();
            NavigationService.Navigate(basicSearchPage);
        }

        private void OpenOpenButton(object sender, RoutedEventArgs e)
        {
            Bubble operateBubble = (Bubble)listview.SelectedItem;
            if (operateBubble != null)
            {
                try
                {
                    DisplayPage tempPage = new DisplayPage();
                    DisplayPage.dBubble = operateBubble;
                    NavigationService.Navigate(tempPage);
                }
                catch (Exception)
                {
                    try
                    {
                        throw new Exception("Error occured, please try againg.\nClick on details for more information.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.ShowError(ex);
                    } 
                    //MessageBox.Show("Please try againg");
                }
            }
        }

        private void OpenSupplementButton(object sender, RoutedEventArgs e)
        {
            Bubble operateBubble = (Bubble)listview2.SelectedItem;
            if (operateBubble != null)
            {
                try
                {
                    DisplayPage tempPage = new DisplayPage();
                    DisplayPage.dBubble = operateBubble;
                    NavigationService.Navigate(tempPage);
                }
                catch (Exception)
                {
                    try
                    {
                        throw new Exception("Error occured, please try againg.\nClick on details for more information.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.ShowError(ex);
                    } 
                    //MessageBox.Show("Please try againg");
                }
            }
        }

        private void SearchWordsMatches(string transferString)
        {
            string[] splittedSearches = transferString.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splittedSearches.Length; i++)
            {
                foreach (var bubble in BubbleTreeLoader.bubbleTree)
                {
                    SubstringFinder(bubble.Name, splittedSearches[i], bubble);
                }
            }
        }


        private void SubstringFinder(string textTemp, string targetTemp, Bubble bubble)
        {
            string text = textTemp.ToUpper();
            string target = targetTemp.ToUpper();

            int index = -1;
            index = text.IndexOf(target, index + 1);

            if (index >= 0)
            {
                listview.Items.Add(bubble);
            }
            if (bubble.Supplement != null && bubble.Supplement.Trim() != String.Empty)
            {
                int index2 = bubble.Supplement.ToUpper().IndexOf(target, 0);
                if (index2 > 0)
                {
                    listview2.Items.Add(bubble);                   
                }
                else
                {
                    if (bubble.StoryName2 != null && bubble.StoryName2.Trim() != String.Empty)
                    {
                        int index3 = bubble.StoryName2.ToUpper().IndexOf(target, 0);
                        if (index3 > 0)
                        {
                            listview2.Items.Add(bubble);
                        }
                    }
                    else
                    {
                        if (bubble.StoryName3 != null && bubble.StoryName3.Trim() != String.Empty)
                        {
                            int index4 = bubble.StoryName3.ToUpper().IndexOf(target, 0);
                            if (index4 > 0)
                            {
                                listview2.Items.Add(bubble);
                            }
                        }
                    }
                }
            }

            return;
        }
    }
}
