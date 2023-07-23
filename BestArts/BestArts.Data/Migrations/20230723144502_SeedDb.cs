#nullable disable

namespace BestArts.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Quilling card" },
                    { 2, "Magnet" },
                    { 3, "Quilling doll" },
                    { 4, "Quilling bottle" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Length", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0333c7b1-142a-4de8-82a5-503d99ed347f"), 1, null, 13.5m, "quilling-card-flower-wedding-beige.png", false, null, "Wedding", 15m, 13.5m },
                    { new Guid("0c9c62eb-8065-4935-8a02-35ee771ff4e9"), 2, null, 6m, "quilling-magnet-heart-red.jpg", false, null, "Heart", 10m, 7.5m },
                    { new Guid("13320f71-a8ee-4135-99d7-20dadc643686"), 1, null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, null, "Baby blue", 14.50m, 13.5m },
                    { new Guid("2d6a1210-2838-4591-9697-3724a6dd86fe"), 1, null, 13.5m, "quilling-card-flower-orange.png", false, null, "Orange flower", 15m, 13.5m },
                    { new Guid("301b6bad-9e4a-4d2f-80b7-a45c22b2909f"), 1, null, 10m, "quilling-card-flower-tulip-red.jpg", false, null, "Tulips", 10m, 15m },
                    { new Guid("379a015a-eab5-4a90-89b9-de3581cb66a4"), 1, null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, null, "Anniversary", 10.80m, 15m },
                    { new Guid("3c548242-64a8-48b1-baae-52d1478ddc0b"), 4, null, 7m, "quilling-bottle.jpg", false, null, "Bottle", 20m, 15m },
                    { new Guid("452dfae7-8640-44c1-8c41-1fac6925b84c"), 1, null, 10m, "quilling-card-flower-yellow.jpg", false, null, "Yellow flowers", 10.50m, 15m },
                    { new Guid("4a8a17c7-1883-4758-a70e-41f4539a706d"), 1, null, 7.5m, "quilling-card-bear-red-small.jpg", false, null, "Red Bear", 7.50m, 10m },
                    { new Guid("501fe141-eb92-4f3b-82af-d09e5fa3aff6"), 3, null, 5m, "quilling-doll.jpg", false, null, "Doll w flowers", 15m, 6m },
                    { new Guid("5e7891de-da5e-40d5-a555-95ba813f7e9b"), 1, null, 21m, "quilling-card-folding-flower-orange.jpg", false, null, "Anniversary", 17m, 30m },
                    { new Guid("8a95cb92-cf85-4d5f-b632-1710c2b0065c"), 2, null, 4m, "quilling-magnet-bear-panda.jpg", false, null, "Panda", 10m, 6m },
                    { new Guid("8baed613-5d82-4569-991a-234ee2135fd0"), 1, null, 7.5m, "quilling-card-violet.png", false, null, "Violet", 10m, 10m },
                    { new Guid("8fe8fe83-5634-44b9-8ced-54db22ab09fb"), 1, null, 10m, "quilling-card-snowdrop-white.jpg", false, null, "Whitedrops", 10m, 15m },
                    { new Guid("9d8e0efe-6d1c-4c87-931a-ae4d9ce6bdd3"), 2, null, 6m, "quilling-magnet-dolphin-blue.jpg", false, null, "Dolphin", 10m, 9m },
                    { new Guid("a2f1e3fd-11b5-40a9-a558-b7bded350271"), 2, null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, null, "Flower", 10m, 7m },
                    { new Guid("ac8352a4-9d8e-4b8c-8f34-e0595afada7f"), 2, null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, null, "Bulgarian rose", 10m, 8m },
                    { new Guid("b89e4b87-0ead-4957-ab65-09512adae909"), 1, null, 10m, "quilling-card-flower-brown.jpg", false, null, "Brown flowers", 12m, 15m },
                    { new Guid("dbfd9019-08d2-4ac4-ab38-b359cebe8965"), 2, null, 4.5m, "quilling-magnet-basket-multi.jpg", false, null, "Flower basket", 10m, 6.5m },
                    { new Guid("f45cf844-eccc-4e1f-9712-7a7a1ba4a23c"), 1, null, 7.5m, "quilling-card-bear-blue-small.jpg", false, null, "Blue Bear", 7m, 10m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
