using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Nintendo GameCube platform fighting game.", "https://upload.wikimedia.org/wikipedia/en/7/75/Super_Smash_Bros_Melee_box_art.png", 9.99m, "Super Smash Brothers: Melee" },
                    { 2, "First 3D open world RPG-style MegaMan Game on PS1 and N64", "https://upload.wikimedia.org/wikipedia/en/3/33/Rockman_DASH_re-release_cover_art.jpg", 8.99m, "MegaMan Legends" },
                    { 3, "Top-down JRPG where Solar Boy Django takes on Immortal Vampires", "https://upload.wikimedia.org/wikipedia/en/f/f0/Boktai_cover_art.jpg", 7.99m, "Boktai: The Sun Is in Your Hand!" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
