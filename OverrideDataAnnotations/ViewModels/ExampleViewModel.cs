using OverrideDataAnnotations.Resources;
using System.ComponentModel.DataAnnotations;

namespace OverrideDataAnnotations.ViewModels;

public class ExampleViewModel
{
    [Display(Name = "FirstName", ResourceType = typeof(PlaygroundResource))]
    [MaxLength(50)]
    [Required]
    public string FirstName { get; set; }

    [Display(Name = "LastName", ResourceType = typeof(PlaygroundResource))]
    [MaxLength(50)]
    [Required]
    public string LastName { get; set; }

    [Display(Name = "EmailAddress", ResourceType = typeof(PlaygroundResource))]
    [DataType(DataType.EmailAddress)]
    [MaxLength(320)]
    [Required]
    public string Email { get; set; }

    [Display(Name = "PhoneNumber", ResourceType = typeof(PlaygroundResource))]
    [DataType(DataType.PhoneNumber)]
    [MaxLength(15)]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Age", ResourceType = typeof(PlaygroundResource))]
    [Range(0, 255)]
    [Required]
    public byte Age { get; set; }
}
