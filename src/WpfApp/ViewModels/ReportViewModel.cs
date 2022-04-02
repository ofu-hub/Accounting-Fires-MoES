using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.ViewModels.Base;
using WpfApp.Models;

namespace WpfApp.ViewModels
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
