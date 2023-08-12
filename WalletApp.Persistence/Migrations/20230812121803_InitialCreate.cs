using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    TransactionType = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsPending = table.Column<bool>(type: "boolean", nullable: false),
                    AuthorizedUser = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: false)
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
                    { 1, 1, 562.35865511716941, null, new DateTime(2023, 7, 14, 2, 12, 20, 702, DateTimeKind.Utc).AddTicks(8244), "Some description", false, "Payment", 0 },
                    { 2, 2, 751.04030737259302, "Author", new DateTime(2023, 7, 14, 6, 37, 50, 479, DateTimeKind.Utc).AddTicks(7303), "Some description", false, "Credit", 1 },
                    { 3, 1, 816.34156715047607, null, new DateTime(2023, 7, 17, 19, 22, 3, 569, DateTimeKind.Utc).AddTicks(7546), null, true, "Payment", 0 },
                    { 4, 2, 373.45784739725116, "Author", new DateTime(2023, 7, 17, 23, 38, 43, 123, DateTimeKind.Utc).AddTicks(3109), "Some description", true, "Payment", 0 },
                    { 5, 2, 128.29510480446126, null, new DateTime(2023, 7, 20, 3, 6, 52, 444, DateTimeKind.Utc).AddTicks(4331), null, true, "Payment", 0 },
                    { 6, 1, 801.15362846393487, null, new DateTime(2023, 7, 21, 17, 15, 57, 707, DateTimeKind.Utc).AddTicks(8131), null, true, "Payment", 0 },
                    { 7, 1, 748.40653567072707, null, new DateTime(2023, 7, 23, 4, 30, 16, 364, DateTimeKind.Utc).AddTicks(84), null, true, "Payment", 0 },
                    { 8, 1, 677.09075097505365, "Author", new DateTime(2023, 7, 23, 8, 29, 52, 993, DateTimeKind.Utc).AddTicks(9124), "Some description", true, "Credit", 1 },
                    { 9, 2, 737.13427450123299, "Author", new DateTime(2023, 7, 24, 15, 36, 51, 371, DateTimeKind.Utc).AddTicks(4724), "Some description", true, "Payment", 0 },
                    { 10, 1, 400.86128354186343, null, new DateTime(2023, 7, 25, 1, 9, 53, 73, DateTimeKind.Utc).AddTicks(562), null, false, "Payment", 0 },
                    { 11, 1, 269.6238954904062, null, new DateTime(2023, 7, 26, 2, 59, 15, 535, DateTimeKind.Utc).AddTicks(9179), "Some description", false, "Credit", 1 },
                    { 12, 1, 70.643189356359713, "Author", new DateTime(2023, 7, 27, 0, 56, 57, 788, DateTimeKind.Utc).AddTicks(913), null, false, "Credit", 1 },
                    { 13, 1, 872.66651782325721, "Author", new DateTime(2023, 7, 27, 19, 23, 43, 669, DateTimeKind.Utc).AddTicks(8738), "Some description", true, "Payment", 0 },
                    { 14, 1, 243.79243895584946, null, new DateTime(2023, 7, 28, 16, 18, 57, 628, DateTimeKind.Utc).AddTicks(7483), null, false, "Payment", 0 },
                    { 15, 1, 181.49936471279858, null, new DateTime(2023, 7, 29, 10, 53, 29, 2, DateTimeKind.Utc).AddTicks(5098), null, false, "Credit", 1 },
                    { 16, 2, 266.6906715060735, null, new DateTime(2023, 7, 31, 8, 23, 8, 409, DateTimeKind.Utc).AddTicks(817), "Some description", true, "Payment", 0 },
                    { 17, 1, 945.35667221486437, "Author", new DateTime(2023, 8, 1, 21, 14, 41, 530, DateTimeKind.Utc).AddTicks(1540), "Some description", true, "Credit", 1 },
                    { 18, 1, 198.22470493995715, null, new DateTime(2023, 8, 2, 4, 19, 10, 523, DateTimeKind.Utc).AddTicks(9882), null, true, "Credit", 1 },
                    { 19, 2, 243.17450290417364, null, new DateTime(2023, 8, 3, 6, 38, 38, 779, DateTimeKind.Utc).AddTicks(2575), "Some description", true, "Payment", 0 },
                    { 20, 1, 651.0058867785342, null, new DateTime(2023, 8, 7, 7, 41, 50, 240, DateTimeKind.Utc).AddTicks(6240), null, false, "Payment", 0 },
                    { 21, 1, 1.5396009295891577, null, new DateTime(2023, 8, 8, 8, 55, 30, 265, DateTimeKind.Utc).AddTicks(7789), "Some description", true, "Credit", 1 },
                    { 22, 2, 213.58240647180426, null, new DateTime(2023, 8, 9, 9, 54, 37, 141, DateTimeKind.Utc).AddTicks(2601), null, false, "Credit", 1 },
                    { 23, 2, 608.95819578494047, "Author", new DateTime(2023, 8, 11, 7, 37, 27, 874, DateTimeKind.Utc).AddTicks(6631), "Some description", true, "Payment", 0 },
                    { 24, 2, 718.00568307686217, null, new DateTime(2023, 8, 11, 10, 59, 13, 991, DateTimeKind.Utc).AddTicks(4729), "Some description", false, "Payment", 0 },
                    { 25, 2, 360.94761054793111, "Author", new DateTime(2023, 8, 11, 23, 37, 45, 142, DateTimeKind.Utc).AddTicks(77), null, true, "Credit", 1 }
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
