using Lab7_8.Elements;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Lab7_8.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private AddWindow _addWindow;
        public ObservableCollection<Task> Tasks { get; set; }

        public ICommand AddWindowCommand { get; set; }
        public ICommand AddNewTask { get; set; }

        public MainViewModel(MainWindow mainWindow)
        {
            Tasks = new ObservableCollection<Task>
            {
                new Task { Title = "Shower", Periodicity = Periodicity.Single, TaskCategory = Category.House, TaskPriority = Priority.Medium},
                new Task { Title = "Report", Periodicity = Periodicity.Single, TaskCategory = Category.Work, TaskPriority = Priority.High}
            };
            AddWindowCommand = new Command(createAddWindow, canExecuteMethod);
            AddNewTask = new Command(saveNewTask, canExecuteMethod);

            mainWindow.tasksGrid.ItemsSource = Tasks;
        }

        private bool canExecuteMethod(object parameter)
        {
            return true;
        }

        private void saveNewTask(object parameter)
        {
            Tasks.Add(new Task { Title = _addWindow.titleTB.Text, TaskDescription = _addWindow.descTB.Text,
                Periodicity = (Periodicity)Enum.Parse(typeof(Periodicity), _addWindow.periodicityCB.Text),
                TaskCategory = (Category)Enum.Parse(typeof(Category), _addWindow.categoryCB.Text),
                TaskPriority = (Priority)Enum.Parse(typeof(Priority), _addWindow.priorityCB.Text)
            });
            _addWindow.Close();
        }

        private void createAddWindow(object parameter)
        {
            _addWindow = new AddWindow();
            _addWindow.DataContext = this;
            _addWindow.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
