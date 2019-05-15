using System;
using MW.RealResume.Model.Base;

namespace MW.RealResume.Model
{
    public class Education : NamedItem
    {
        public string School { get; set; }
        public string Degree { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
