using System.Collections.Generic;
using MW.RealResume.Model.Base;

namespace MW.RealResume.Model
{
    public class Resume: NamedItem
    {
        public string Email { get; set; }
        public  List<Company> Companies { get; set; }
        public  List<Education> Educations { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
