using Lab7_8.Elements;
using Lab7_8.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Lab7_8.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private AddWindow _addWindow;
        private MainWindow _mainWindow;
        private ObservableCollection<Task> Tasks { get; set; }
        private FileIOService _fileIOService;

        #region commands
        public ICommand AddWindowCommand { get; set; }
        public ICommand AddNewTask { get; set; }
        public ICommand DeleteSelectedTasks { get; set; }
        public ICommand EditTaskCommand { get; set; }
        #endregion

        public MainViewModel(MainWindow mainWindow)
        {
            _fileIOService = new FileIOService(PATH);

            Tasks = new ObservableCollection<Task>();

            try
            {
                Tasks = _fileIOService.LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            AddWindowCommand = new Command(createAddWindow, canExecuteMethod);
            AddNewTask = new Command(saveNewTask, canExecuteMethod);
            DeleteSelectedTasks = new Command(deleteSelectedTasks, canExecuteMethod);
            EditTaskCommand = new Command(editTask, canExecuteMethod);

            mainWindow.tasksGrid.ItemsSource = Tasks;
            _mainWindow = mainWindow;
        }

        #region methodsForCommands
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

            _fileIOService.SaveData(Tasks);

            _addWindow.Close();
        }

        private void deleteSelectedTasks(object parameter)
        {
            Tasks.Remove(_mainWindow.tasksGrid.SelectedItem as Task);
            _fileIOService.SaveData(Tasks);
        }

        private void createAddWindow(object parameter)
        {
            _addWindow = new AddWindow();
            _addWindow.DataContext = this;
            _addWindow.Show();
        }

        private void editTask(object parameter)
        {
            
        }
        #endregion



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
