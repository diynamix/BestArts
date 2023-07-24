using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestArts.Data.Migrations
{
    public partial class RemovedProductLengthProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0333c7b1-142a-4de8-82a5-503d99ed347f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c9c62eb-8065-4935-8a02-35ee771ff4e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13320f71-a8ee-4135-99d7-20dadc643686"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d6a1210-2838-4591-9697-3724a6dd86fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("301b6bad-9e4a-4d2f-80b7-a45c22b2909f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("379a015a-eab5-4a90-89b9-de3581cb66a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c548242-64a8-48b1-baae-52d1478ddc0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("452dfae7-8640-44c1-8c41-1fac6925b84c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a8a17c7-1883-4758-a70e-41f4539a706d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("501fe141-eb92-4f3b-82af-d09e5fa3aff6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e7891de-da5e-40d5-a555-95ba813f7e9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a95cb92-cf85-4d5f-b632-1710c2b0065c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8baed613-5d82-4569-991a-234ee2135fd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fe8fe83-5634-44b9-8ced-54db22ab09fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d8e0efe-6d1c-4c87-931a-ae4d9ce6bdd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2f1e3fd-11b5-40a9-a558-b7bded350271"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac8352a4-9d8e-4b8c-8f34-e0595afada7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b89e4b87-0ead-4957-ab65-09512adae909"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbfd9019-08d2-4ac4-ab38-b359cebe8965"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f45cf844-eccc-4e1f-9712-7a7a1ba4a23c"));

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("05049d91-fc1d-439e-94f3-0d0348bf3971"), 1, null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("090bd837-3eaa-4428-b243-5746629a3d28"), 1, null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("0fb5bcd4-148a-44ff-a383-05d2b41b0a7a"), 1, null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("20d96ef8-e683-4ae4-a481-f818d636e0df"), 1, null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("27b44ae7-c324-40ba-a141-eb132458b1d6"), 2, null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("27bc7d0e-8f41-4efa-92d4-6f7d86fef472"), 1, null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("38b5b0ce-9dea-43a7-b370-76a4790c01d6"), 2, null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("6675bbd0-0147-42a6-849b-90a4dc919fa7"), 1, null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("6f4a4079-4fd6-454a-86c4-e7ac95dc35e1"), 4, null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("7e510431-3a86-488d-ba5f-61df633c73c3"), 2, null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("ac588321-37fa-456a-9ab3-2b789e69c284"), 1, null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("c48512b0-cd49-4ac8-9a97-48aefab8aec0"), 2, null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("d10ef8c1-6f5c-4c74-8707-ae9ba4143e01"), 3, null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("d2c80dbc-ea88-4bb6-ba9d-a1f37f14e15f"), 1, null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("d68d10a6-7ca8-4e2a-a4d1-e2c28ce1b11a"), 1, null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("df3cec2d-57b2-4b60-b97e-25b10a92c503"), 1, null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("e70e9e81-2b2b-4cbb-9e18-613db50e4b92"), 1, null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("ea096fb8-246f-4dd8-a281-3e3340ebcd5c"), 2, null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("f1a47d28-d02b-454d-80f9-b317b8d99ee2"), 1, null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("ffc01ca7-19e8-49a1-95aa-886f6d0e57dd"), 2, null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05049d91-fc1d-439e-94f3-0d0348bf3971"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("090bd837-3eaa-4428-b243-5746629a3d28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fb5bcd4-148a-44ff-a383-05d2b41b0a7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20d96ef8-e683-4ae4-a481-f818d636e0df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27b44ae7-c324-40ba-a141-eb132458b1d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27bc7d0e-8f41-4efa-92d4-6f7d86fef472"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38b5b0ce-9dea-43a7-b370-76a4790c01d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6675bbd0-0147-42a6-849b-90a4dc919fa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f4a4079-4fd6-454a-86c4-e7ac95dc35e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e510431-3a86-488d-ba5f-61df633c73c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac588321-37fa-456a-9ab3-2b789e69c284"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c48512b0-cd49-4ac8-9a97-48aefab8aec0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d10ef8c1-6f5c-4c74-8707-ae9ba4143e01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2c80dbc-ea88-4bb6-ba9d-a1f37f14e15f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d68d10a6-7ca8-4e2a-a4d1-e2c28ce1b11a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df3cec2d-57b2-4b60-b97e-25b10a92c503"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e70e9e81-2b2b-4cbb-9e18-613db50e4b92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea096fb8-246f-4dd8-a281-3e3340ebcd5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1a47d28-d02b-454d-80f9-b317b8d99ee2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffc01ca7-19e8-49a1-95aa-886f6d0e57dd"));

            migrationBuilder.AddColumn<decimal>(
                name: "Length",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                comment: "Product length");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Length", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0333c7b1-142a-4de8-82a5-503d99ed347f"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-wedding-beige.png", false, null, "Wedding", 15m, 13.5m },
                    { new Guid("0c9c62eb-8065-4935-8a02-35ee771ff4e9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-heart-red.jpg", false, null, "Heart", 10m, 7.5m },
                    { new Guid("13320f71-a8ee-4135-99d7-20dadc643686"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, null, "Baby blue", 14.50m, 13.5m },
                    { new Guid("2d6a1210-2838-4591-9697-3724a6dd86fe"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-orange.png", false, null, "Orange flower", 15m, 13.5m },
                    { new Guid("301b6bad-9e4a-4d2f-80b7-a45c22b2909f"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-tulip-red.jpg", false, null, "Tulips", 10m, 15m },
                    { new Guid("379a015a-eab5-4a90-89b9-de3581cb66a4"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, null, "Anniversary", 10.80m, 15m },
                    { new Guid("3c548242-64a8-48b1-baae-52d1478ddc0b"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-bottle.jpg", false, null, "Bottle", 20m, 15m },
                    { new Guid("452dfae7-8640-44c1-8c41-1fac6925b84c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-yellow.jpg", false, null, "Yellow flowers", 10.50m, 15m },
                    { new Guid("4a8a17c7-1883-4758-a70e-41f4539a706d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-red-small.jpg", false, null, "Red Bear", 7.50m, 10m },
                    { new Guid("501fe141-eb92-4f3b-82af-d09e5fa3aff6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5m, "quilling-doll.jpg", false, null, "Doll w flowers", 15m, 6m },
                    { new Guid("5e7891de-da5e-40d5-a555-95ba813f7e9b"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21m, "quilling-card-folding-flower-orange.jpg", false, null, "Anniversary", 17m, 30m },
                    { new Guid("8a95cb92-cf85-4d5f-b632-1710c2b0065c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4m, "quilling-magnet-bear-panda.jpg", false, null, "Panda", 10m, 6m },
                    { new Guid("8baed613-5d82-4569-991a-234ee2135fd0"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-violet.png", false, null, "Violet", 10m, 10m },
                    { new Guid("8fe8fe83-5634-44b9-8ced-54db22ab09fb"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-snowdrop-white.jpg", false, null, "Whitedrops", 10m, 15m },
                    { new Guid("9d8e0efe-6d1c-4c87-931a-ae4d9ce6bdd3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-dolphin-blue.jpg", false, null, "Dolphin", 10m, 9m },
                    { new Guid("a2f1e3fd-11b5-40a9-a558-b7bded350271"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, null, "Flower", 10m, 7m },
                    { new Guid("ac8352a4-9d8e-4b8c-8f34-e0595afada7f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, null, "Bulgarian rose", 10m, 8m },
                    { new Guid("b89e4b87-0ead-4957-ab65-09512adae909"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-brown.jpg", false, null, "Brown flowers", 12m, 15m },
                    { new Guid("dbfd9019-08d2-4ac4-ab38-b359cebe8965"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5m, "quilling-magnet-basket-multi.jpg", false, null, "Flower basket", 10m, 6.5m },
                    { new Guid("f45cf844-eccc-4e1f-9712-7a7a1ba4a23c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-blue-small.jpg", false, null, "Blue Bear", 7m, 10m }
                });
        }
    }
}
