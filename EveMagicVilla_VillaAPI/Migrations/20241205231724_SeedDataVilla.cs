using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EveMagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Anemity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5183), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa3.jpg", "Royal Villa", 4, 200.0, 550, new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5235) },
                    { 2, "", new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5238), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa1.jpg", "Premium Pool Villa", 4, 300.0, 550, new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5239) },
                    { 3, "", new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5241), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa4.jpg", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5242) },
                    { 4, "", new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5244), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa5.jpg", "Diamond Villa", 4, 550.0, 900, new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5245) },
                    { 5, "", new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5247), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmastery.com/bluevillaimages/villa2.jpg", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(2024, 12, 5, 18, 17, 24, 219, DateTimeKind.Local).AddTicks(5248) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
