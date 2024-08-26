namespace RobertMonden.Website.Models
{
    public record MenuItem
    {
        public long Id { get; set; }

        public string Label { get; set; }

        public string Href { get; set; }

        public string Icon { get; set; }

        public short Position { get; set; }

        public bool Visible { get; set; }
    }
}
