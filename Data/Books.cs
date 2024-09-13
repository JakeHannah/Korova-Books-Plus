using System.ComponentModel.DataAnnotations;

namespace Library.Data
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string? Cover { get; set; }
        public string? Color { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public string? Genre { get; set; }
        public bool Availability { get; set; }
    }

}
