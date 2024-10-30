using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopMaster.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Périphérique", "Clavier mécanique avec rétroéclairage RGB personnalisable, idéal pour le gaming et la bureautique. Conception robuste et touches programmables.", "https://placehold.co/603x403", "Clavier Mécanique RGB", 89.989999999999995 },
                    { 2, "Périphérique", "Souris ergonomique avec 7 boutons programmables, capteur haute précision, idéale pour les joueurs professionnels.", "https://placehold.co/602x402", "Souris Gamer 7 Boutons", 49.990000000000002 },
                    { 3, "Affichage", "Écran LED de 24 pouces avec résolution Full HD, offrant des couleurs éclatantes et des angles de vision larges pour un usage polyvalent.", "https://placehold.co/601x401", "Écran LED Full HD 24\"", 159.99000000000001 },
                    { 4, "Ordinateur", "Ordinateur portable équipé d'un processeur Intel i5, 8 Go de RAM, et un SSD de 256 Go pour une performance optimale dans toutes les tâches.", "https://placehold.co/600x400", "Ordinateur Portable i5", 699.99000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
