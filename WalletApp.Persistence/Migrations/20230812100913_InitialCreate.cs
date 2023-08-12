using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalletApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPending = table.Column<bool>(type: "bit", nullable: false),
                    AuthorizedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Amount", "AuthorizedUser", "Date", "Description", "IsPending", "Title", "TransactionType" },
                values: new object[,]
                {
                    { 1, 1, 701.724059082979000m, "Author", new DateTime(2023, 7, 15, 16, 7, 40, 444, DateTimeKind.Unspecified).AddTicks(9311), "Some description", true, "Credit", 1 },
                    { 2, 1, 770.49225892973000m, "Author", new DateTime(2023, 7, 16, 11, 44, 59, 333, DateTimeKind.Unspecified).AddTicks(9770), null, false, "Credit", 1 },
                    { 3, 2, 475.838481912631000m, "Author", new DateTime(2023, 7, 16, 12, 10, 4, 378, DateTimeKind.Unspecified).AddTicks(5604), null, false, "Credit", 1 },
                    { 4, 2, 10.3361539263104000m, "Author", new DateTime(2023, 7, 17, 2, 54, 36, 354, DateTimeKind.Unspecified).AddTicks(540), "Some description", true, "Payment", 0 },
                    { 5, 2, 739.854684070274000m, null, new DateTime(2023, 7, 17, 5, 21, 23, 419, DateTimeKind.Unspecified).AddTicks(8844), null, false, "Payment", 0 },
                    { 6, 2, 739.21721131775000m, "Author", new DateTime(2023, 7, 18, 12, 51, 23, 386, DateTimeKind.Unspecified).AddTicks(2590), null, true, "Payment", 0 },
                    { 7, 1, 769.254750156544000m, "Author", new DateTime(2023, 7, 18, 21, 50, 17, 592, DateTimeKind.Unspecified).AddTicks(6347), "Some description", true, "Credit", 1 },
                    { 8, 2, 719.027479379268000m, null, new DateTime(2023, 7, 21, 0, 27, 52, 352, DateTimeKind.Unspecified).AddTicks(8675), "Some description", false, "Credit", 1 },
                    { 9, 1, 926.680706265081000m, "Author", new DateTime(2023, 7, 22, 5, 31, 36, 705, DateTimeKind.Unspecified).AddTicks(7085), "Some description", false, "Payment", 0 },
                    { 10, 2, 912.341801508485000m, null, new DateTime(2023, 7, 23, 5, 59, 13, 591, DateTimeKind.Unspecified).AddTicks(3145), null, false, "Credit", 1 },
                    { 11, 2, 86.1110153455057000m, "Author", new DateTime(2023, 7, 24, 6, 48, 38, 961, DateTimeKind.Unspecified).AddTicks(6897), "Some description", true, "Payment", 0 },
                    { 12, 1, 289.483898339041000m, "Author", new DateTime(2023, 7, 25, 6, 59, 21, 870, DateTimeKind.Unspecified).AddTicks(3366), null, true, "Credit", 1 },
                    { 13, 1, 198.457637817378000m, "Author", new DateTime(2023, 7, 25, 14, 8, 2, 335, DateTimeKind.Unspecified).AddTicks(5405), null, false, "Payment", 0 },
                    { 14, 1, 828.357225772103000m, null, new DateTime(2023, 7, 25, 14, 23, 18, 867, DateTimeKind.Unspecified).AddTicks(388), null, true, "Payment", 0 },
                    { 15, 2, 795.235356744283000m, null, new DateTime(2023, 7, 25, 23, 13, 25, 484, DateTimeKind.Unspecified).AddTicks(444), "Some description", false, "Credit", 1 },
                    { 16, 1, 967.140426729544000m, null, new DateTime(2023, 7, 27, 5, 9, 40, 998, DateTimeKind.Unspecified).AddTicks(8919), null, true, "Payment", 0 },
                    { 17, 2, 893.595142645919000m, "Author", new DateTime(2023, 7, 29, 8, 29, 5, 982, DateTimeKind.Unspecified).AddTicks(6807), "Some description", true, "Payment", 0 },
                    { 18, 2, 865.451526170548000m, null, new DateTime(2023, 7, 30, 5, 0, 42, 244, DateTimeKind.Unspecified).AddTicks(4679), "Some description", true, "Payment", 0 },
                    { 19, 1, 344.157441054058000m, "Author", new DateTime(2023, 8, 2, 16, 15, 54, 75, DateTimeKind.Unspecified).AddTicks(5310), "Some description", true, "Credit", 1 },
                    { 20, 1, 222.238754650841000m, "Author", new DateTime(2023, 8, 7, 2, 2, 34, 449, DateTimeKind.Unspecified).AddTicks(1004), null, false, "Payment", 0 },
                    { 21, 2, 789.570397969155000m, null, new DateTime(2023, 8, 7, 4, 9, 12, 507, DateTimeKind.Unspecified).AddTicks(4498), null, false, "Credit", 1 },
                    { 22, 1, 36.3297257028562000m, null, new DateTime(2023, 8, 7, 7, 53, 37, 358, DateTimeKind.Unspecified).AddTicks(8252), null, false, "Payment", 0 },
                    { 23, 2, 801.850138524724000m, null, new DateTime(2023, 8, 7, 15, 54, 39, 183, DateTimeKind.Unspecified).AddTicks(7940), null, true, "Credit", 1 },
                    { 24, 2, 28.2418998316961000m, "Author", new DateTime(2023, 8, 8, 22, 46, 3, 760, DateTimeKind.Unspecified).AddTicks(3045), "Some description", true, "Credit", 1 },
                    { 25, 1, 547.963378377792000m, null, new DateTime(2023, 8, 11, 0, 10, 23, 924, DateTimeKind.Unspecified).AddTicks(1574), null, false, "Credit", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
