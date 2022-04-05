using System;
using System.Collections.Generic;

namespace MoesApp.Models
{
    public partial class GenInfo
    {
        public GenInfo()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public string OrgCode { get; set; } = null!;
        public DateOnly Datefire { get; set; }
        public string TypesettCode { get; set; } = null!;
        public string TypefiresettCode { get; set; } = null!;

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
