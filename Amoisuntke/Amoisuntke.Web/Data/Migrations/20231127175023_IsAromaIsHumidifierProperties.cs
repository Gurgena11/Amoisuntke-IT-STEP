using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amoisuntke.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class IsAromaIsHumidifierProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAroma",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHumidifier",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsAroma", "IsHumidifier" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsAroma", "IsHumidifier" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsAroma", "IsHumidifier" },
                values: new object[] { true, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAroma",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsHumidifier",
                table: "Products");
        }
    }
}
