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
        public static FireObj? GetFireObjById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                FireObj? geninfo = db.FireObjs.FirstOrDefault(x => x.Id == id);

                if (geninfo == null)
                    return null;
                else
                    return geninfo;
            }
        }
    }
}
