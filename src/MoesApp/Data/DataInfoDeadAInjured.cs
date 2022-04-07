using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoesApp.Models;
using MoesApp.Data.Base;


namespace MoesApp.Data
{
    internal static class DataInfoDeadAInjured
    {
        public static InfoDeadAInjured? GetInfoDeadAInjuredById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                InfoDeadAInjured? info = db.InfoDeadAInjureds.FirstOrDefault(x => x.Id == id);

                if (info == null)
                    return null;
                else
                    return info;
            }
        }
    }
}
