using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataFireForcesMean
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FireForcesMean? GetFireForcesMeanById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                FireForcesMean? forefm = db.FireForcesMeans.FirstOrDefault(x => x.Id == id);

                if (forefm == null)
                    return null;
                else
                    return forefm;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firefighters"></param>
        /// <param name="technique"></param>
        /// <param name="numTechnique"></param>
        /// <param name="individProtect"></param>
        /// <param name="waterOnFire"></param>
        /// <param name="fireExtManager"></param>
        /// <param name="fireFightingHead"></param>
        /// <param name="investigativeTeam"></param>
        /// <param name="fireExtAgents"></param>
        /// <param name="primaryFireEquip"></param>
        /// <returns></returns>
        public static FireForcesMean CreateFireForcesMean(string firefighters, string technique, string numTechnique, 
                                                    string individProtect, string waterOnFire, string fireExtManager,
                                                    string fireFightingHead, string investigativeTeam, string fireExtAgents, string primaryFireEquip)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var newFireForcesMean = new FireForcesMean
                {
                    Firefighters = firefighters.Split(','),
                    Technique = technique.Split(','),
                    NumTechnique = numTechnique.Split(','),
                    IndividProtect = individProtect.Split(','),
                    WaterOnFire = waterOnFire.Split(','),
                    FireExtManager = fireExtManager.Split(','),
                    FireFightingHead = fireFightingHead.Split(','),
                    InvestigativeTeam = investigativeTeam,
                    FireExtAgents = fireExtAgents.Split(','),
                    PrimaryFireEquip = primaryFireEquip.Split(','),
                };
                db.FireForcesMeans.Add(newFireForcesMean);
                db.SaveChanges();
                return newFireForcesMean;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fireForcesMean"></param>
        /// <returns></returns>
        public static string DeleteFireForcesMean(FireForcesMean fireForcesMean)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                db.FireForcesMeans.Remove(fireForcesMean);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldFireForcesMean"></param>
        /// <param name="firefighters"></param>
        /// <param name="technique"></param>
        /// <param name="numTechnique"></param>
        /// <param name="individProtect"></param>
        /// <param name="waterOnFire"></param>
        /// <param name="fireExtManager"></param>
        /// <param name="fireFightingHead"></param>
        /// <param name="investigativeTeam"></param>
        /// <param name="fireExtAgents"></param>
        /// <param name="primaryFireEquip"></param>
        /// <returns></returns>
        public static string EditFireForcesMean(FireForcesMean oldFireForcesMean, string firefighters, string technique, string numTechnique,
                                                    string individProtect, string waterOnFire, string fireExtManager, string fireFightingHead, 
                                                    string investigativeTeam, string fireExtAgents, string primaryFireEquip)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                FireForcesMean newFireForcesMean = db.FireForcesMeans.FirstOrDefault(f => f.Id == oldFireForcesMean.Id);
                newFireForcesMean.Firefighters = firefighters.Split(',');
                newFireForcesMean.Technique = technique.Split(',');
                newFireForcesMean.NumTechnique = numTechnique.Split(',');
                newFireForcesMean.IndividProtect = individProtect.Split(',');
                newFireForcesMean.WaterOnFire = waterOnFire.Split(',');
                newFireForcesMean.FireExtManager = fireExtManager.Split(',');
                newFireForcesMean.FireFightingHead = fireFightingHead.Split(',');
                newFireForcesMean.InvestigativeTeam = investigativeTeam;
                newFireForcesMean.FireExtAgents = fireExtAgents.Split(',');
                newFireForcesMean.PrimaryFireEquip = primaryFireEquip.Split(',');
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}
