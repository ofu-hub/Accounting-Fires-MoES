using System.Windows;
using System.Windows.Controls;
using MoesApp.ViewModels;

namespace MoesApp.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListBox AllFileReportsView;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();

            AllFileReportsView = ViewFileReports;
        }
    }
}