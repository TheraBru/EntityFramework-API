using System.ComponentModel.DataAnnotations;

namespace moment33.Models;

// Class for song
public class Song{
    public int SongId { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Artist { get; set; }

    [Required]
    public int Length { get; set; }

    [Required]
    public string? Genre { get; set; }
}