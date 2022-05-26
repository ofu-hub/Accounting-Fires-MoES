using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataFireRescued
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FireRescued? GetFireRescuedById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                FireRescued? fireres = db.FireRescueds.FirstOrDefault(x => x.Id == id);

                if (fireres == null)
                    return null;
                else
                    return fireres;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="peopleSaved"></param>
        /// <param name="peopleEvacuated"></param>
        /// <param name="cattleLarge"></param>
        /// <param name="cattleSmall"></param>
        /// <param name="technique"></param>
        /// <param name="matValues"></param>
        /// <returns></returns>
        public static FireRescued CreateFireRescued(string peopleSaved, string peopleEvacuated, string cattleLarge, 
                                                string cattleSmall, string technique, string matValues)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                var newFireRescued = new FireRescued
                {
                    PeopleSaved = peopleSaved,
                    PeopleEvacuated = peopleEvacuated,
                    CattleLarge = cattleLarge,
                    CattleSmall = cattleSmall,
                    Technique = technique,
                    MatValues = Convert.ToDecimal(matValues)
                };
                db.FireRescueds.Add(newFireRescued);
                db.SaveChanges();
                return newFireRescued;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fireRescued"></param>
        /// <returns></returns>
        public static string DeleteFireRescued(FireRescued fireRescued)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                db.FireRescueds.Remove(fireRescued);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldFireRescued"></param>
        /// <param name="peopleSaved"></param>
        /// <param name="peopleEvacuated"></param>
        /// <param name="cattleLarge"></param>
        /// <param name="cattleSmall"></param>
        /// <param name="technique"></param>
        /// <param name="matValues"></param>
        /// <returns></returns>
        public static string EditFireRescued(FireRescued oldFireRescued, string peopleSaved, string peopleEvacuated, string cattleLarge,
                                                string cattleSmall, string technique, string matValues)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                FireRescued newFireRescued = db.FireRescueds.FirstOrDefault(f => f.Id == oldFireRescued.Id);
                newFireRescued.PeopleSaved = peopleSaved;
                newFireRescued.PeopleEvacuated = peopleEvacuated;
                newFireRescued.CattleLarge = cattleLarge;
                newFireRescued.CattleSmall = cattleSmall;
                newFireRescued.Technique = technique;
                newFireRescued.MatValues = Convert.ToDecimal(matValues);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}
