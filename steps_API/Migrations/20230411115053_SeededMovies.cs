using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace steps_API.Migrations
{
    /// <inheritdoc />
    public partial class SeededMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Rating", "isFavorite" },
                values: new object[,]
                {
                    { 1, "Journey to the new Home", "https://w7.pngwing.com/pngs/871/688/png-transparent-passengers-assassin-s-creed-michael-fassbender-film-blu-ray-disc-chris-pratt-celebrities-film-michael-fassbender-thumbnail.png", "Passengers", "4.9", true },
                    { 2, "Find a way to live", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfdJURHn9A-EtlfLlRMXu2x-rSd8rsqqgGLaOacH43&s", "Interstellar", "3.8", true },
                    { 3, "Psycology", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcToDLALDCFh1VRbnHmsGHK12L85Acth6b1pSugviiY&s", "Shutter Island", "3.4", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
