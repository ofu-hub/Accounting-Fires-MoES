using System;
using System.Collections.Generic;

namespace MoesApp.Models
{
    public partial class FireRescued
    {
        public FireRescued()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public string PeopleSaved { get; set; } = null!;
        public string PeopleEvacuated { get; set; } = null!;
        public string CattleLarge { get; set; } = null!;
        public string CattleSmall { get; set; } = null!;
        public string Technique { get; set; } = null!;
        public decimal MatValues { get; set; }

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
