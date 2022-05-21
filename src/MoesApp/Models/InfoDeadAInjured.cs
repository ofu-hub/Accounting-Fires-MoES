using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoesApp.Models
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
        [NotMapped]
        public string? GenderDeadToStr
        {
            get
            {
                return String.Join(" ", GenderDead);
            }
            set => GenderDeadToStr = null;
        }
        [NotMapped]
        public string? SocStatusToStr
        {
            get
            {
                return String.Join(" ", SocStatus);
            }
            set => SocStatusToStr = null;
        }
        [NotMapped]
        public string? EducationDeadToStr
        {
            get
            {
                return String.Join(" ", EducationDead);
            }
            set => EducationDeadToStr = null;
        }
        [NotMapped]
        public string? CauseDeadToStr
        {
            get
            {
                return String.Join(" ", CauseDead);
            }
            set => CauseDeadToStr = null;
        }
        [NotMapped]
        public string? TermsDeadToStr
        {
            get
            {
                return String.Join(" ", TermsDead);
            }
            set => TermsDeadToStr = null;
        }
        [NotMapped]
        public string? MomentDeadToStr
        {
            get
            {
                return String.Join(" ", MomentDead);
            }
            set => MomentDeadToStr = null;
        }
        [NotMapped]
        public string? TermsInjuryToStr
        {
            get
            {
                return String.Join(" ", TermsInjury);
            }
            set => TermsInjuryToStr = null;
        }
        [NotMapped]
        public string? HarmHealthToStr
        {
            get
            {
                return String.Join(" ", HarmHealth);
            }
            set => HarmHealthToStr = null;
        }
        [NotMapped]
        public string? AgeDeadToStr
        {
            get
            {
                return String.Join(" ", AgeDead);
            }
            set => AgeDeadToStr = null;
        }
    }
}
