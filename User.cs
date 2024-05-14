using System.ComponentModel.DataAnnotations;

namespace TheSocializingNetwork.Models;

public class User
{
    [Key]
    [Required]
    public Guid UserId { get; set; }
    [Required, MinLength(2), MaxLength(20)]
    public string? FirstName { get; set; }
    [Required, MinLength(2), MaxLength(20)]
    public string? LastName { get; set; }
    [Required, MinLength(2), MaxLength(50)]
    public string? Username { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public DateOnly BirthDate { get; set; }
    
    //Navigation Purposes
    public List<Post> Posts { get; set; }
    public List<User> Friends { get; set; }
    public Profile UserProfile { get; set; }
}