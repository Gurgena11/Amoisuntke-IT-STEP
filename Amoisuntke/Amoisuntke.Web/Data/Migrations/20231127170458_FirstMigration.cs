using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Amoisuntke.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Tank = table.Column<int>(type: "int", nullable: false),
                    IsSecured = table.Column<bool>(type: "bit", nullable: false),
                    Splash = table.Column<int>(type: "int", nullable: false),
                    Coverage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Coverage", "Description", "DiscountPrice", "ImageUrl", "IsExpired", "IsSecured", "Name", "Price", "Quantity", "Splash", "Tank" },
                values: new object[,]
                {
                    { 1, "White", 360, "ყოველდღიურ სტრესთან საბრძოლველად საჭიროა გვქონდეს ადგილი სადაც განიტვირთებით, ეს მოწყობილობა დაგეხმარებათ თქვენი გარემო მეტად მყუდრო და სასიამოვნო გახადოთ", 125.0, null, false, true, "ვულკანის ჰაერის დამატენიანებელი", 185.0, 5, 36, 30 },
                    { 2, "Blue", 360, "ყოველდღიურ სტრესთან საბრძოლველად საჭიროა გვქონდეს ადგილი სადაც განიტვირთებით, ეს მოწყობილობა დაგეხმარებათ თქვენი გარემო მეტად მყუდრო და სასიამოვნო გახადოთ", 125.0, null, false, true, "ჰაერის დამატენიანებელი", 185.0, 5, 36, 30 },
                    { 3, "Black", 0, "არომატი რომლის აღწერაც არც თუ ისე მარტივია, ზედა ნოტებია თამბაქოს ფოთოლი და პიკანტური ნოტები, შუა ნოტებია თამბაქოს ყვავილი, ვანილი და კაკაო, საბაზო ნოტები ხმელი ხილი და ხის ნოტები", 0.0, null, false, false, "სურნელოვანი ეთერზეთი - Tobacco Vanille 10ml", 25.0, 15, 10, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
