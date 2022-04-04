using System;
using System.Collections.Generic;

namespace WpfApp1.Models
{
    public partial class FireDevExt
    {
        public FireDevExt()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public string DetectionTime { get; set; } = null!;
        public string MessageTime { get; set; } = null!;
        public string ArrivalTime1st { get; set; } = null!;
        public string LocalTime { get; set; } = null!;
        public string OpenFireEliTime { get; set; } = null!;
        public string EliFireTime { get; set; } = null!;
        public DateOnly LiquidationDate { get; set; }

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
