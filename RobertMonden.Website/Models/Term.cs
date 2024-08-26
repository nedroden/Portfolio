using System.Collections.Generic;

namespace RobertMonden.Website.Models
{
    public record Term
    {
        public string Label { get; set; }
        public string Description { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}