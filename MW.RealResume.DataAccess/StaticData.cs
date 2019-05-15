using System;
using System.Collections.Generic;
using MW.RealResume.Model;

namespace MW.RealResume.DataAccess
{
    public class StaticData
    {
        public List<Skill> Skills { get; set; }  //Todo: Implement as Enum

        public StaticData()
        {
            Skills = new List<Skill>
            {
                new Skill
                {
                    Id = 0,
                    Name = "Software Development",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 02),
                    Level = "High"
                },

                new Skill
                {
                    Id = 1,
                    Name = "Retrospective Facilitator",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 05),
                    Level = "Not so high"
                },

                new Skill
                {
                    Id = 2,
                    Name = "Baking and eating cake",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 07),
                    Level = "Expert"
                }
            };

        }
    }
}
