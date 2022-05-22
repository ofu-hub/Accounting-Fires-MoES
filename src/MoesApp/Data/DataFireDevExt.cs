using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataFireDevExt
    {
        /// <summary>
        /// Получаем развитие и тушение пожара
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FireDevExt? GetFireDevExtById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                FireDevExt? firedae = db.FireDevExts.FirstOrDefault(x => x.Id == id);

                if (firedae == null)
                    return null;
                else
                    return firedae;
            }
        }
        /// <summary>
        /// Создать развитие и тушение пожара
        /// </summary>
        /// <param name="detectionTime"></param>
        /// <param name="messageTime"></param>
        /// <param name="arrivalTime1st"></param>
        /// <param name="localTime"></param>
        /// <param name="openFireEliTime"></param>
        /// <param name="eliFireTime"></param>
        /// <param name="liquidationDate"></param>
        /// <returns></returns>
        public static string CreateFireDevExt(string detectionTime, string messageTime, string arrivalTime1st,
                                                string localTime, string openFireEliTime, string eliFireTime, DateTime liquidationDate)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                var newFireDevExt = new FireDevExt
                {
                    DetectionTime = TimeOnly.Parse(detectionTime),
                    MessageTime = TimeOnly.Parse(messageTime),
                    ArrivalTime1st = TimeOnly.Parse(arrivalTime1st),
                    LocalTime = TimeOnly.Parse(localTime),
                    OpenFireEliTime = TimeOnly.Parse(openFireEliTime),
                    EliFireTime = TimeOnly.Parse(eliFireTime),
                    LiquidationDate = DateOnly.Parse(liquidationDate.ToString("d"))
                };
                db.FireDevExts.Add(newFireDevExt);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// Удалить развитие и тушение пожара
        /// </summary>
        /// <param name="fireDevExt"></param>
        /// <returns></returns>
        public static string DeleteFireDevExt(FireDevExt fireDevExt)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                db.FireDevExts.Remove(fireDevExt);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// Редактирование развитие и тушение пожара
        /// </summary>
        /// <param name="oldFireDevExt"></param>
        /// <param name="detectionTime"></param>
        /// <param name="messageTime"></param>
        /// <param name="arrivalTime1st"></param>
        /// <param name="localTime"></param>
        /// <param name="openFireEliTime"></param>
        /// <param name="eliFireTime"></param>
        /// <param name="liquidationDate"></param>
        /// <returns></returns>
        public static string EditFireDevExt(FireDevExt oldFireDevExt, string detectionTime, string messageTime, string arrivalTime1st,
                                                string localTime, string openFireEliTime, string eliFireTime, DateTime liquidationDate)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                FireDevExt newFireDevExt = db.FireDevExts.FirstOrDefault(f => f.Id == oldFireDevExt.Id);
                newFireDevExt.DetectionTime = TimeOnly.Parse(detectionTime);
                newFireDevExt.MessageTime = TimeOnly.Parse(messageTime);
                newFireDevExt.ArrivalTime1st = TimeOnly.Parse(arrivalTime1st);
                newFireDevExt.LocalTime = TimeOnly.Parse(localTime);
                newFireDevExt.OpenFireEliTime = TimeOnly.Parse(openFireEliTime);
                newFireDevExt.EliFireTime = TimeOnly.Parse(eliFireTime);
                newFireDevExt.LiquidationDate = DateOnly.Parse(liquidationDate.ToString("d"));
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}
