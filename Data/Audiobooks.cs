using System.ComponentModel.DataAnnotations;

namespace Library.Data
{
    public class Audiobooks
    {
        [Key]
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public string? Duration { get; set; }
        public string? Cover { get; set; }
    }
}
