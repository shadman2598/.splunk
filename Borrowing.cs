using System.ComponentModel.DataAnnotations;

public class Borrowing {
    public int Id {get; set;}
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public int BookId {get; set;}
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public int ReaderId {get; set;}
    [Required]
    public DateTime BorrowDate {get; set;}
    [Required]
    public DateTime ReturnDate {get; set;}
}