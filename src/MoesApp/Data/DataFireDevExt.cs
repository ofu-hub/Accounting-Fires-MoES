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
    }
}
