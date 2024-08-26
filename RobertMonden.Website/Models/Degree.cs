using System.Collections.Generic;

namespace RobertMonden.Website.Models
{
    public record Degree
    {
        public string Label { get; set; }
        public string Institute { get; set; }
        public List<Year> Years { get; set; } = new List<Year>();
    }
}