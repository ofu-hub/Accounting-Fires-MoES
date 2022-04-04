using System;
using System.Collections.Generic;

namespace WpfApp1.Models
{
    public partial class FireForcesMean
    {
        public FireForcesMean()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public string[] Firefighters { get; set; } = null!;
        public string[] Technique { get; set; } = null!;
        public string[] NumTechnique { get; set; } = null!;
        public string[] IndividProtect { get; set; } = null!;
        public string[] WaterOnFire { get; set; } = null!;
        public string[] FireExtManager { get; set; } = null!;
        public string[] FireFightingHead { get; set; } = null!;
        public string InvestigativeTeam { get; set; } = null!;
        public string[] FireExtAgents { get; set; } = null!;
        public string[] PrimaryFireEquip { get; set; } = null!;

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
