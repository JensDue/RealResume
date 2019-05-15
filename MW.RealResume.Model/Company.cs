using MW.RealResume.Model.Base;

namespace MW.RealResume.Model
{
    public class Company : NamedItem
    {
        public string Industry { get; set; } //Todo: Implement as Enum
        public string Headquarters { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
    }
}