using System.ComponentModel.DataAnnotations;

public class Book {
    [Required]
    public int Id {get; set;}

    [Required]
    [StringLength(100)]
    public string? Title {get; set;}
    [Required]
    [StringLength(50)]
    public string? Author {get; set;}
    public bool IsAvailable {get; set;} = true;
}