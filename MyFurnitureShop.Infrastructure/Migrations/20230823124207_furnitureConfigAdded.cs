using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFurnitureShop.Infrastructure.Migrations
{
    public partial class furnitureConfigAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ccf3f38-c3da-44c2-b658-a2030620bd8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a0d618-3ea4-4da0-bbd5-e3b609a27b8f", "AQAAAAEAACcQAAAAED2WJfWXIhC7LXTd4aKBSAvq8I00eRFKvw0P8mPF1y9DdPcTzZ6s8WR9nNVn8k0sEg==", "9949973b-9d7f-40bb-b6db-6bfe048e8385" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61012ef5-dd60-4f48-83d1-2bad368b3cc0", "AQAAAAEAACcQAAAAEGgxahHCyVhnxOeIRud99NlBNCwToMnqMv2KVV6QvX3lsnYrmQm1DyjSZbL2mazDMA==", "aab01a01-7e67-4aaa-a69b-45e0acc29f25" });

            migrationBuilder.InsertData(
                table: "Furnitures",
                columns: new[] { "Id", "Colour", "Description", "ImageUrl", "IsActive", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { 1, "white", "Вътрешната конструнция е изработена от масив и метал, уплатнени с полиуретанова пяна. Моделът е с изчистени пропорции и модерно излъчване. Предлага се в много размера и на различни модули. Може да бъде поръчан в различни дамаски или кожа.", "/images/15BOSTON-divano-_44.jpg", true, "Brazilian sofa", 320.0, 3 },
                    { 2, "brown", "Трапезарен стол Giuseppina by Dondoli e Pocci. \r\n\r\nПроизведен е от висококачествена пластмаса по най-нови технологии. Предлага се в различни цветове\r\n\r\nРазмери: 53 х 46 х 46 h (седалка) х 84 h (облегалка)", "/images/89cam-el-eon-stool-1.jpg", true, "Wooden chair", 70.0, 2 },
                    { 3, "white", "В този модел традицията и новаторството се преплитат хармонично, като един нов прочит на класическия модел маса с четири крака и вградена табла. Масата е дървена, а възглавниците може да са от плат или кожа\r\n\r\nРазмерите може да са 160 х 200 см. или 180 х 200 см.", "/images/1.jpg", true, "Luxury table", 120.0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
