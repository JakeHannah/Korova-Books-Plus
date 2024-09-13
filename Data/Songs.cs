using System.ComponentModel.DataAnnotations;

namespace Library.Data
{
    public class Songs
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Album { get; set; }
        public string? Artist { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public string? Duration { get; set; }
        public string? Cover { get; set; }
    }
}
