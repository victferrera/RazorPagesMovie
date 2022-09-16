using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [DataType(DataType.Text)]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Text)]
        public string Genre { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
