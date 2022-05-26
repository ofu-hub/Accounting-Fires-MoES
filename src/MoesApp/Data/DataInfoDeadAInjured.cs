using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;


namespace MoesApp.Data
{
    internal static class DataInfoDeadAInjured
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static InfoDeadAInjured? GetInfoDeadAInjuredById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                InfoDeadAInjured? info = db.InfoDeadAInjureds.FirstOrDefault(x => x.Id == id);

                if (info == null)
                    return null;
                else
                    return info;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="genderDead"></param>
        /// <param name="socStatus"></param>
        /// <param name="educationDead"></param>
        /// <param name="causeDead"></param>
        /// <param name="termsDead"></param>
        /// <param name="momentDead"></param>
        /// <param name="termsInjury"></param>
        /// <param name="harmHealth"></param>
        /// <param name="ageDead"></param>
        /// <returns></returns>
        public static InfoDeadAInjured CreateInfoDeadAInjured(string genderDead, string socStatus, string educationDead, string causeDead,
                                                    string termsDead, string momentDead, string termsInjury, string harmHealth, string ageDead)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var newInfoDeadAInjured = new InfoDeadAInjured
                {
                    GenderDead = genderDead.Split(','),
                    SocStatus = socStatus.Split(','),
                    EducationDead = educationDead.Split(','),
                    CauseDead = causeDead.Split(','),
                    TermsDead = termsDead.Split(','),
                    MomentDead = momentDead.Split(','),
                    TermsInjury = termsDead.Split(','),
                    HarmHealth = harmHealth.Split(','),
                    AgeDead = ageDead.Split(','),
                };
                db.InfoDeadAInjureds.Add(newInfoDeadAInjured);
                db.SaveChanges();
                return newInfoDeadAInjured;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infoDeadAInjured"></param>
        /// <returns></returns>
        public static string DeleteInfoDeadAInjured(InfoDeadAInjured infoDeadAInjured)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                db.InfoDeadAInjureds.Remove(infoDeadAInjured);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldInfoDeadAInjured"></param>
        /// <param name="genderDead"></param>
        /// <param name="socStatus"></param>
        /// <param name="educationDead"></param>
        /// <param name="causeDead"></param>
        /// <param name="termsDead"></param>
        /// <param name="momentDead"></param>
        /// <param name="termsInjury"></param>
        /// <param name="harmHealth"></param>
        /// <param name="ageDead"></param>
        /// <returns></returns>
        public static string EditInfoDeadAInjured(InfoDeadAInjured oldInfoDeadAInjured, string genderDead, string socStatus, string educationDead,
                                                    string causeDead, string termsDead, string momentDead, string termsInjury, string harmHealth, string ageDead)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                InfoDeadAInjured newInfoDeadAInjured = db.InfoDeadAInjureds.FirstOrDefault(f => f.Id == oldInfoDeadAInjured.Id);
                newInfoDeadAInjured.GenderDead = genderDead.Split(',');
                newInfoDeadAInjured.SocStatus = socStatus.Split(',');
                newInfoDeadAInjured.EducationDead = educationDead.Split(',');
                newInfoDeadAInjured.CauseDead = causeDead.Split(',');
                newInfoDeadAInjured.TermsDead = termsDead.Split(',');
                newInfoDeadAInjured.MomentDead = momentDead.Split(',');
                newInfoDeadAInjured.TermsInjury = termsDead.Split(',');
                newInfoDeadAInjured.HarmHealth = harmHealth.Split(',');
                newInfoDeadAInjured.AgeDead = ageDead.Split(',');
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}
