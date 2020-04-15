using Lab7_8.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Cursor = new Cursor($"{Environment.CurrentDirectory}\\Arrow.cur");
            DataContext = new MainViewModel(this);
        }
    }
}
