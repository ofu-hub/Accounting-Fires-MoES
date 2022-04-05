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
    }
}
