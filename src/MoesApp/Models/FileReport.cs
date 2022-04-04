using System;
using System.Collections.Generic;

namespace WpfApp1.Models
{
    public partial class FileReport
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int GeninfoId { get; set; }
        public int FireobjId { get; set; }
        public int FireconsId { get; set; }
        public int FirerescuedId { get; set; }
        public int FiredaeId { get; set; }
        public int FireforcId { get; set; }
        public int InfodaiId { get; set; }

        public virtual FireConsequence Firecons { get; set; } = null!;
        public virtual FireDevExt Firedae { get; set; } = null!;
        public virtual FireForcesMean Fireforc { get; set; } = null!;
        public virtual FireObj Fireobj { get; set; } = null!;
        public virtual FireRescued Firerescued { get; set; } = null!;
        public virtual GenInfo Geninfo { get; set; } = null!;
        public virtual InfoDeadAInjured Infodai { get; set; } = null!;
    }
}
