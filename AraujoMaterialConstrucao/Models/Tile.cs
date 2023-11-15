using System.ComponentModel.DataAnnotations;

namespace AraujoMaterialConstrucao.Models
{
    public class Tile
    {  
        public int TileId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Image Path")]
        public string ImageUri { get; set; }
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Display(Name = "Express Delivery")]
        public bool ExpressDelivery { get; set; }
        public string FormatExpressDelivery => ExpressDelivery ? "Yes" : "No";

        [Display(Name = "Available In")]
        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
        public DateTime RegistrationDate { get; set; }
    }
}
