using MoesApp.ViewModels.Base;

namespace MoesApp.ViewModels
{
    internal class ReportViewModel : ViewModelBase
    {
        #region Заголовок окна

        private string _Title = "Отчет о пожаре";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set => Set(ref _Title, value);
        }

        #endregion
    }
}
