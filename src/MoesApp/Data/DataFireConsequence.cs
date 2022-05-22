using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataFireConsequence
    {
        /// <summary>
        /// Получаем последствия пожара
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Последствия пожара</returns>
        public static FireConsequence? GetFireConsequenceById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                FireConsequence? firecons = db.FireConsequences.FirstOrDefault(x => x.Id == id);

                if (firecons == null)
                    return null;
                else
                    return firecons;
            }
        }
        /// <summary>
        /// Создать последствия пожара
        /// </summary>
        /// <param name="peopleDiedAll"></param>
        /// <param name="peopleDiedKids"></param>
        /// <param name="peopleDiedWork"></param>
        /// <param name="peopleInjuredAll"></param>
        /// <param name="peopleInjuredKids"></param>
        /// <param name="peopleInjuredWork"></param>
        /// <param name="mFireDamage"></param>
        /// <param name="buildDest"></param>
        /// <param name="buildDam"></param>
        /// <param name="apartDest"></param>
        /// <param name="apartDam"></param>
        /// <returns>Результат</returns>
        public static string CreateFireConsequence(string peopleDiedAll, string peopleDiedKids, string peopleDiedWork, 
                                                    string peopleInjuredAll, string peopleInjuredKids, string peopleInjuredWork,
                                                    decimal mFireDamage, string buildDest, string buildDam, string apartDest, string apartDam)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                var newFireConsequence = new FireConsequence
                {
                    PeopleDiedAll = peopleDiedAll,
                    PeopleDiedKids = peopleDiedKids,
                    PeopleDiedWork = peopleDiedWork,
                    PeopleInjuredAll = peopleInjuredAll,
                    PeopleInjuredKids = peopleInjuredKids,
                    PeopleInjuredWork = peopleInjuredWork,
                    MFireDamage = mFireDamage,
                    BuildDest = buildDest,
                    BuildDam = buildDam,
                    ApartDest = apartDest,
                    ApartDam = apartDam
                };
                db.FireConsequences.Add(newFireConsequence);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// Удалить последствия пожара
        /// </summary>
        /// <param name="fireConsequence"></param>
        /// <returns>Результат</returns>
        public static string DeleteFireConsequence(FireConsequence fireConsequence)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                db.FireConsequences.Remove(fireConsequence);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// Редактирование последствий пожара
        /// </summary>
        /// <param name="oldFireConsequence"></param>
        /// <param name="peopleDiedAll"></param>
        /// <param name="peopleDiedKids"></param>
        /// <param name="peopleDiedWork"></param>
        /// <param name="peopleInjuredAll"></param>
        /// <param name="peopleInjuredKids"></param>
        /// <param name="peopleInjuredWork"></param>
        /// <param name="mFireDamage"></param>
        /// <param name="buildDest"></param>
        /// <param name="buildDam"></param>
        /// <param name="apartDest"></param>
        /// <param name="apartDam"></param>
        /// <returns>Результат</returns>
        public static string EditFireConsequence(FireConsequence oldFireConsequence, string peopleDiedAll, string peopleDiedKids, string peopleDiedWork,
                                                    string peopleInjuredAll, string peopleInjuredKids, string peopleInjuredWork,
                                                    decimal mFireDamage, string buildDest, string buildDam, string apartDest, string apartDam)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                FireConsequence newFireConsequence = db.FireConsequences.FirstOrDefault(f => f.Id == oldFireConsequence.Id);
                newFireConsequence.PeopleDiedAll = peopleDiedAll;
                newFireConsequence.PeopleDiedKids = peopleDiedKids;
                newFireConsequence.PeopleDiedWork = peopleDiedWork;
                newFireConsequence.PeopleInjuredAll = peopleInjuredAll;
                newFireConsequence.PeopleInjuredKids = peopleInjuredKids;
                newFireConsequence.PeopleInjuredWork = peopleInjuredWork;
                newFireConsequence.MFireDamage = mFireDamage;
                newFireConsequence.BuildDest = buildDest;
                newFireConsequence.BuildDam = buildDam;
                newFireConsequence.ApartDest = apartDest;
                newFireConsequence.ApartDam = apartDam;
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}
