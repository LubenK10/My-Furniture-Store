using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFurnitureShop.Infrastructure.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3ccf3f38-c3da-44c2-b658-a2030620bd8e", 0, "a3a9ba6b-a10c-45b1-8925-6b6d1ca82243", "User", "manager@gmail.com", false, null, null, false, null, "MANAGER@GMAIL.COM", "IVAN2020", "AQAAAAEAACcQAAAAEDxfaADnewZwOboNpvVUre0cwh85xA/l1kxmtv8bqDxxDOQ7r93Am1TjBXrOjWODPA==", null, false, "8d5ce2ec-2351-4c79-9fd8-93849dfaf313", false, "Ivan2020" },
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "6d016a78-3db6-4b48-b1bd-585cabd820e6", "User", "user@gmail.com", false, null, null, false, null, "USER@GMAIL.COM", "DIMITARK10", "AQAAAAEAACcQAAAAEH57sA6DV+ME6OIdxH0nX/jidQsWZqud+6V1DONIWKtbUu/oshrfJRaz+Nl9Od2B6w==", null, false, "10070001-7041-483d-b035-2737a53e9af8", false, "DimitarK10" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Table" },
                    { 2, "Chair" },
                    { 3, "Sofa" },
                    { 4, "Bed" },
                    { 5, "Wardrobe" },
                    { 6, "Desk" },
                    { 7, "Cupboard" }
                });

            migrationBuilder.InsertData(
                table: "Furnitures",
                columns: new[] { "Id", "Colour", "IsActive", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { 1, "white", true, "Brazilian sofa", 320.0, 3 },
                    { 2, "brown", true, "Wooden chair", 70.0, 2 },
                    { 3, "white", true, "Luxury table", 120.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "3ccf3f38-c3da-44c2-b658-a2030620bd8e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ccf3f38-c3da-44c2-b658-a2030620bd8e");

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);
        }
    }
}
