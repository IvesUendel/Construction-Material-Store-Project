namespace AraujoMaterialConstrucao.Models
{
    public class Tile
    {  
        public int TileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public double Price { get; set; }
        public bool ExpressDelivery { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
