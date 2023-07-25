using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestArts.Data.Migrations
{
    public partial class Check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fbe9174d-aa56-470d-981a-be7ce6510c8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10f52d5e-9d47-44a2-a9ba-853a150ee2d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b9ecfd7-7178-40f8-b7f6-1693a2ca9e8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("311d6806-6557-461d-a8e9-97524ec8271f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3178c56a-ae38-4cc1-a566-7b08996633ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("384b1b36-e3f0-4caf-b8db-8498c9d9c8f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4acc85c4-818d-4955-b68d-796f5eed1665"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ce8b9ba-e065-4167-b395-3f771633af7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("585436b5-0083-4d64-bcac-66ef60f680da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b91ba28-f127-4682-95bf-3bcc3f933f45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ec1aa13-acdf-4bdc-b86e-26d220cc0483"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ba15023-2a53-4a99-ab51-3ffa64f8a9d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7efe66d6-349b-4048-83b6-944255bca8a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82141daf-854e-44e6-9b54-2693ad2a2f75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8f3ad81-7d11-4bd3-a73a-f0064493cd44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cca508dc-b46a-458f-a52c-aafc50efbc5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb82b54d-92f2-43f3-93be-c27d00ab9bc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee85e7ef-5200-43d1-9065-19a45f548067"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1d3e4ee-3b54-4100-9078-fbd563942fb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f38292b3-cbc2-43a1-bc5a-a1cc0204ee05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fea4c261-045d-4220-90a4-4e9be404e658"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0a7d34b8-ae59-433a-b92e-19919b8419e2"), 3, null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("115031f8-397b-45b1-85b0-eda0526f3632"), 2, null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("1f6b3587-5584-43ab-8e83-94ebdc44080e"), 1, null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("1f93cec5-0da8-4690-b0ee-168b4754a6e7"), 1, null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("2bddec96-c811-4f36-8653-96dc3a355bfb"), 2, null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("2d8a2f9c-3e62-457f-9afb-279cce2ba4a2"), 2, null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("4ce8b69e-d85c-4b06-8898-32157e058b03"), 1, null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("500d02e1-1f2d-427e-af0b-b63503242ad5"), 1, null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("6176a42f-c2fc-48a3-815a-37d8f0d25c7d"), 1, null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("61a95db7-67bd-4bf3-b0e5-e724264ecfb8"), 1, null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("63b03526-a07c-4f45-92f1-890eb98d1527"), 1, null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("76cbaa5e-a809-4eac-9809-5d324a3b3f6e"), 1, null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("a4f5d8cc-0409-40c0-b271-a5bfa5f46278"), 2, null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("b0044678-19ee-49b7-b4c0-3459e74d5d1f"), 2, null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("bac714d6-8ec2-4bbe-ba74-ba9bceb933f7"), 2, null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("d6fcb8df-382f-414e-bcfb-62b2bec3403c"), 1, null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("daa7c077-46e7-4b08-be20-03be06ee8b49"), 4, null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("db45f34e-bcfd-4cb4-b57d-110459201493"), 1, null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("e800f02f-096f-4e21-b52a-165a347a5612"), 1, null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("ecbdd69a-3679-45ea-975d-6889fc32e88a"), 1, null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("fbe9174d-aa56-470d-981a-be7ce6510c8c"), 0, "0f939f0b-f3b2-4a30-839f-6df078bdf796", "jackrabbit@mail.com", false, "Jack", "Rabbit", false, null, null, null, "AQAAAAEAACcQAAAAEAv+vBMm+2bqmQbxvu4GFnccJZs8303Ei5zTV9Dbnepsyvspjc8ykfAAZ/rGjUoWGA==", "+359000000000", false, null, false, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("10f52d5e-9d47-44a2-a9ba-853a150ee2d1"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("2b9ecfd7-7178-40f8-b7f6-1693a2ca9e8c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("311d6806-6557-461d-a8e9-97524ec8271f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("3178c56a-ae38-4cc1-a566-7b08996633ff"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("384b1b36-e3f0-4caf-b8db-8498c9d9c8f1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("4acc85c4-818d-4955-b68d-796f5eed1665"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("4ce8b9ba-e065-4167-b395-3f771633af7d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("585436b5-0083-4d64-bcac-66ef60f680da"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("5b91ba28-f127-4682-95bf-3bcc3f933f45"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("5ec1aa13-acdf-4bdc-b86e-26d220cc0483"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("7ba15023-2a53-4a99-ab51-3ffa64f8a9d1"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("7efe66d6-349b-4048-83b6-944255bca8a5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("82141daf-854e-44e6-9b54-2693ad2a2f75"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("a8f3ad81-7d11-4bd3-a73a-f0064493cd44"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("cca508dc-b46a-458f-a52c-aafc50efbc5d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("eb82b54d-92f2-43f3-93be-c27d00ab9bc3"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("ee85e7ef-5200-43d1-9065-19a45f548067"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("f1d3e4ee-3b54-4100-9078-fbd563942fb9"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("f38292b3-cbc2-43a1-bc5a-a1cc0204ee05"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("fea4c261-045d-4220-90a4-4e9be404e658"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m }
                });
        }
    }
}
