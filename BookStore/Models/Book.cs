using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        //Title, Author, Price, Genre
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Aurthor name is required")]
        [StringLength(100, ErrorMessage = "Aurthor name cannot be longer than 100 characters.")]
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

    }
}
