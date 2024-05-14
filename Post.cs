using System.ComponentModel.DataAnnotations;

namespace TheSocializingNetwork.Models;

public class Post
{
    [Required]
    public Guid PostId { get; set; }
    [Required, MinLength(1), MaxLength(100)]
    public string? Content { get; set; }
    [Required]
    [DataType(DataType.DateTime, ErrorMessage = "Timestamp must be a valid Date Time.")]
    public DateTime Timestamp { get; set; }
    
   
    public Guid UserId { get; set; }
    public User user { get; set; }
}