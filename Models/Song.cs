using System.ComponentModel.DataAnnotations;

namespace ASPMusicApp.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Artist { get; set; }
        public string? Genre { get; set; }
    }
}
