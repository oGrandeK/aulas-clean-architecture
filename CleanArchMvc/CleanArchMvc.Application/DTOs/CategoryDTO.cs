using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.Application.DTOs;

public class CategoryDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The name is required")]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }
}
