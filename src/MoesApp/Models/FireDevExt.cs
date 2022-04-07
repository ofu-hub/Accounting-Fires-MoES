using System;
using System.Collections.Generic;

namespace MoesApp.Models
{
    public partial class FireDevExt
    {
        public FireDevExt()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public TimeOnly DetectionTime { get; set; }
        public TimeOnly MessageTime { get; set; }
        public TimeOnly ArrivalTime1st { get; set; }
        public TimeOnly LocalTime { get; set; }
        public TimeOnly OpenFireEliTime { get; set; }
        public TimeOnly EliFireTime { get; set; }
        public DateOnly LiquidationDate { get; set; }

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
