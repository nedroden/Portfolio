using System;
using Microsoft.AspNetCore.Components;
using RobertMonden.Website.Models.Enums;

namespace RobertMonden.Website.Components.Education
{
    public partial class Skill : ComponentBase
    {
        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public SkillLevel Level { get; set; }

        public string LevelText
        {
            get
            {
                return Level switch
                {
                    SkillLevel.Basic => "Basic",
                    SkillLevel.Intermediate => "Intermediate",
                    SkillLevel.Advanced => "Advanced",
                    _ => throw new ArgumentOutOfRangeException("Unknown skill level")
                };
            }
        }

        public string LevelColor
        {
            get
            {
                return Level switch
                {
                    SkillLevel.Basic => "light text-dark",
                    SkillLevel.Intermediate => "secondary",
                    SkillLevel.Advanced => "primary",
                    _ => throw new ArgumentOutOfRangeException("Unknown skill level")
                };
            }
        }
    }
}
