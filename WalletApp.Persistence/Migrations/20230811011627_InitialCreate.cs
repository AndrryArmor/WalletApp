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
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    Sum = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPending = table.Column<bool>(type: "bit", nullable: false),
                    AuthorizedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "AuthorizedUser", "Date", "Description", "Icon", "IsPending", "Sum", "Title", "TransactionType" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 7, 12, 8, 48, 34, 461, DateTimeKind.Unspecified).AddTicks(7047), null, null, false, 606m, "TransactionType", 0 },
                    { 2, 1, "Author", new DateTime(2023, 7, 12, 20, 15, 31, 641, DateTimeKind.Unspecified).AddTicks(9430), "Some description", null, false, 879m, "TransactionType", 0 },
                    { 3, 2, null, new DateTime(2023, 7, 16, 15, 22, 4, 150, DateTimeKind.Unspecified).AddTicks(236), "Some description", null, false, 36m, "TransactionType", 1 },
                    { 4, 2, "Author", new DateTime(2023, 7, 16, 20, 1, 12, 321, DateTimeKind.Unspecified).AddTicks(1662), null, null, false, 995m, "TransactionType", 1 },
                    { 5, 2, "Author", new DateTime(2023, 7, 18, 15, 42, 46, 118, DateTimeKind.Unspecified).AddTicks(2188), "Some description", null, true, 610m, "TransactionType", 0 },
                    { 6, 1, "Author", new DateTime(2023, 7, 19, 9, 27, 27, 971, DateTimeKind.Unspecified).AddTicks(2604), "Some description", null, true, 213m, "TransactionType", 1 },
                    { 7, 1, null, new DateTime(2023, 7, 23, 9, 59, 22, 82, DateTimeKind.Unspecified).AddTicks(2593), null, null, false, 198m, "TransactionType", 0 },
                    { 8, 2, "Author", new DateTime(2023, 7, 24, 3, 25, 43, 620, DateTimeKind.Unspecified).AddTicks(4868), null, null, true, 311m, "TransactionType", 1 },
                    { 9, 1, null, new DateTime(2023, 7, 27, 2, 20, 28, 711, DateTimeKind.Unspecified).AddTicks(8893), null, null, false, 808m, "TransactionType", 0 },
                    { 10, 2, null, new DateTime(2023, 7, 29, 7, 1, 58, 692, DateTimeKind.Unspecified).AddTicks(526), "Some description", null, true, 817m, "TransactionType", 0 },
                    { 11, 1, null, new DateTime(2023, 7, 29, 7, 39, 23, 713, DateTimeKind.Unspecified).AddTicks(6113), "Some description", null, true, 283m, "TransactionType", 0 },
                    { 12, 2, null, new DateTime(2023, 7, 30, 9, 28, 8, 790, DateTimeKind.Unspecified).AddTicks(7637), "Some description", null, false, 976m, "TransactionType", 1 },
                    { 13, 1, null, new DateTime(2023, 7, 30, 10, 23, 2, 685, DateTimeKind.Unspecified).AddTicks(8692), "Some description", null, false, 895m, "TransactionType", 0 },
                    { 14, 1, "Author", new DateTime(2023, 7, 30, 10, 34, 42, 270, DateTimeKind.Unspecified).AddTicks(6368), "Some description", null, true, 458m, "TransactionType", 1 },
                    { 15, 2, null, new DateTime(2023, 7, 30, 13, 12, 7, 589, DateTimeKind.Unspecified).AddTicks(7055), null, null, true, 57m, "TransactionType", 0 },
                    { 16, 1, "Author", new DateTime(2023, 7, 30, 23, 42, 9, 301, DateTimeKind.Unspecified).AddTicks(3987), null, null, false, 398m, "TransactionType", 0 },
                    { 17, 2, "Author", new DateTime(2023, 7, 31, 22, 44, 51, 4, DateTimeKind.Unspecified).AddTicks(5335), null, null, true, 968m, "TransactionType", 0 },
                    { 18, 1, null, new DateTime(2023, 8, 1, 7, 25, 18, 697, DateTimeKind.Unspecified).AddTicks(1754), null, null, false, 524m, "TransactionType", 1 },
                    { 19, 2, "Author", new DateTime(2023, 8, 2, 8, 2, 12, 253, DateTimeKind.Unspecified).AddTicks(7261), null, null, false, 150m, "TransactionType", 1 },
                    { 20, 2, null, new DateTime(2023, 8, 3, 20, 11, 25, 113, DateTimeKind.Unspecified).AddTicks(875), "Some description", null, false, 545m, "TransactionType", 1 },
                    { 21, 2, "Author", new DateTime(2023, 8, 4, 13, 27, 54, 409, DateTimeKind.Unspecified).AddTicks(4689), "Some description", null, true, 978m, "TransactionType", 1 },
                    { 22, 2, "Author", new DateTime(2023, 8, 6, 20, 49, 33, 130, DateTimeKind.Unspecified).AddTicks(1677), null, null, true, 181m, "TransactionType", 0 },
                    { 23, 1, null, new DateTime(2023, 8, 8, 5, 26, 11, 362, DateTimeKind.Unspecified).AddTicks(8880), "Some description", null, false, 426m, "TransactionType", 1 },
                    { 24, 2, "Author", new DateTime(2023, 8, 8, 22, 9, 18, 283, DateTimeKind.Unspecified).AddTicks(8209), null, null, true, 727m, "TransactionType", 0 },
                    { 25, 2, null, new DateTime(2023, 8, 9, 17, 44, 19, 155, DateTimeKind.Unspecified).AddTicks(2646), null, null, true, 669m, "TransactionType", 1 }
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
