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
                    Amount = table.Column<double>(type: "float", nullable: false),
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
                    { 1, 2, 431.55828949287343, null, new DateTime(2023, 7, 14, 19, 53, 32, 923, DateTimeKind.Unspecified).AddTicks(4519), null, false, "Credit", 1 },
                    { 2, 2, 752.89816641440848, null, new DateTime(2023, 7, 15, 0, 1, 30, 584, DateTimeKind.Unspecified).AddTicks(9551), null, false, "Payment", 0 },
                    { 3, 1, 136.65546481626367, null, new DateTime(2023, 7, 16, 12, 23, 25, 855, DateTimeKind.Unspecified).AddTicks(2796), "Some description", false, "Credit", 1 },
                    { 4, 1, 614.78075003374215, "Author", new DateTime(2023, 7, 17, 9, 53, 36, 624, DateTimeKind.Unspecified).AddTicks(3160), "Some description", false, "Payment", 0 },
                    { 5, 1, 286.5013193861725, null, new DateTime(2023, 7, 17, 14, 52, 52, 456, DateTimeKind.Unspecified).AddTicks(6969), null, true, "Payment", 0 },
                    { 6, 2, 742.22944112910591, "Author", new DateTime(2023, 7, 17, 17, 48, 26, 252, DateTimeKind.Unspecified).AddTicks(6477), "Some description", true, "Payment", 0 },
                    { 7, 1, 410.35440122955958, null, new DateTime(2023, 7, 17, 23, 57, 11, 885, DateTimeKind.Unspecified).AddTicks(4434), "Some description", true, "Payment", 0 },
                    { 8, 2, 310.14144808382503, "Author", new DateTime(2023, 7, 19, 9, 46, 35, 919, DateTimeKind.Unspecified).AddTicks(5094), "Some description", true, "Credit", 1 },
                    { 9, 2, 169.92004286399754, "Author", new DateTime(2023, 7, 20, 10, 18, 13, 690, DateTimeKind.Unspecified).AddTicks(5536), "Some description", false, "Credit", 1 },
                    { 10, 2, 781.7909220134884, "Author", new DateTime(2023, 7, 21, 4, 22, 34, 744, DateTimeKind.Unspecified).AddTicks(3073), "Some description", false, "Credit", 1 },
                    { 11, 1, 117.0641462311427, "Author", new DateTime(2023, 7, 21, 6, 0, 36, 168, DateTimeKind.Unspecified).AddTicks(4474), null, true, "Payment", 0 },
                    { 12, 2, 259.37918399401462, "Author", new DateTime(2023, 7, 21, 8, 3, 5, 777, DateTimeKind.Unspecified).AddTicks(2441), null, true, "Credit", 1 },
                    { 13, 2, 732.37177752013997, "Author", new DateTime(2023, 7, 23, 15, 36, 40, 683, DateTimeKind.Unspecified).AddTicks(9592), null, false, "Payment", 0 },
                    { 14, 2, 145.90990570224128, null, new DateTime(2023, 7, 25, 15, 53, 30, 2, DateTimeKind.Unspecified).AddTicks(1020), "Some description", true, "Credit", 1 },
                    { 15, 2, 798.73456107013328, null, new DateTime(2023, 7, 26, 6, 37, 31, 643, DateTimeKind.Unspecified).AddTicks(2505), null, false, "Payment", 0 },
                    { 16, 2, 457.52687722887708, "Author", new DateTime(2023, 7, 27, 0, 42, 15, 204, DateTimeKind.Unspecified).AddTicks(3344), "Some description", false, "Credit", 1 },
                    { 17, 1, 293.00126427052106, "Author", new DateTime(2023, 7, 29, 17, 15, 25, 804, DateTimeKind.Unspecified).AddTicks(4360), "Some description", true, "Credit", 1 },
                    { 18, 1, 834.41976149839206, null, new DateTime(2023, 7, 30, 6, 20, 36, 517, DateTimeKind.Unspecified).AddTicks(3236), "Some description", true, "Payment", 0 },
                    { 19, 2, 480.8097543924107, null, new DateTime(2023, 7, 30, 7, 39, 14, 947, DateTimeKind.Unspecified).AddTicks(8521), "Some description", false, "Credit", 1 },
                    { 20, 1, 685.38987353245489, null, new DateTime(2023, 7, 31, 1, 24, 11, 934, DateTimeKind.Unspecified).AddTicks(9608), null, true, "Credit", 1 },
                    { 21, 1, 577.78645521163958, "Author", new DateTime(2023, 8, 1, 0, 40, 55, 556, DateTimeKind.Unspecified).AddTicks(2356), null, true, "Credit", 1 },
                    { 22, 2, 366.95248323106352, "Author", new DateTime(2023, 8, 2, 6, 45, 57, 939, DateTimeKind.Unspecified).AddTicks(2677), "Some description", false, "Credit", 1 },
                    { 23, 1, 447.22053162162047, "Author", new DateTime(2023, 8, 6, 0, 26, 43, 889, DateTimeKind.Unspecified).AddTicks(9766), "Some description", false, "Credit", 1 },
                    { 24, 1, 743.30673175927404, "Author", new DateTime(2023, 8, 7, 11, 33, 20, 303, DateTimeKind.Unspecified).AddTicks(8303), "Some description", false, "Payment", 0 },
                    { 25, 1, 701.90706983360315, null, new DateTime(2023, 8, 12, 12, 9, 1, 27, DateTimeKind.Unspecified).AddTicks(5258), null, false, "Credit", 1 }
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
