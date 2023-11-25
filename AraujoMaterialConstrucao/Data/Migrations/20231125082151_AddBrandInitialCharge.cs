using AraujoMaterialConstrucao.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AraujoMaterialConstrucao.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandInitialCharge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new MaterialConstructionDbContext();
            context.Brand.AddRange(GetInitialCharge());
            context.SaveChanges();
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

        private IList<Brand> GetInitialCharge()
        {
            return new List<Brand>() 
            {
                new Brand() { Description = "Porcelanosa"},
                new Brand() { Description = "Johnson Tiles"},
                new Brand() { Description = "Daltile"},
                new Brand() { Description = "Ceramiche Piemme"},
                new Brand() { Description = "Crossville Tile"},
                new Brand() { Description = "Roca Tile"}
            };
        }
    }
}
