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
    }
}
