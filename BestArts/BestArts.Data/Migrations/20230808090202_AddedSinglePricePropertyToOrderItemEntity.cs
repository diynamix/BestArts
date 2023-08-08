using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestArts.Data.Migrations
{
    public partial class AddedSinglePricePropertyToOrderItemEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "SinglePrice",
                table: "OrderItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                comment: "Ordered product single price");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("044a4a8e-ed54-4457-b5dc-cd1aea42986c"), 3, null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("10cfd8b6-a189-4d32-9a19-64fd089a3970"), 1, null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("12dcf1b2-6b3a-45a0-b2db-6941257cbfa3"), 2, null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("2d50a907-708a-4a2f-b4ba-3e4084daa089"), 2, null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("45f29fa3-675d-45ce-a981-763230b70638"), 1, null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("49ede0bd-fc16-4a8c-9764-28571fe0b90b"), 1, null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("6ae89c25-68e5-448f-82f6-73b1eb924e02"), 1, null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("7c47e4ca-2942-4398-90c4-3ab4d888e8ba"), 2, null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("8aa11a2e-b72a-4ad3-8ce0-3822931ae9c4"), 1, null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("8b54a691-534a-4b9a-a36a-e646eb020bb2"), 1, null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("9aabd287-5c01-4f68-b0e8-85328e8100d7"), 1, null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("9d5ccc3d-f9f9-45d1-973a-0709b92950af"), 1, null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("ad33e84f-fab8-4e4d-ad45-f86e23630606"), 2, null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("b7cf72b1-b4d6-4ab5-94dc-6778b16e5538"), 1, null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("c28ddbb9-4d38-4d04-a56d-4e7b2c50677d"), 2, null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("c872989e-300d-46af-8e81-69c6cf08023b"), 1, null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("d56f4077-538f-4d0c-aafe-571ca8a6076e"), 1, null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("df9dbf31-744c-4e6d-8591-907d197fdf26"), 4, null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("e166a1d6-8363-4c2e-bc2b-b07bcc1a20f5"), 1, null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("ebc2cd10-f7c2-40ff-a8e4-ba8a4f8b0e35"), 2, null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("044a4a8e-ed54-4457-b5dc-cd1aea42986c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10cfd8b6-a189-4d32-9a19-64fd089a3970"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12dcf1b2-6b3a-45a0-b2db-6941257cbfa3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d50a907-708a-4a2f-b4ba-3e4084daa089"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45f29fa3-675d-45ce-a981-763230b70638"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49ede0bd-fc16-4a8c-9764-28571fe0b90b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ae89c25-68e5-448f-82f6-73b1eb924e02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c47e4ca-2942-4398-90c4-3ab4d888e8ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8aa11a2e-b72a-4ad3-8ce0-3822931ae9c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b54a691-534a-4b9a-a36a-e646eb020bb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9aabd287-5c01-4f68-b0e8-85328e8100d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d5ccc3d-f9f9-45d1-973a-0709b92950af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad33e84f-fab8-4e4d-ad45-f86e23630606"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7cf72b1-b4d6-4ab5-94dc-6778b16e5538"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c28ddbb9-4d38-4d04-a56d-4e7b2c50677d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c872989e-300d-46af-8e81-69c6cf08023b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d56f4077-538f-4d0c-aafe-571ca8a6076e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df9dbf31-744c-4e6d-8591-907d197fdf26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e166a1d6-8363-4c2e-bc2b-b07bcc1a20f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebc2cd10-f7c2-40ff-a8e4-ba8a4f8b0e35"));

            migrationBuilder.DropColumn(
                name: "SinglePrice",
                table: "OrderItems");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0b6eed76-ec09-4ea2-87a5-0e500287f66c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("128b1499-13ec-4939-8d6c-26021bdd3418"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("33755a76-7512-4ab4-850f-70e154fe050b"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("40e23cf0-055c-4775-bee9-d1b3c57f3f13"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("4c0e3196-f220-46dd-a82b-8de0b2f1b6fc"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("65754c57-00ee-4cdd-bf7f-e7ff62d53300"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("78aa46fe-ab5f-44fd-976d-d37dd963091d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("7e5f7bcf-05d5-4376-8cf3-dc77e5599184"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("88cc3426-7881-4700-9472-d9f4c6fccf58"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("9aac4c9f-37c9-4878-91a9-2d7da8b64fe4"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("a9542eda-9c45-4e9d-b7bc-a9c2fac91fe3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("b0063bcb-cacc-4e15-9bd3-7091e2ce1a75"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("c84c48c8-32d2-4431-a392-2fb544de7a6a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("d0c57056-96e8-4bfb-9eed-b79cc9fa2d8e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("d4f44dd8-f148-470d-a8de-a921720ca504"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("d8863e4c-500d-492e-9e7a-b0739a09281e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("e3d1949a-542d-4dc3-a19a-23c29cf20142"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("f192b43e-baf1-4d5e-bf07-4cbc2a0bb15e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("f291d359-40a2-4db0-a6b2-520db321dfc1"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("fb6ce789-3229-4298-ba08-b743ffff840d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m }
                });
        }
    }
}
