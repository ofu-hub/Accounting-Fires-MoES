using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models.Base;

namespace WpfApp.Models
{
    internal class FileReport : ModelBase
    {
        /// <summary>
        /// Индефикатор
        /// </summary>
        private Guid _Id { get; set; }
        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        /// <summary>
        /// Заголовок отчета
        /// </summary>
        private string _Title { get; set; } = string.Empty;

        public string Title { 
            get { return _Title; }
            set { _Title = value; }
        }
        /// <summary>
        /// Индефикатор общих сведений
        /// </summary>
        private Guid _GeneralInfoId { get; set; }

        public Guid GeneralInfoId
        {
            get { return _GeneralInfoId; }
            set { _GeneralInfoId = value; }
        }

        /// <summary>
        /// Общие сведения
        /// </summary>
        public virtual GeneralInformation _GeneralInfo { get; set; }

        public GeneralInformation GeneralInfo
        {
            get { return _GeneralInfo; }
            set { _GeneralInfo = value; }
        }
    }
}
