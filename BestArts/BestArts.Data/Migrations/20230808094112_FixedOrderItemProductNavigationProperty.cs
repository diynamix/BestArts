using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestArts.Data.Migrations
{
    public partial class FixedOrderItemProductNavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Product",
                table: "OrderItems");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0e88e864-3799-40e6-9787-a7edd07b664e"), 1, null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("28b82a6f-26a1-401f-9b6d-3d496dcb18c2"), 2, null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("36642db2-a001-478e-a9d9-8237faf12edc"), 2, null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("37f66f52-974c-4bd4-a1b2-0bf315cf72c5"), 1, null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("3f766506-a52d-4e7b-b500-cbff24103d71"), 2, null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("56a97569-64b6-4ff2-b3a0-fe72bdefb85c"), 2, null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("59bdeffd-16cd-4d10-8216-daf7932694dc"), 2, null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("5af4c636-340b-4cbb-9588-679cd2306f0d"), 1, null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("64d4d1de-bb7f-44db-994b-9d2666bd1420"), 4, null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("68859fce-fcec-475e-a3c5-7fa6cba71630"), 1, null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("7602516f-e8a6-4484-bd8f-9ca22631f06c"), 1, null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("86112c90-c5bc-4864-b2a0-425221b80e8c"), 1, null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("9a495532-b971-4a90-a2bd-5ad92df414dc"), 1, null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("9e29a2c1-5723-4c81-beea-21c0ca48d3f0"), 1, null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("a5962175-6f59-40f9-ae27-88c693a80499"), 2, null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("a60faa71-3611-4d8f-9de4-78428742a109"), 1, null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("b30bdbed-bff2-4d0b-b2ed-28ca2cce3ca3"), 1, null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("b4a90d7a-4586-4092-9777-5ac9fc4ffe93"), 1, null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("cc869d8d-fb3d-401a-bf61-1c2128639391"), 1, null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("d9cbac52-c300-4e43-9a7b-889925d8ce00"), 3, null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e88e864-3799-40e6-9787-a7edd07b664e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28b82a6f-26a1-401f-9b6d-3d496dcb18c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36642db2-a001-478e-a9d9-8237faf12edc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37f66f52-974c-4bd4-a1b2-0bf315cf72c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f766506-a52d-4e7b-b500-cbff24103d71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56a97569-64b6-4ff2-b3a0-fe72bdefb85c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59bdeffd-16cd-4d10-8216-daf7932694dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5af4c636-340b-4cbb-9588-679cd2306f0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64d4d1de-bb7f-44db-994b-9d2666bd1420"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68859fce-fcec-475e-a3c5-7fa6cba71630"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7602516f-e8a6-4484-bd8f-9ca22631f06c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86112c90-c5bc-4864-b2a0-425221b80e8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a495532-b971-4a90-a2bd-5ad92df414dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e29a2c1-5723-4c81-beea-21c0ca48d3f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5962175-6f59-40f9-ae27-88c693a80499"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a60faa71-3611-4d8f-9de4-78428742a109"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b30bdbed-bff2-4d0b-b2ed-28ca2cce3ca3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4a90d7a-4586-4092-9777-5ac9fc4ffe93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc869d8d-fb3d-401a-bf61-1c2128639391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9cbac52-c300-4e43-9a7b-889925d8ce00"));

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Ordered product");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("044a4a8e-ed54-4457-b5dc-cd1aea42986c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("10cfd8b6-a189-4d32-9a19-64fd089a3970"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("12dcf1b2-6b3a-45a0-b2db-6941257cbfa3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("2d50a907-708a-4a2f-b4ba-3e4084daa089"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("45f29fa3-675d-45ce-a981-763230b70638"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("49ede0bd-fc16-4a8c-9764-28571fe0b90b"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("6ae89c25-68e5-448f-82f6-73b1eb924e02"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("7c47e4ca-2942-4398-90c4-3ab4d888e8ba"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("8aa11a2e-b72a-4ad3-8ce0-3822931ae9c4"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("8b54a691-534a-4b9a-a36a-e646eb020bb2"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("9aabd287-5c01-4f68-b0e8-85328e8100d7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("9d5ccc3d-f9f9-45d1-973a-0709b92950af"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("ad33e84f-fab8-4e4d-ad45-f86e23630606"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("b7cf72b1-b4d6-4ab5-94dc-6778b16e5538"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("c28ddbb9-4d38-4d04-a56d-4e7b2c50677d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("c872989e-300d-46af-8e81-69c6cf08023b"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("d56f4077-538f-4d0c-aafe-571ca8a6076e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("df9dbf31-744c-4e6d-8591-907d197fdf26"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("e166a1d6-8363-4c2e-bc2b-b07bcc1a20f5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("ebc2cd10-f7c2-40ff-a8e4-ba8a4f8b0e35"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m }
                });
        }
    }
}
