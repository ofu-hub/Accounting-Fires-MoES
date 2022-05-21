using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoesApp.Models
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
        [NotMapped]
        public string? FirefightersToStr
        {
            get
            {
                return String.Join(" ", Firefighters);
            }
            set => FirefightersToStr = null;
        }
        [NotMapped]
        public string? TechniqueToStr
        {
            get
            {
                return String.Join(" ", Technique);
            }
            set => TechniqueToStr = null;
        }
        [NotMapped]
        public string? NumTechniqueToStr
        {
            get
            {
                return String.Join(" ", NumTechnique);
            }
            set => NumTechniqueToStr = null;
        }
        [NotMapped]
        public string? IndividProtectToStr
        {
            get
            {
                return String.Join(" ", IndividProtect);
            }
            set => IndividProtectToStr = null;
        }
        [NotMapped]
        public string? WaterOnFireToStr
        {
            get
            {
                return String.Join(" ", WaterOnFire);
            }
            set
            {
                WaterOnFireToStr = null;
            }
        }
        [NotMapped]
        public string? FireExtManagerToStr
        {
            get
            {
                return String.Join(" ", FireExtManager);
            }
            set
            {
                FireExtManagerToStr = null;
            }
        }
        [NotMapped]
        public string? FireFightingHeadToStr
        {
            get
            {
                return String.Join(" ", FireFightingHead);
            }
            set
            {
                FireFightingHeadToStr = null;
            }
        }
        [NotMapped]
        public string? FireExtAgentsToStr
        {
            get
            {
                return String.Join(" ", FireExtAgents);
            }
            set
            {
                FireExtAgentsToStr = null;
            }
        }
        [NotMapped]
        public string? PrimaryFireEquipToStr
        {
            get
            {
                return String.Join(" ", PrimaryFireEquip);
            }
            set
            {
                PrimaryFireEquipToStr = null;
            }
        }
    }
}
