using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AraujoMaterialConstrucao.Models;

public class Tile
{
    [Key]
    public int TileId { get; set; }

    [Display(Name = "Product Name")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Field 'Name' Mandatory")]
    [StringLength(70, MinimumLength = 6, ErrorMessage = "Name field must contain at least 6 characters")]
    public string Name { get; set; }

    public string NameSlug => Name.ToLower().Replace(" ", "-");

    [Display(Name = "Description")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Field 'Description' Mandatory")]
		[StringLength(175, MinimumLength = 25, ErrorMessage = "Description field must contain at least 25 characters")]
		public string Description { get; set; }

    [Display(Name = "Image Path")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Field 'Image' Mandatory")]
		public string ImageUri { get; set; }

    [Display(Name = "Price")]
    [DataType(DataType.Currency)]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Field 'Price' Mandatory")]
		public double Price { get; set; }

    [Display(Name = "Express Delivery")]
		public bool ExpressDelivery { get; set; }
    public string FormatExpressDelivery => ExpressDelivery ? "Yes" : "No";

    [Display(Name = "Available In")]
    [DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Field 'Available In' Mandatory")]
    [DataType("month")]
		public DateTime RegistrationDate { get; set; }
}
