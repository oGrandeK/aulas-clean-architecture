using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Application.DTOs;

public class ProductDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The name is required")]
    [StringLength(100, MinimumLength = 3)]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The description is required")]
    [StringLength(200, MinimumLength = 5)]
    [DisplayName("Description")]
    public string Description { get; set; }

    [Required(ErrorMessage = "The price is required")]
    [Column(TypeName = "decimal(18,2)")]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    [DataType(DataType.Currency)]
    [DisplayName("Price")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "The stock is required")]
    [Range(1, 9999)]
    [DisplayName("Stock")]
    public int Stock { get; set; }

    [StringLength(250)]
    [DisplayName("Product Image")]
    public string Image { get; set; }

    public Category Category { get; set; }

    [DisplayName("Categories")]
    public int CategoryId { get; set; }
}
