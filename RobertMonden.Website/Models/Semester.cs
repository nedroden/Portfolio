using System;
using System.Collections.Generic;
using System.Linq;

namespace RobertMonden.Website.Models
{
    public record Semester
    {
        public string Description { get; set; }

        private List<Term> _terms = new List<Term>();
        public List<Term> Terms
        {
            get => _terms;
            set
            {
                if (Courses.Any() && value.Any())
                {
                    throw new Exception("Cannot add terms to semester that already has courses.");
                }

                _terms = value;
            }
        }

        private List<Course> _courses = new List<Course>();
        public List<Course> Courses
        {
            get => _courses;
            set
            {
                if (Terms.Any() && value.Any())
                {
                    throw new Exception("Cannot add courses to a semester that is divided into terms.");
                }

                _courses = value;
            }
        }
    }
}