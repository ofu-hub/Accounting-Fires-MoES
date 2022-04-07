using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MoesApp.Models;
using MoesApp.Data.Base;

namespace MoesApp.Data
{
    internal static class DataFileReport
    {
        public static ObservableCollection<FileReport> GetAllFileReports()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var result = new ObservableCollection<FileReport>(db.FileReports.ToList());
                return result;
            }
        }
    }
}