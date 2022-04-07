using System.Collections.ObjectModel;
using MoesApp.Views.Windows;
using MoesApp.Data;
using MoesApp.Models;
using MoesApp.ViewModels.Base;
using MoesApp.Commands;

namespace MoesApp.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Заголовок окна

        private string _Title = "Учет пожаров в МЧС";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set => Set(ref _Title, value);
        }

        #endregion
        #region Данные общих сведений
        private ObservableCollection<FileReport> _FileReports = DataFileReport.GetAllFileReports();

        public ObservableCollection<FileReport> FileReports
        {
            get { return _FileReports; }
            set 
            { 
                _FileReports = value;
                OnPropertyChanged("FileReports");
            }
        }

        private FileReport _SelectedFileRep;

        public FileReport SelectedFileRep
        {
            get => _SelectedFileRep;
            set => Set(ref _SelectedFileRep, value);
        }
        #endregion
        #region Команд открытия окна

        private RelayCommand _OpenWindow;
        public RelayCommand OpenWindow
        {
            get
            {
                return _OpenWindow ?? new RelayCommand(obj =>
                {
                    ShowCreateFileReport();
                });
            }
        }

        #endregion
        #region Метод открытие окна

        public void ShowCreateFileReport()
        {
            ReportWindow newWindow = new ReportWindow();
            newWindow.Owner = App.Current.MainWindow;
            newWindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            newWindow.ShowDialog();
        }

        #endregion
    }
}
