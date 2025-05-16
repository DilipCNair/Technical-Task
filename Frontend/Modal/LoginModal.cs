using System.ComponentModel.DataAnnotations;

namespace Frontend.Modal;

public class LoginModal
{
    [Required]
    public string FirmId { get; set; } = string.Empty;

    [Required]
    public string Id { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}
