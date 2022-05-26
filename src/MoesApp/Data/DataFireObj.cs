using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataFireObj
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FireObj? GetFireObjById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                FireObj? fireobj = db.FireObjs.FirstOrDefault(x => x.Id == id);

                if (fireobj == null)
                    return null;
                else
                    return fireobj;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="subTypeOwner"></param>
        /// <param name="objRisk"></param>
        /// <param name="kindFireObj"></param>
        /// <param name="nameFireObj"></param>
        /// <param name="floorsObj"></param>
        /// <param name="floorWhereFire"></param>
        /// <param name="locationFire"></param>
        /// <param name="causeFire"></param>
        /// <param name="guiltyPerson"></param>
        /// <param name="attitudePerson"></param>
        /// <param name="statePerson"></param>
        /// <returns></returns>
        public static FireObj CreateFireObj(string subject, string subTypeOwner, string objRisk, string kindFireObj,
                                            string nameFireObj, string floorsObj, string floorWhereFire, string locationFire,
                                            string causeFire, string guiltyPerson, string attitudePerson, string statePerson)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                var newFireObj = new FireObj
                {
                    Subject = subject,
                    SubTypeOwner = subTypeOwner,
                    ObjRisk = objRisk,
                    KindFireObj = kindFireObj,
                    NameFireObj = nameFireObj,
                    FloorsObj = floorsObj,
                    FloorWhereFire = floorWhereFire,
                    LocationFire = locationFire,
                    CauseFire = causeFire,
                    GuiltyPerson = guiltyPerson,
                    AttitudePerson = attitudePerson,
                    StatePerson = statePerson
                };
                db.FireObjs.Add(newFireObj);
                db.SaveChanges();
                return newFireObj;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fireObj"></param>
        /// <returns></returns>
        public static string DeleteFireObj(FireObj fireObj)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                db.FireObjs.Remove(fireObj);
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldFireObj"></param>
        /// <param name="subject"></param>
        /// <param name="subTypeOwner"></param>
        /// <param name="objRisk"></param>
        /// <param name="kindFireObj"></param>
        /// <param name="nameFireObj"></param>
        /// <param name="floorsObj"></param>
        /// <param name="floorWhereFire"></param>
        /// <param name="locationFire"></param>
        /// <param name="causeFire"></param>
        /// <param name="guiltyPerson"></param>
        /// <param name="attitudePerson"></param>
        /// <param name="statePerson"></param>
        /// <returns></returns>
        public static string EditFireObj(FireObj oldFireObj, string subject, string subTypeOwner, string objRisk, string kindFireObj,
                                            string nameFireObj, string floorsObj, string floorWhereFire, string locationFire,
                                            string causeFire, string guiltyPerson, string attitudePerson, string statePerson)
        {
            string result = "Ошибка!";
            using (DataBaseContext db = new DataBaseContext())
            {
                FireObj newFireObj = db.FireObjs.FirstOrDefault(f => f.Id == oldFireObj.Id);
                newFireObj.Subject = subject;
                newFireObj.SubTypeOwner = subTypeOwner;
                newFireObj.ObjRisk = objRisk;
                newFireObj.KindFireObj = kindFireObj;
                newFireObj.NameFireObj = nameFireObj;
                newFireObj.FloorsObj = floorsObj;
                newFireObj.FloorWhereFire = floorWhereFire;
                newFireObj.LocationFire = locationFire;
                newFireObj.CauseFire = causeFire;
                newFireObj.GuiltyPerson = guiltyPerson;
                newFireObj.AttitudePerson = attitudePerson;
                newFireObj.StatePerson = statePerson;
                db.SaveChanges();
                result = "Ок!";
            }
            return result;
        }
    }
}
