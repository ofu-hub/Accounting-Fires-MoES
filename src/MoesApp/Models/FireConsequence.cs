using System;
using System.Collections.Generic;

namespace WpfApp1.Models
{
    public partial class FireConsequence
    {
        public FireConsequence()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public string PeopleDiedAll { get; set; } = null!;
        public string PeopleDiedKids { get; set; } = null!;
        public string PeopleDiedWork { get; set; } = null!;
        public string PeopleInjuredAll { get; set; } = null!;
        public string PeopleInjuredKids { get; set; } = null!;
        public string PeopleInjuredWork { get; set; } = null!;
        public decimal MFireDamage { get; set; }
        public string BuildDest { get; set; } = null!;
        public string BuildDam { get; set; } = null!;
        public string ApartDest { get; set; } = null!;
        public string ApartDam { get; set; } = null!;

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
