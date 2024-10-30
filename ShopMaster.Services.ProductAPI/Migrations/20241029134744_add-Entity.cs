using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMaster.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class addEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.cdiscount.com/pdt2/7/0/4/1/700x700/tra1699540317704/rw/clavier-mecanique-sans-fil-65-bluetooth-5-0-2-4gh.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://borgiphones.com/wp-content/uploads/2024/05/clavier-mecanique-retroeclaire-rgb-spirit-of-gamer-xpert-k700-1.png");
        }
    }
}
