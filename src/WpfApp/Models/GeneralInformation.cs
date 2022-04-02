using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp.Models.Base;

namespace WpfApp.Models
{
    /// <summary>
    /// Модель общих сведений
    /// </summary>
    internal class GeneralInformation : ModelBase
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
        /// Код органа
        /// </summary>
        private string _OrganCode { get; set; } = string.Empty;

        public string OrganCode
        {
            get { return _OrganCode; }
            set { _OrganCode = value; }
        }

        /// <summary>
        /// Дата возникновения пожара
        /// </summary>
        private DateTime _DateOfFire { get; set; }

        public DateTime DateOfFire
        {
            get { return _DateOfFire; }
            set { _DateOfFire = value; }
        }

        /// <summary>
        /// Вид населенного пункта
        /// </summary>
        private string _TypeOfSettlement { get; set; } = string.Empty;

        public string TypeOfSettlement
        {
            get { return _TypeOfSettlement; }
            set { _TypeOfSettlement = value; }
        }

        /// <summary>
        /// Вид пожарной охраны населенного пункта
        /// </summary>
        private string _TypeOfFireDepSettlement { get; set; } = string.Empty;

        public string TypeOfFireDepSettlement
        {
            get { return _TypeOfFireDepSettlement; }
            set { _TypeOfFireDepSettlement = value; }
        }
    }
}
