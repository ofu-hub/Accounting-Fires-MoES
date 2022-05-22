using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataGenInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static GenInfo? GetGenInfoById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                GenInfo? geninfo = db.GenInfos.FirstOrDefault(x => x.Id == id);

                if (geninfo == null)
                    return null;
                else
                    return geninfo;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgCode"></param>
        /// <param name="datefire"></param>
        /// <param name="typesettCode"></param>
        /// <param name="typefiresettCode"></param>
        /// <returns></returns>
        public static string CreateGenInfo(string orgCode, DateTime datefire, string typesettCode, string typefiresettCode)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                var newGenInfo = new GenInfo
                {
                    OrgCode = orgCode,
                    Datefire = DateOnly.Parse(datefire.ToString("d")),
                    TypesettCode = typesettCode,
                    TypefiresettCode = typefiresettCode
                };
                db.GenInfos.Add(newGenInfo);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="genInfo"></param>
        /// <returns></returns>
        public static string DeleteGenInfo(GenInfo genInfo)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                db.GenInfos.Remove(genInfo);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldGenInfo"></param>
        /// <param name="orgCode"></param>
        /// <param name="datefire"></param>
        /// <param name="typesettCode"></param>
        /// <param name="typefiresettCode"></param>
        /// <returns></returns>
        public static string EditGenInfo(GenInfo oldGenInfo, string orgCode, DateTime datefire, string typesettCode, string typefiresettCode)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                GenInfo newGenInfo = db.GenInfos.FirstOrDefault(f => f.Id == oldGenInfo.Id);
                newGenInfo.OrgCode = orgCode;
                newGenInfo.Datefire = DateOnly.Parse(datefire.ToString("d"));
                newGenInfo.TypesettCode = typesettCode;
                newGenInfo.TypefiresettCode = typefiresettCode;
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}
