using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp.ViewModels.Base;
using WpfApp.Models;

namespace WpfApp.ViewModels
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
        public ObservableCollection<FileReport> FileReports { get; set; }
        public ObservableCollection<GeneralInformation> GeneralInformations { get; set; }
        private FileReport _SelectedFileRep;
        public FileReport SelectedFileRep
        {
            get => _SelectedFileRep;
            set => Set(ref _SelectedFileRep, value);
        }

        public MainWindowViewModel()
        {
/*            GeneralInformations = new ObservableCollection<GeneralInformation>
            {
                new GeneralInformation { Id = Guid.Parse("01e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                new GeneralInformation { Id = Guid.Parse("02e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                new GeneralInformation { Id = Guid.Parse("03e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                new GeneralInformation { Id = Guid.Parse("04e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" }
            };*/
            FileReports = new ObservableCollection<FileReport>
            {
                new FileReport { 
                    Id=Guid.Parse("f1e5af01-50ab-4d55-87cc-018918d348f3"),
                    Title="Консвервный завод",
                    GeneralInfo = new GeneralInformation { Id = Guid.Parse("01e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                },
                new FileReport {
                    Id=Guid.Parse("f2e5af01-50ab-4d55-87cc-018918d348f3"),
                    Title="Вино-ликерный завод",
                    GeneralInfo = new GeneralInformation { Id = Guid.Parse("02e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                },
                new FileReport {
                    Id=Guid.Parse("f3e5af01-50ab-4d55-87cc-018918d348f3"),
                    Title="Частный дом №5",
                    GeneralInfo = new GeneralInformation { Id = Guid.Parse("03e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                },
                new FileReport {
                    Id=Guid.Parse("f4e5af01-50ab-4d55-87cc-018918d348f3"),
                    Title="Брацкий парк",
                    GeneralInfo = new GeneralInformation { Id = Guid.Parse("01e5af04-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                },
                new FileReport {
                    Id=Guid.Parse("f4e5af01-50ab-4d55-87cc-018918d348f3"),
                    Title="Аквапарк",
                    GeneralInfo = new GeneralInformation { Id = Guid.Parse("05e5af01-50ab-4d55-87cc-018918d348f3"), OrganCode = "8512", DateOfFire = DateTime.Now, TypeOfSettlement = "1", TypeOfFireDepSettlement = "1" },
                },
            };
        }
        #endregion
    }
}
