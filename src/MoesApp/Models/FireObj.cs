using System;
using System.Collections.Generic;

namespace WpfApp1.Models
{
    public partial class FireObj
    {
        public FireObj()
        {
            FileReports = new HashSet<FileReport>();
        }

        public int Id { get; set; }
        public string Subject { get; set; } = null!;
        public string SubTypeOwner { get; set; } = null!;
        public string ObjRisk { get; set; } = null!;
        public string KindFireObj { get; set; } = null!;
        public string NameFireObj { get; set; } = null!;
        public string FloorsObj { get; set; } = null!;
        public string FloorWhereFire { get; set; } = null!;
        public string LocationFire { get; set; } = null!;
        public string CauseFire { get; set; } = null!;
        public string GuiltyPerson { get; set; } = null!;
        public string AttitudePerson { get; set; } = null!;
        public string StatePerson { get; set; } = null!;

        public virtual ICollection<FileReport> FileReports { get; set; }
    }
}
