using Lab7_8.Elements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Lab7_8.Views
{
    /// <summary>
    /// Логика взаимодействия для SortWindow.xaml
    /// </summary>
    public partial class SortWindow : Window
    {
        private ObservableCollection<Task> _Tasks { get; set; }
        private IEnumerable<Task> selectedTasks { get; set; }

        public SortWindow(ObservableCollection<Task> Tasks)
        {
            InitializeComponent();

            houseRB.Checked += new RoutedEventHandler(radioButtons_CheckedChanged);
            workRB.Checked += new RoutedEventHandler(radioButtons_CheckedChanged);
            familyRB.Checked += new RoutedEventHandler(radioButtons_CheckedChanged);
            studyRB.Checked += new RoutedEventHandler(radioButtons_CheckedChanged);

            highRB.Checked += new RoutedEventHandler(priorityRadioButtons_CheckedChanged);
            mediumRB.Checked += new RoutedEventHandler(priorityRadioButtons_CheckedChanged);
            lowRB.Checked += new RoutedEventHandler(priorityRadioButtons_CheckedChanged);

            tasksGrid.ItemsSource = selectedTasks;

            _Tasks = Tasks;
        }

        private void radioButtons_CheckedChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Category category = Category.Family;

            priorityGB.IsEnabled = false;

            switch (radioButton.Content)
            {
                case "House":
                    category = Category.House;
                    break;
                case "Work":
                    category = Category.Work;
                    break;
                case "Study":
                    category = Category.Study;
                    break;
                case "Family":
                    category = Category.Family;
                    break;
            }

            selectedTasks = from item in _Tasks where item.TaskCategory == category select item;

            tasksGrid.ItemsSource = selectedTasks;
        }

        private void priorityRadioButtons_CheckedChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Priority priority = Priority.High;

            categoryGB.IsEnabled = false;

            switch (radioButton.Content)
            {
                case "High":
                    priority = Priority.High;
                    break;
                case "Medium":
                    priority = Priority.Medium;
                    break;
                case "Low":
                    priority = Priority.Low;
                    break;
            }

            selectedTasks = from item in _Tasks where item.TaskPriority == priority select item;

            tasksGrid.ItemsSource = selectedTasks;
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            priorityGB.IsEnabled = true;
            categoryGB.IsEnabled = true;

            houseRB.IsChecked = false;
            workRB.IsChecked = false;
            familyRB.IsChecked = false;
            studyRB.IsChecked = false;
            highRB.IsChecked = false;
            mediumRB.IsChecked = false;
            lowRB.IsChecked = false;
        }
    }
}
