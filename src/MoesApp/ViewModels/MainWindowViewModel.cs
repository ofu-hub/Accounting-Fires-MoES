using System.Collections.ObjectModel;
using MoesApp.Views.Windows;
using MoesApp.Data;
using MoesApp.Models;
using MoesApp.ViewModels.Base;
using MoesApp.Commands;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

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
        #region Данные "Отчеты"
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
        #region Метод генерации PDF
        private RelayCommand _GeneratePDFFile;
        public RelayCommand GeneratePDFFile
        {
            get
            {
                return _GeneratePDFFile ?? new RelayCommand(obj =>
                {
                    GeneratePDF();
                });
            }
        }
        public void GeneratePDF()
        {
            if (SelectedFileRep == null)
                return;
            
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Создаём документ
            PdfDocument pdfDocument = new PdfDocument();
            // Добавляем страницу
            PdfPage pdfPage = pdfDocument.AddPage();
            // Для рисования документа
            XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
            // Добавляем стандартный шрифт для основного текста
            XFont font = new XFont("Times New Roman", 12);

            // "Рисуем" документ    
            gfx.DrawString("Информация об отчете", font, XBrushes.Gray,
                new XRect(0, 0, pdfPage.Width, pdfPage.Height), XStringFormat.TopCenter);
            // Заголовок
            gfx.DrawString("Заголовок: " + SelectedFileRep.Title.ToString(), new XFont("Times New Roman", 18, XFontStyle.Bold), XBrushes.Black, 
                new XRect(0, 20, pdfPage.Width, pdfPage.Height), XStringFormat.TopCenter);
            // Раздел 1.
            gfx.DrawString("Раздел 1. Общие сведения:", new XFont("Times New Roman", 14, XFontStyle.Underline), XBrushes.Black, new XPoint(50, 70));
            gfx.DrawString("Код органа (района, населенного пункта) - составителя карточки: " + SelectedFileRep.FileReportGenInfo.OrgCode.ToString(), font, XBrushes.Black, new XPoint(50, 90));
            gfx.DrawString("Дата возникновения пожара (загорания) (дд/мм/гг): " + SelectedFileRep.FileReportGenInfo.Datefire.ToString(), font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Вид населенного пункта; Вид пожарной охраны населенного пункта: " + SelectedFileRep.FileReportGenInfo.TypesettCode.ToString() + " ; " + SelectedFileRep.FileReportGenInfo.TypefiresettCode.ToString(), font, XBrushes.Black, new XPoint(50, 130));
            // Раздел 2.
            gfx.DrawString("Раздел 2. Объект пожара:", new XFont("Times New Roman", 14, XFontStyle.Underline), XBrushes.Black, new XPoint(50, 160));
            gfx.DrawString("Субъект малого и среднего предпринимательства: " + SelectedFileRep.FileReportFireObj.Subject.ToString(), font, XBrushes.Black, new XPoint(50, 180));
            gfx.DrawString("Форма собственности: " + SelectedFileRep.FileReportFireObj.SubTypeOwner.ToString(), font, XBrushes.Black, new XPoint(50, 200));
            gfx.DrawString("Категория риска объекта пожара: " + SelectedFileRep.FileReportFireObj.ObjRisk.ToString(), font, XBrushes.Black, new XPoint(50, 220));
            gfx.DrawString("Объект пожара: " + SelectedFileRep.FileReportFireObj.KindFireObj.ToString(), font, XBrushes.Black, new XPoint(50, 240));
            gfx.DrawString("Наименование объекта: " + SelectedFileRep.FileReportFireObj.NameFireObj.ToString(), font, XBrushes.Black, new XPoint(50, 260));
            gfx.DrawString("Этажность здания, эт.: " + SelectedFileRep.FileReportFireObj.FloorsObj.ToString(), font, XBrushes.Black, new XPoint(50, 280));
            gfx.DrawString("Этаж, на котором возник пожар, эт.: " + SelectedFileRep.FileReportFireObj.FloorWhereFire.ToString(), font, XBrushes.Black, new XPoint(50, 300));
            gfx.DrawString("Место возникновения пожара: " + SelectedFileRep.FileReportFireObj.LocationFire.ToString(), font, XBrushes.Black, new XPoint(50, 320));
            gfx.DrawString("Причина пожара: " + SelectedFileRep.FileReportFireObj.CauseFire.ToString(), font, XBrushes.Black, new XPoint(50, 340));
            gfx.DrawString("Виновное лицо: " + SelectedFileRep.FileReportFireObj.GuiltyPerson.ToString() + " ; " + SelectedFileRep.FileReportFireObj.AttitudePerson.ToString() + " ; " + SelectedFileRep.FileReportFireObj.StatePerson.ToString(), font, XBrushes.Black, new XPoint(50, 360));
            // Раздел 3.
            gfx.DrawString("Раздел 3. Последствия пожара:", new XFont("Times New Roman", 14, XFontStyle.Underline), XBrushes.Black, new XPoint(50, 390));
            gfx.DrawString("Погибло людей: всего, чел.: " + SelectedFileRep.FileReportFireConsequence.PeopleDiedAll.ToString() + 
                            " ; детей, чел.,: " + SelectedFileRep.FileReportFireConsequence.PeopleDiedKids.ToString() + 
                            " ; работников ПО, чел.: " + SelectedFileRep.FileReportFireConsequence.PeopleDiedWork.ToString(), font, XBrushes.Black, new XPoint(50, 410));
            gfx.DrawString("Получили травмы: всего, чел.: " + SelectedFileRep.FileReportFireConsequence.PeopleInjuredAll.ToString() +
                            " ; детей, чел.,: " + SelectedFileRep.FileReportFireConsequence.PeopleInjuredKids.ToString() +
                            " ; работников ПО, чел.: " + SelectedFileRep.FileReportFireConsequence.PeopleInjuredWork.ToString(), font, XBrushes.Black, new XPoint(50, 430));
            gfx.DrawString("Прямой ущерб от пожара, руб: " + SelectedFileRep.FileReportFireConsequence.MFireDamage.ToString(), font, XBrushes.Black, new XPoint(50, 450));
            gfx.DrawString("Здания, сооружения, ед.: уничтожено " + SelectedFileRep.FileReportFireConsequence.BuildDest.ToString() +
                            " ; повреждено: " + SelectedFileRep.FileReportFireConsequence.BuildDam.ToString(), font, XBrushes.Black, new XPoint(50, 470));
            gfx.DrawString("Жилые квартиры, ед.: уничтожено " + SelectedFileRep.FileReportFireConsequence.ApartDest.ToString() +
                            " ; повреждено: " + SelectedFileRep.FileReportFireConsequence.ApartDam.ToString(), font, XBrushes.Black, new XPoint(50, 490));
            // Раздел 4.
            gfx.DrawString("Раздел 4.Спасено (эвакуировано) на пожаре:", new XFont("Times New Roman", 14, XFontStyle.Underline), XBrushes.Black, new XPoint(50, 520));
            gfx.DrawString("Людей: спасено, чел.: " + SelectedFileRep.FileReportFireRescued.PeopleSaved.ToString() +
                            " ; эвакуировано, чел: " + SelectedFileRep.FileReportFireRescued.PeopleEvacuated.ToString(), font, XBrushes.Black, new XPoint(50, 540));
            gfx.DrawString("Скота: крупного, г.: " + SelectedFileRep.FileReportFireRescued.CattleLarge.ToString() +
                            " ; мелкого, г.: " + SelectedFileRep.FileReportFireRescued.CattleSmall.ToString(), font, XBrushes.Black, new XPoint(50, 560));
            gfx.DrawString("Автотракторной и др. техники, ед:: " + SelectedFileRep.FileReportFireRescued.Technique.ToString(), font, XBrushes.Black, new XPoint(50, 580));
            gfx.DrawString("Материальных ценностей, руб: " + SelectedFileRep.FileReportFireRescued.MatValues.ToString(), font, XBrushes.Black, new XPoint(50, 600));
            // Раздел 5.
            gfx.DrawString("Раздел 5. Развитие и тушение пожара:", new XFont("Times New Roman", 14, XFontStyle.Underline), XBrushes.Black, new XPoint(50, 630));
            gfx.DrawString("Время обнаружения (час, мин): " + SelectedFileRep.FileReportFireDevExt.DetectionTime.ToString(), font, XBrushes.Black, new XPoint(50, 650));
            gfx.DrawString("Время сообщения (час, мин): " + SelectedFileRep.FileReportFireDevExt.MessageTime.ToString(), font, XBrushes.Black, new XPoint(50, 670));
            gfx.DrawString("Время прибытия 1-го подразделения пожарной охраны (час, мин): " + SelectedFileRep.FileReportFireDevExt.ArrivalTime1st.ToString(), font, XBrushes.Black, new XPoint(50, 690));
            gfx.DrawString("Время локализации (час, мин): " + SelectedFileRep.FileReportFireDevExt.LocalTime.ToString(), font, XBrushes.Black, new XPoint(50, 710));
            gfx.DrawString("Время ликвидации открытого горения (час, мин): " + SelectedFileRep.FileReportFireDevExt.OpenFireEliTime.ToString(), font, XBrushes.Black, new XPoint(50, 730));
            gfx.DrawString("Время ликвидации последствий пожара (час, мин):: " + SelectedFileRep.FileReportFireDevExt.EliFireTime.ToString(), font, XBrushes.Black, new XPoint(50, 750));
            gfx.DrawString("Дата ликвидации: " + SelectedFileRep.FileReportFireDevExt.LiquidationDate.ToString(), font, XBrushes.Black, new XPoint(50, 770));

            // Новая страница
            // Добавляем страницу
            PdfPage pdfPage2 = pdfDocument.AddPage();
            // Для рисования документа
            gfx = XGraphics.FromPdfPage(pdfPage2);

            // Раздел 6.
            gfx.DrawString("Раздел 6. Силы и средства пожаротушения:", new XFont("Times New Roman", 14, XFontStyle.Underline), XBrushes.Black, new XPoint(50, 50));
            gfx.DrawString("Участники тушения пожара: " + SelectedFileRep.FileReportFireForcesMean.FirefightersToStr, font, XBrushes.Black, new XPoint(50, 70));
            gfx.DrawString("Техника, прибывшая к месту пожара: " + SelectedFileRep.FileReportFireForcesMean.TechniqueToStr, font, XBrushes.Black, new XPoint(50, 90));
            gfx.DrawString("Количество техники, ед.: " + SelectedFileRep.FileReportFireForcesMean.NumTechniqueToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Средства индивидуальной защиты органов дыхания: " + SelectedFileRep.FileReportFireForcesMean.IndividProtectToStr, font, XBrushes.Black, new XPoint(50, 130));
            gfx.DrawString("Водоснабжение на пожаре: " + SelectedFileRep.FileReportFireForcesMean.WaterOnFireToStr, font, XBrushes.Black, new XPoint(50, 150));
            gfx.DrawString("Руководитель тушения пожара: " + SelectedFileRep.FileReportFireForcesMean.FireExtManagerToStr, font, XBrushes.Black, new XPoint(50, 170));
            gfx.DrawString("Организация штаба пожаротушения: " + SelectedFileRep.FileReportFireForcesMean.FireFightingHeadToStr, font, XBrushes.Black, new XPoint(50, 190));
            gfx.DrawString("Выезд следственно-оперативной группы; был (1), не было (2): " + SelectedFileRep.FileReportFireForcesMean.InvestigativeTeam, font, XBrushes.Black, new XPoint(50, 210));
            gfx.DrawString("Огнетушащие средства: " + SelectedFileRep.FileReportFireForcesMean.FireExtAgentsToStr, font, XBrushes.Black, new XPoint(50, 980));
            gfx.DrawString("Первичные средства пожаротушения: " + SelectedFileRep.FileReportFireForcesMean.PrimaryFireEquipToStr, font, XBrushes.Black, new XPoint(50, 230));
            // Раздел 7.
            gfx.DrawString("Раздел 7. Сведения о погибших и травмированных:", new XFont("Times New Roman", 14, XFontStyle.Underline), XBrushes.Black, new XPoint(50, 260));
            gfx.DrawString("Пол погибшего:: " + SelectedFileRep.FileReportInfoDeadAInjured.GenderDeadToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Социальное положение погибшего: " + SelectedFileRep.FileReportInfoDeadAInjured.SocStatusToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Образование погибшего: " + SelectedFileRep.FileReportInfoDeadAInjured.EducationDeadToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Причина гибели: " + SelectedFileRep.FileReportInfoDeadAInjured.CauseDeadToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Условия, способствовавшие гибели: " + SelectedFileRep.FileReportInfoDeadAInjured.TermsDeadToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Момент наступления смерти: " + SelectedFileRep.FileReportInfoDeadAInjured.MomentDeadToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Условия, способствовавшие травмированию: " + SelectedFileRep.FileReportInfoDeadAInjured.TermsInjuryToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Степень тяжести вреда здоровью: " + SelectedFileRep.FileReportInfoDeadAInjured.HarmHealthToStr, font, XBrushes.Black, new XPoint(50, 110));
            gfx.DrawString("Возраст погибшего: " + SelectedFileRep.FileReportInfoDeadAInjured.AgeDeadToStr, font, XBrushes.Black, new XPoint(50, 110));
            // Сохраняем
            pdfDocument.Save("Отчет_Ид№" + SelectedFileRep.Id.ToString() + ".pdf");
        }
        #endregion
    }
}
