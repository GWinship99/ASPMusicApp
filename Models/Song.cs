using System.ComponentModel.DataAnnotations;

namespace ASPMusicApp.Models
{
    public class Song
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Artist { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        [Required]
        public string? Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(10)]
        [Required]
        public string Rating { get; set; } = string.Empty;
    }
}
