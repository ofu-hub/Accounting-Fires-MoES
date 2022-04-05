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
    }
}
