using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestArts.Data.Migrations
{
    public partial class AddedPaymentMethodAndTermsAcceptedToOrderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Payment method");

            migrationBuilder.AddColumn<bool>(
                name: "TermsAccepted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Are terms accepted");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0763a788-42a8-4c0e-a6cd-b2b21132332a"), 1, null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("07eb04da-d51f-41a9-8d35-268c3e02db01"), 1, null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("19ce3752-0ee5-4739-90c4-cb9f58fc0639"), 2, null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("1a66b48f-4832-4635-bdee-d6ac2334cf9e"), 4, null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("2342bf0b-2425-43b6-a3fa-22bdb7e33901"), 1, null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("264f1211-ee6a-4710-8667-5127faa47722"), 1, null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("359bf59a-c0d1-48d6-ad3d-26bdc6919a80"), 1, null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("385443bb-30b6-4f13-8506-173b7109301d"), 2, null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("49486bad-d45b-4b37-814a-69229fdf0ca0"), 1, null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("64830aa0-6018-49c0-ba3d-c2f02bf9ab28"), 1, null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("6ebed377-5c76-4150-838d-f4ad1f691773"), 2, null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("8722ec90-01cd-4512-825f-676a5d23762e"), 1, null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("897447d8-01bc-4683-90fe-f7a7c194a770"), 3, null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m },
                    { new Guid("9063b981-4c52-4d6b-a5aa-d768f880afb2"), 1, null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("926ae463-d919-4d14-87b9-cf0cdb36065d"), 1, null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("9bbd5116-48c5-4773-84a1-ee0ff71eec3d"), 1, null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("a414f484-144e-4393-992f-2f389ee81b35"), 2, null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("a6799b2a-2ad7-4922-80c3-d82a82eb3b6c"), 2, null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("b5186923-68c4-4bb1-9541-079e1096b393"), 1, null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("cccbc47e-ffdb-4f0f-bd8c-ec052007a2eb"), 2, null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0763a788-42a8-4c0e-a6cd-b2b21132332a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07eb04da-d51f-41a9-8d35-268c3e02db01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19ce3752-0ee5-4739-90c4-cb9f58fc0639"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a66b48f-4832-4635-bdee-d6ac2334cf9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2342bf0b-2425-43b6-a3fa-22bdb7e33901"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("264f1211-ee6a-4710-8667-5127faa47722"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("359bf59a-c0d1-48d6-ad3d-26bdc6919a80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("385443bb-30b6-4f13-8506-173b7109301d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49486bad-d45b-4b37-814a-69229fdf0ca0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64830aa0-6018-49c0-ba3d-c2f02bf9ab28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ebed377-5c76-4150-838d-f4ad1f691773"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8722ec90-01cd-4512-825f-676a5d23762e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("897447d8-01bc-4683-90fe-f7a7c194a770"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9063b981-4c52-4d6b-a5aa-d768f880afb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("926ae463-d919-4d14-87b9-cf0cdb36065d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bbd5116-48c5-4773-84a1-ee0ff71eec3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a414f484-144e-4393-992f-2f389ee81b35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6799b2a-2ad7-4922-80c3-d82a82eb3b6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5186923-68c4-4bb1-9541-079e1096b393"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cccbc47e-ffdb-4f0f-bd8c-ec052007a2eb"));

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TermsAccepted",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DeletedOn", "Height", "ImageUrl", "IsDeleted", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { new Guid("0e88e864-3799-40e6-9787-a7edd07b664e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21m, "quilling-card-folding-flower-orange.jpg", false, "Anniversary", 17m, 30m },
                    { new Guid("28b82a6f-26a1-401f-9b6d-3d496dcb18c2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-heart-red.jpg", false, "Heart", 10m, 7.5m },
                    { new Guid("36642db2-a001-478e-a9d9-8237faf12edc"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.5m, "quilling-magnet-bulgarian-rose-red.jpg", false, "Bulgarian rose", 10m, 8m },
                    { new Guid("37f66f52-974c-4bd4-a1b2-0bf315cf72c5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-snowdrop-white.jpg", false, "Whitedrops", 10m, 15m },
                    { new Guid("3f766506-a52d-4e7b-b500-cbff24103d71"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.5m, "quilling-magnet-basket-multi.jpg", false, "Flower basket", 10m, 6.5m },
                    { new Guid("56a97569-64b6-4ff2-b3a0-fe72bdefb85c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4m, "quilling-magnet-bear-panda.jpg", false, "Panda", 10m, 6m },
                    { new Guid("59bdeffd-16cd-4d10-8216-daf7932694dc"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-magnet-flower-circle-multi.jpg", false, "Flower", 10m, 7m },
                    { new Guid("5af4c636-340b-4cbb-9588-679cd2306f0d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-brown.jpg", false, "Brown flowers", 12m, 15m },
                    { new Guid("64d4d1de-bb7f-44db-994b-9d2666bd1420"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7m, "quilling-bottle.jpg", false, "Bottle", 20m, 15m },
                    { new Guid("68859fce-fcec-475e-a3c5-7fa6cba71630"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-yellow.jpg", false, "Yellow flowers", 10.50m, 15m },
                    { new Guid("7602516f-e8a6-4484-bd8f-9ca22631f06c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-tulip-red.jpg", false, "Tulips", 10m, 15m },
                    { new Guid("86112c90-c5bc-4864-b2a0-425221b80e8c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-baby-chair-blue.jpg", false, "Baby blue", 14.50m, 13.5m },
                    { new Guid("9a495532-b971-4a90-a2bd-5ad92df414dc"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-blue-small.jpg", false, "Blue Bear", 7m, 10m },
                    { new Guid("9e29a2c1-5723-4c81-beea-21c0ca48d3f0"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-violet.png", false, "Violet", 10m, 10m },
                    { new Guid("a5962175-6f59-40f9-ae27-88c693a80499"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6m, "quilling-magnet-dolphin-blue.jpg", false, "Dolphin", 10m, 9m },
                    { new Guid("a60faa71-3611-4d8f-9de4-78428742a109"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10m, "quilling-card-flower-anniversary-orange.jpg", false, "Anniversary", 10.80m, 15m },
                    { new Guid("b30bdbed-bff2-4d0b-b2ed-28ca2cce3ca3"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7.5m, "quilling-card-bear-red-small.jpg", false, "Red Bear", 7.50m, 10m },
                    { new Guid("b4a90d7a-4586-4092-9777-5ac9fc4ffe93"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-wedding-beige.png", false, "Wedding", 15m, 13.5m },
                    { new Guid("cc869d8d-fb3d-401a-bf61-1c2128639391"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13.5m, "quilling-card-flower-orange.png", false, "Orange flower", 15m, 13.5m },
                    { new Guid("d9cbac52-c300-4e43-9a7b-889925d8ce00"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5m, "quilling-doll.jpg", false, "Doll w flowers", 15m, 6m }
                });
        }
    }
}
