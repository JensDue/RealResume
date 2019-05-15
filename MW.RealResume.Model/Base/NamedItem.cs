using System;

namespace MW.RealResume.Model.Base
{
    public abstract class NamedItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }
    }
}