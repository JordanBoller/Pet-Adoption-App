using System.ComponentModel.DataAnnotations;

namespace midterm_project.Models;

public class Pet
{
    public int PetId { get; set; }
    [Required]
    [Display(Name = "Pet Name")]
    public string? PetName { get; set; }
    [Url]
    [Display(Name = "Pet Img URL")]
    public string? ImgUrl { get; set; }
    [Required]
    [Display(Name = "Pet Description")]
    public string? PetDescription { get; set; }

}