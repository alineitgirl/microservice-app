namespace PlatformService.Dtos;
using System.ComponentModel.DataAnnotations;

public class PlatformCreateDto
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Publisher { get; set; }

    [Required]
    [MaxLength(100)]
    public string Cost { get; set; }
}