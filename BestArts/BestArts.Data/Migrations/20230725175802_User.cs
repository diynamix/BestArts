using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestArts.Data.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a7d34b8-ae59-433a-b92e-19919b8419e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("115031f8-397b-45b1-85b0-eda0526f3632"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f6b3587-5584-43ab-8e83-94ebdc44080e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f93cec5-0da8-4690-b0ee-168b4754a6e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bddec96-c811-4f36-8653-96dc3a355bfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d8a2f9c-3e62-457f-9afb-279cce2ba4a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ce8b69e-d85c-4b06-8898-32157e058b03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("500d02e1-1f2d-427e-af0b-b63503242ad5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6176a42f-c2fc-48a3-815a-37d8f0d25c7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61a95db7-67bd-4bf3-b0e5-e724264ecfb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63b03526-a07c-4f45-92f1-890eb98d1527"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76cbaa5e-a809-4eac-9809-5d324a3b3f6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f5d8cc-0409-40c0-b271-a5bfa5f46278"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0044678-19ee-49b7-b4c0-3459e74d5d1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bac714d6-8ec2-4bbe-ba74-ba9bceb933f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fcb8df-382f-414e-bcfb-62b2bec3403c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("daa7c077-46e7-4b08-be20-03be06ee8b49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db45f34e-bcfd-4cb4-b57d-110459201493"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e800f02f-096f-4e21-b52a-165a347a5612"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecbdd69a-3679-45ea-975d-6889fc32e88a"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0b6eed76-ec09-4ea2-87a5-0e500287f66c"), 2, null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("128b1499-13ec-4939-8d6c-26021bdd3418"), 1, null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("33755a76-7512-4ab4-850f-70e154fe050b"), 1, null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("40e23cf0-055c-4775-bee9-d1b3c57f3f13"), 2, null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("4c0e3196-f220-46dd-a82b-8de0b2f1b6fc"), 1, null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("65754c57-00ee-4cdd-bf7f-e7ff62d53300"), 1, null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("78aa46fe-ab5f-44fd-976d-d37dd963091d"), 3, null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("7e5f7bcf-05d5-4376-8cf3-dc77e5599184"), 2, null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("88cc3426-7881-4700-9472-d9f4c6fccf58"), 1, null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("9aac4c9f-37c9-4878-91a9-2d7da8b64fe4"), 1, null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("a9542eda-9c45-4e9d-b7bc-a9c2fac91fe3"), 2, null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("b0063bcb-cacc-4e15-9bd3-7091e2ce1a75"), 1, null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("c84c48c8-32d2-4431-a392-2fb544de7a6a"), 1, null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("d0c57056-96e8-4bfb-9eed-b79cc9fa2d8e"), 1, null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("d4f44dd8-f148-470d-a8de-a921720ca504"), 4, null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("d8863e4c-500d-492e-9e7a-b0739a09281e"), 2, null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("e3d1949a-542d-4dc3-a19a-23c29cf20142"), 1, null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("f192b43e-baf1-4d5e-bf07-4cbc2a0bb15e"), 2, null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("f291d359-40a2-4db0-a6b2-520db321dfc1"), 1, null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("fb6ce789-3229-4298-ba08-b743ffff840d"), 1, null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b6eed76-ec09-4ea2-87a5-0e500287f66c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("128b1499-13ec-4939-8d6c-26021bdd3418"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33755a76-7512-4ab4-850f-70e154fe050b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40e23cf0-055c-4775-bee9-d1b3c57f3f13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c0e3196-f220-46dd-a82b-8de0b2f1b6fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65754c57-00ee-4cdd-bf7f-e7ff62d53300"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78aa46fe-ab5f-44fd-976d-d37dd963091d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e5f7bcf-05d5-4376-8cf3-dc77e5599184"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88cc3426-7881-4700-9472-d9f4c6fccf58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9aac4c9f-37c9-4878-91a9-2d7da8b64fe4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9542eda-9c45-4e9d-b7bc-a9c2fac91fe3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0063bcb-cacc-4e15-9bd3-7091e2ce1a75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c84c48c8-32d2-4431-a392-2fb544de7a6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0c57056-96e8-4bfb-9eed-b79cc9fa2d8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4f44dd8-f148-470d-a8de-a921720ca504"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8863e4c-500d-492e-9e7a-b0739a09281e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3d1949a-542d-4dc3-a19a-23c29cf20142"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f192b43e-baf1-4d5e-bf07-4cbc2a0bb15e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f291d359-40a2-4db0-a6b2-520db321dfc1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb6ce789-3229-4298-ba08-b743ffff840d"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0a7d34b8-ae59-433a-b92e-19919b8419e2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("115031f8-397b-45b1-85b0-eda0526f3632"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("1f6b3587-5584-43ab-8e83-94ebdc44080e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("1f93cec5-0da8-4690-b0ee-168b4754a6e7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("2bddec96-c811-4f36-8653-96dc3a355bfb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("2d8a2f9c-3e62-457f-9afb-279cce2ba4a2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("4ce8b69e-d85c-4b06-8898-32157e058b03"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("500d02e1-1f2d-427e-af0b-b63503242ad5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("6176a42f-c2fc-48a3-815a-37d8f0d25c7d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("61a95db7-67bd-4bf3-b0e5-e724264ecfb8"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("63b03526-a07c-4f45-92f1-890eb98d1527"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("76cbaa5e-a809-4eac-9809-5d324a3b3f6e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("a4f5d8cc-0409-40c0-b271-a5bfa5f46278"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("b0044678-19ee-49b7-b4c0-3459e74d5d1f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("bac714d6-8ec2-4bbe-ba74-ba9bceb933f7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("d6fcb8df-382f-414e-bcfb-62b2bec3403c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("daa7c077-46e7-4b08-be20-03be06ee8b49"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("db45f34e-bcfd-4cb4-b57d-110459201493"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("e800f02f-096f-4e21-b52a-165a347a5612"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("ecbdd69a-3679-45ea-975d-6889fc32e88a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m }
                });
        }
    }
}
