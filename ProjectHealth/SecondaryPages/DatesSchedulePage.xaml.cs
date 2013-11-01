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
using ProjectHealth.Scheduler;
using System.Threading;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ProjectHealth;
using MessageBox = WPFMessageBox.MessageBox;
using ProjectHealth.Reminder;
using WPFGrowlNotification;

namespace ProjectHealth
{
    /// <summary>
    /// Interaction logic for DatesSchedulePage.xaml
    /// </summary>
    public partial class DatesSchedulePage : Page
    {
        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        private bool stopRefreshControls = false;
        private bool dataChanged = false;

        public DatesSchedulePage()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {         
            StringNode operatedNode = (StringNode)listView1.SelectedItem; //new ListViewClass(value1, value2);
            if (operatedNode != null)
            {
                try
                {
                    DateTime workDate = DateTime.Parse(operatedNode.Date);
                    string workTitle = operatedNode.Title;
                    string workDescription = operatedNode.Description;
                    EventNode workNode = new EventNode(workDate, workTitle, workDescription);
                    ReadingPage basicDateReadPage = new ReadingPage();
                    ReadingPage.workNodeTransfer = workNode;
                    NavigationService.Navigate(basicDateReadPage);
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            setDataChanged(true);
            AddRow();
        }

        private void AddRow()
        {
            DateTime newDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            listView1.Items.Add(new StringNode(newDate.ToString(), "No Title", "No Description"));
            listView1.SelectedIndex = listView1.Items.Count - 1;
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            setDataChanged(true);
            int selectedIndex = listView1.SelectedIndex;

            listView1.Items.Remove(listView1.SelectedItem);

            // if no rows left, add a blank row
            if (listView1.Items.Count == 0)
            {
                AddRow();
            }
            else if (selectedIndex <= listView1.Items.Count - 1) // otherwise select next row
            {
                listView1.SelectedIndex = selectedIndex;
            }
            else // not above cases? Select last row
            {
                listView1.SelectedIndex = listView1.Items.Count - 1;
            }
        }

        private void RefreshListView(string value1, string value2, string value3)
        {
            StringNode operatedNode = (StringNode)listView1.SelectedItem; //new ListViewClass(value1, value2);
            if (operatedNode != null && !stopRefreshControls)
            {
                setDataChanged(true);

                operatedNode.Date= value1;
                operatedNode.Title = value2;
                operatedNode.Description = value3;

                listView1.Items.Refresh();
            }
        }

        private void dateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshListView(dateTextBox.Text, titleTextBox.Text, descriptionTextBox.Text);
        }

        private void titleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshListView(dateTextBox.Text, titleTextBox.Text, descriptionTextBox.Text);
        }

        private void descriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshListView(dateTextBox.Text, titleTextBox.Text, descriptionTextBox.Text);
        }


        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StringNode operatedNode = (StringNode)listView1.SelectedItem;
            if (operatedNode != null)
            {
                stopRefreshControls = true;
                dateTextBox.Text = operatedNode.Date;
                titleTextBox.Text = operatedNode.Title;
                descriptionTextBox.Text = operatedNode.Description;
                stopRefreshControls = false;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowData();

            if (listView1.Items.Count == 0)
            {
                AddRow();
            }
            else
            {
                AddRow();
                listView1.SelectedIndex = listView1.Items.Count - 1;
            }
            setDataChanged(false); 
            
            DateTime newDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            dateTextBox.Text = newDate.ToString();
            if (MainWindow.isFirstStart == true)
            {
                MainWindow.isFirstStart = false;
                Welcome newWelcome = new Welcome();
                NavigationService.Navigate(newWelcome);
                StaticRemind.CheckDates();
            }
        }

        private void ShowData()
         {
            if (MainWindow.remindScheduler.scheduleStructure != null)
            {
                MainWindow.remindScheduler.scheduleStructure.Clear();
            }
            MyData md = new MyData();
            listView1.Items.Clear();

            foreach (var row in md.GetRows())
            {
                listView1.Items.Add(row);
            }


            if (MainWindow.mainScheduler.scheduleStructure != null && MainWindow.mainScheduler.scheduleStructure.Count > 0)
            {
                foreach (var eventNode in MainWindow.mainScheduler.scheduleStructure)
                {
                    listView1.Items.Add(new StringNode(eventNode.DatetimeEvent.ToString(), eventNode.Title, eventNode.Description));
                }
                SaveCurrentContent();
            }

            MainWindow.mainScheduler.scheduleStructure.Clear();
              
            foreach (var node in listView1.Items)
            {
                try
                {
                    StringNode operatedNode = (StringNode)node;
                    DateTime workDate = DateTime.Parse(operatedNode.Date);
                    MainWindow.remindScheduler.scheduleStructure.Add(new EventNode(workDate, operatedNode.Title, operatedNode.Description));
                }
                catch (Exception)
                {
                    try
                    {
                        throw new Exception("The remainder may not working correctly!\nPlease check your events` dates.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.ShowError(ex);
                    }                   
                    //MessageBox.Show("The remainder may not working correctly!\nPlease check your events` dates.");
                }              
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            saveButton.IsEnabled = false;

            try
            {
                if (dataChanged)
                {
                    SaveCurrentContent();
                    MessageBox.ShowInformation(String.Format("The schedule has been successfully saved!", titleTextBox.Text));
                }
            }
            catch (Exception)
            {
                try
                {
                    throw new Exception("Error occured, please try again!\nPlease check your events` dates.");
                }
                catch (Exception ex)
                {
                    MessageBox.ShowError(ex);
                }  
            }


            ShowData();
            // saveButton.IsEnabled = true;
        }

        private void SaveCurrentContent()
        {
            MyData md = new MyData();
            md.Save(listView1.Items);
            setDataChanged(false);
        }

        private void setDataChanged(bool value)
        {
            dataChanged = value;
            saveButton.IsEnabled = value;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dataChanged)
            {
                string message = "Your changes are not saved. Do you want to save it now?";
                MessageBoxResult result = MessageBox.Show(message,
                        this.Title,
                        MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    MyData md = new MyData();
                    md.Save(listView1.Items);
                    setDataChanged(false);
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == MessageBoxResult.No)
                {
                    // do nothing
                }
            }
        }


        #region Sorting columns

        // Header click event
        void results_Click(object sender, RoutedEventArgs e)
        {
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
            if (listView1 != null)
            {
                listView1.Items.SortDescriptions.Clear();

                SortDescription sd = new SortDescription(sortBy, direction);

                listView1.Items.SortDescriptions.Add(sd);

                listView1.Items.Refresh();
            }
        }

        #endregion Sorting columns
    }
}

     
        