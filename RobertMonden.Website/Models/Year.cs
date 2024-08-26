using System.Collections.Generic;

namespace RobertMonden.Website.Models
{
    public record Year
    {
        public int StartingYear { get; set; }
        public List<Semester> Semesters { get; set; } = new List<Semester>();
    }
}