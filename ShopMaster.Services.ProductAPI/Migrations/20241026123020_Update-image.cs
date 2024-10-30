using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMaster.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class Updateimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://borgiphones.com/wp-content/uploads/2024/05/clavier-mecanique-retroeclaire-rgb-spirit-of-gamer-xpert-k700-1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.alarabia.com.tn/19082-large_default/souris-filaire-gamer-spirit-s-pm7-rgb-7-boutons.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://mk-media.mytek.tn/media/catalog/product/cache/8be3f98b14227a82112b46963246dfe1/e/c/ecran-samsung-lf24t350fhmxzn-24-full-hd-75hz.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://mtsplus.tn/2607-large_default/pc-portable-asus-i5-11e-gen-8go-512go-ssd-mx330-x515ep-br245t.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://placehold.co/603x403");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://placehold.co/602x402");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://placehold.co/601x401");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://placehold.co/600x400");
        }
    }
}
