using System;
using System.Collections.Generic;

namespace WpfApp1.Models
{
    public partial class InfoDeadAInjured
    {
        public InfoDeadAInjured()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public string[] GenderDead { get; set; } = null!;
        public string[] SocStatus { get; set; } = null!;
        public string[] EducationDead { get; set; } = null!;
        public string[] CauseDead { get; set; } = null!;
        public string[] TermsDead { get; set; } = null!;
        public string[] MomentDead { get; set; } = null!;
        public string[] TermsInjury { get; set; } = null!;
        public string[] HarmHealth { get; set; } = null!;
        public string[] AgeDead { get; set; } = null!;

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
