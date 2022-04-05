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
    }
}
