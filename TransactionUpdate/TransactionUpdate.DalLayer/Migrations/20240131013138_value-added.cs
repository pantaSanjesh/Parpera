using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TransactionUpdate.DalLayer.Migrations
{
    /// <inheritdoc />
    public partial class valueadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: "2020-09-08'T'09:02:23Z");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Bank Deposit");

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "DateTime", "Description", "Status" },
                values: new object[,]
                {
                    { 1, 500.0, "2020-03-30'T'23:53:23Z", "Bank Deposit", "Completed" },
                    { 2, -30.0, "2020-04-01'T'12:47:23Z", "Amazon Online", "Completed" },
                    { 3, 30.0, "2020-04-09'T'16:26:23Z", "Refund", "Completed" },
                    { 4, -167.78, "2020-06-15'T'18:17:23Z", "Country Railways", "Completed" },
                    { 5, -56.43, "2020-08-16'T'21:06:23Z", "Mini Mart", "Completed" },
                    { 6, -23.760000000000002, "2020-08-23'T'17:39:23Z", "Mini Mart", "Completed" },
                    { 7, -2000.0, "2020-09-06'T'07:33:23Z", "Apple Store", "Cancelled" },
                    { 8, -15.0, "2020-09-06'T'10:32:23Z", "Google Subscription", "Completed" },
                    { 9, -20.0, "2020-09-07'T'21:52:23Z", "ATM withdrawal", "Completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: "2021-09-08'T'09:02:23Z");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: " Bank Deposit");
        }
    }
}
