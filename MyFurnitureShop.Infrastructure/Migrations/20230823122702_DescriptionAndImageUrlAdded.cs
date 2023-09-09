using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFurnitureShop.Infrastructure.Migrations
{
    public partial class DescriptionAndImageUrlAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Furnitures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Furnitures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ccf3f38-c3da-44c2-b658-a2030620bd8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a899b24-2aa4-4086-b36a-878b19f70b08", "AQAAAAEAACcQAAAAELAHrkYdSPI0+y8hdpzQ2/yDiLY0vnAmHO4J+1K2SW7H7YXh2Qtz9rFqo3nXTKxIng==", "70b9aa9d-35ff-40d3-a108-ef659b88b184" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a07163fd-dcbd-44e5-85c2-f604cf3c709f", "AQAAAAEAACcQAAAAEKJU77AMuumleBEX4cuh2cQ804fnPshHgfhHKCUGwyIX7eCNBpY3T1iORAFK8jq9Mw==", "6cffbe88-8bdb-4614-ab16-6bebd660e43f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Furnitures");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ccf3f38-c3da-44c2-b658-a2030620bd8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3a9ba6b-a10c-45b1-8925-6b6d1ca82243", "AQAAAAEAACcQAAAAEDxfaADnewZwOboNpvVUre0cwh85xA/l1kxmtv8bqDxxDOQ7r93Am1TjBXrOjWODPA==", "8d5ce2ec-2351-4c79-9fd8-93849dfaf313" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d016a78-3db6-4b48-b1bd-585cabd820e6", "AQAAAAEAACcQAAAAEH57sA6DV+ME6OIdxH0nX/jidQsWZqud+6V1DONIWKtbUu/oshrfJRaz+Nl9Od2B6w==", "10070001-7041-483d-b035-2737a53e9af8" });

            migrationBuilder.InsertData(
                table: "Furnitures",
                columns: new[] { "Id", "Colour", "IsActive", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { 1, "white", true, "Brazilian sofa", 320.0, 3 },
                    { 2, "brown", true, "Wooden chair", 70.0, 2 },
                    { 3, "white", true, "Luxury table", 120.0, 1 }
                });
        }
    }
}
