using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "55d7b538-eddb-4a0b-a780-b43c8be30bb2");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "a31ae420-5390-4888-a096-4248693a0cd2");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "ab86b5b2-d524-4efc-b429-aabdb0064ba2");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "dc4dc4ac-b65c-42f3-bdd8-50287f71666b");

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "022b7971-100b-46e0-aa2a-f5beb18e7dd4", "Calle falsa 2", "Bodega Nro 2" },
                    { "42d97364-4464-4bcc-8b6e-5613fcb6e640", "Calle falsa 4", "Bodega Nro 4" },
                    { "6c1e7f49-27bd-4fbb-a944-4650005abca6", "Calle falsa 3", "Bodega Nro 3" },
                    { "d03a724e-17a4-45c5-aa1a-d39eb32d5167", "Calle falsa 1", "Bodega Nro 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "022b7971-100b-46e0-aa2a-f5beb18e7dd4");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "42d97364-4464-4bcc-8b6e-5613fcb6e640");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "6c1e7f49-27bd-4fbb-a944-4650005abca6");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "d03a724e-17a4-45c5-aa1a-d39eb32d5167");

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "55d7b538-eddb-4a0b-a780-b43c8be30bb2", "Calle falsa 1", "Bodega Nro 1" },
                    { "a31ae420-5390-4888-a096-4248693a0cd2", "Calle falsa 4", "Bodega Nro 4" },
                    { "ab86b5b2-d524-4efc-b429-aabdb0064ba2", "Calle falsa 3", "Bodega Nro 3" },
                    { "dc4dc4ac-b65c-42f3-bdd8-50287f71666b", "Calle falsa 2", "Bodega Nro 2" }
                });
        }
    }
}
