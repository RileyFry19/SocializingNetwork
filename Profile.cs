using System.ComponentModel.DataAnnotations;

namespace TheSocializingNetwork.Models;

public class Profile
{
    [Key]
    [Required]
    public Guid ProfileId { get; set; }
    [Required]
    [RegularExpression(@"^\d+$", ErrorMessage = "UserId must be a valid number.")]
    public Guid UserId { get; set; }
    [Required]
    public string? PictureUrl { get; set; }
    
    public User user { get; set; }
}