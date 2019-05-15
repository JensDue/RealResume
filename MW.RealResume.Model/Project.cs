using System;
using MW.RealResume.Model.Base;

namespace MW.RealResume.Model
{
    public class Project : NamedItem
    {
        //Todo: create reference to company
        //Company Company { get; set; } 
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}