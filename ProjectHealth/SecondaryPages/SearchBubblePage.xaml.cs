using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.ComponentModel;
using MessageBox = WPFMessageBox.MessageBox;

namespace ProjectHealth
{
    /// <summary>
    /// Interaction logic for SearchBubblePage.xaml
    /// </summary>
    public partial class SearchBubblePage : Page
    {
        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        Regex regex;
        private bool startColorSearch = false; 

        public SearchBubblePage()
        {
            InitializeComponent();
        }

        private void OpenBubbleSearchPage(object sender, RoutedEventArgs e)
        {
            SearchDetailResult searchResultPage = new SearchDetailResult();
            SearchDetailResult.transferString = textboxsearch.Text;
            NavigationService.Navigate(searchResultPage);
        }

        private void OpenBubbleSearch(object sender, RoutedEventArgs e)
        {
            startColorSearch = true;
            FindListViewItem(listview);
            startColorSearch = false; 
        }

        //private void CloseBubbleSearch(object sender, RoutedEventArgs e) // this could be removed- always close
        //{
        //    //startColorSearch = false;
        //    //FindListViewItem(listview);
        //}

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listview.ItemsSource = BubbleTreeLoader.bubbleTree;
        }

        #region Sorting columns

        // Header click event
        void results_Click(object sender, RoutedEventArgs e)
        {
            startColorSearch = false; 
            GridViewColumnHeader headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked != _lastHeaderClicked)
                {
                    direction = ListSortDirection.Ascending;
                }

                else
                {
                    if (_lastDirection == ListSortDirection.Ascending)
                    {
                        direction = ListSortDirection.Descending;
                    }
                    else
                    {
                        direction = ListSortDirection.Ascending;
                    }
                }
                string header = headerClicked.Column.Header as string;
                Sort(header, direction);
                _lastHeaderClicked = headerClicked;
                _lastDirection = direction;
            }
        }

        // Sort code
        private void Sort(string sortBy, ListSortDirection direction)
        {
            if (listview != null)
            {
                listview.Items.SortDescriptions.Clear();

                SortDescription sd = new SortDescription(sortBy, direction);

                listview.Items.SortDescriptions.Add(sd);

                listview.Items.Refresh();
            }
        }

        #endregion Sorting columns

        #region Color Search

        private void OnScrollChanged(object sender, RoutedEventArgs e)
        {
            if (startColorSearch == true)
            {
               FindListViewItem(listview);
               startColorSearch = false;
            }      
        }

        private void textboxsearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (startColorSearch == true)
            {
                FindListViewItem(listview);
            }        
        }
        public void FindListViewItem(DependencyObject obj)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                ListViewItem lv = obj as ListViewItem;
                if (lv != null)
                {
                    HighlightText(lv);
                }
                FindListViewItem(VisualTreeHelper.GetChild(obj as DependencyObject, i));
            }
        }
        private void HighlightText(Object itx)
        {
            if (itx != null)
            {
                if (itx is TextBlock)
                {
                    try
                    {
                        regex = new Regex("(" + textboxsearch.Text + ")", RegexOptions.IgnoreCase);
                        TextBlock tb = itx as TextBlock;
                        if (textboxsearch.Text.Length == 0)
                        {
                            string str = tb.Text;
                            tb.Inlines.Clear();
                            tb.Inlines.Add(str);
                            return;
                        }
                        string[] substrings = regex.Split(tb.Text);
                        tb.Inlines.Clear();
                        foreach (var item in substrings)
                        {
                            if (regex.Match(item).Success)
                            {
                                Run runx = new Run(item);
                                runx.Background = Brushes.Red;
                                tb.Inlines.Add(runx);
                            }
                            else
                            {
                                tb.Inlines.Add(item);
                            }
                        }
                        return;
                    }
                    catch (Exception)
                    {
                        return;
                    }                   
                }
                else
                {
                    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(itx as DependencyObject); i++)
                    {
                        HighlightText(VisualTreeHelper.GetChild(itx as DependencyObject, i));
                    }
                }
            }
        }

        #endregion Color Search
    }
}
