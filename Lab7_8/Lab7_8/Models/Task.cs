using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab7_8.Elements
{
    public class Task : INotifyPropertyChanged
    {
        private string _title;

        private string _taskDescription;

        private bool _isDone;

        private Periodicity _periodicity;

        private Priority _taskPriority;

        private Category _taskCategory;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string TaskDescription
        {
            get { return _taskDescription; }
            set
            {
                _taskDescription = value;
                OnPropertyChanged("TaskDescription");
            }
        }

        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        public Periodicity Periodicity
        {
            get { return _periodicity; }
            set
            {
                _periodicity = value;
                OnPropertyChanged("Periodicity");
            }
        }

        public Priority TaskPriority
        {
            get { return _taskPriority; }
            set
            {
                _taskPriority = value;
                OnPropertyChanged("TaskPriority");
            }
        }

        public Category TaskCategory
        {
            get { return _taskCategory; }
            set
            {
                _taskCategory = value;
                OnPropertyChanged("TaskCategory");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
