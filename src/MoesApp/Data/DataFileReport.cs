using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataFileReport
    {
        /// <summary>
        /// Получает список отчетов
        /// </summary>
        /// <returns>Список отчетов</returns>
        public static ObservableCollection<FileReport> GetAllFileReports()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var result = new ObservableCollection<FileReport>(db.FileReports.ToList());
                return result;
            }
        }
        /// <summary>
        /// Создает новый отчет
        /// </summary>
        /// <param name="name">Заголовок отчета</param>
        /// <returns>Результат</returns>
        public static string CreateFileReport(string name, GenInfo genInfo, FireObj fireObj, FireConsequence fireConsequence, FireRescued fireRescued, FireDevExt fireDevExt, FireForcesMean fireForcesMean, InfoDeadAInjured infoDeadAInjured)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                var newFileReport = new FileReport { 
                    Title = name,
                    GeninfoId = genInfo.Id,
                    FireobjId = fireObj.Id,
                    FireconsId = fireConsequence.Id,
                    FirerescuedId = fireRescued.Id,
                    FiredaeId = fireDevExt.Id,
                    FireforcId = fireForcesMean.Id,
                    InfodaiId = infoDeadAInjured.Id,
                };
                db.FileReports.Add(newFileReport);
                db.SaveChanges();
                result = "Отчет успешно создан!";
            }
            return result;
        }
        /// <summary>
        /// Удаление отчета
        /// </summary>
        /// <param name="fileReport">Отчет</param>
        /// <returns>Результат</returns>
        public static string DeleteFileReport(FileReport fileReport)
        {
            string result = "Ошибка!"; 
            using (DataBaseContext db = new DataBaseContext())
            {
                db.FileReports.Remove(fileReport);
                db.SaveChanges();
                result = "Отчет №" + fileReport.Id + ", успешно удалён!";
            }
            return result;
        }
        /// <summary>
        /// Редактирование отчета
        /// </summary>
        /// <param name="oldFileReport">Отчет, который редактируем</param>
        /// <param name="name">Новый заголовок</param>
        /// <param name="genInfo">Новая информация</param>
        /// <param name="fireObj">Новая информация</param>
        /// <param name="fireConsequence">Новая информация</param>
        /// <param name="fireRescued">Новая информация</param>
        /// <param name="fireDevExt">Новая информация</param>
        /// <param name="fireForcesMean">Новая информация</param>
        /// <param name="infoDeadAInjured">Новая информация</param>
        /// <returns>Результат</returns>
        public static string EditFileReport(FileReport oldFileReport, string name, GenInfo genInfo, FireObj fireObj, FireConsequence fireConsequence, FireRescued fireRescued, FireDevExt fireDevExt, FireForcesMean fireForcesMean, InfoDeadAInjured infoDeadAInjured)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                FileReport newFileReport = db.FileReports.FirstOrDefault(f => f.Id == oldFileReport.Id);
                newFileReport.Title = name;
                newFileReport.GeninfoId = genInfo.Id;
                newFileReport.FireobjId = fireObj.Id;
                newFileReport.FireconsId = fireConsequence.Id;
                newFileReport.FirerescuedId = fireRescued.Id;
                newFileReport.FiredaeId = fireDevExt.Id;
                newFileReport.FireforcId = fireForcesMean.Id;
                newFileReport.InfodaiId = infoDeadAInjured.Id;
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}