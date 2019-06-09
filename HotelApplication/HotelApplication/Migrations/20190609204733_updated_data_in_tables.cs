using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApplication.Migrations
{
    public partial class updated_data_in_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Relief",
                columns: new[] { "Id", "Code", "Discount" },
                values: new object[] { 1, "Summer", 20 });

            migrationBuilder.InsertData(
                table: "Relief",
                columns: new[] { "Id", "Code", "Discount" },
                values: new object[] { 2, "2019", 10 });

            migrationBuilder.InsertData(
                table: "Relief",
                columns: new[] { "Id", "Code", "Discount" },
                values: new object[] { 3, "Holiday", 30 });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Price", "ReliefId" },
                values: new object[] { "d10f33cb-1a0a-4c89-b31b-e34dad3dc9b3", 500f, 1 });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Price", "ReliefId" },
                values: new object[] { "156df5d7-74a0-4566-8530-a49fff63bded", 1000f, 2 });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Price", "ReliefId" },
                values: new object[] { "edb61b22-6c71-4cbf-9704-ec28762b16c2", 300f, 3 });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "EndDate", "PaymentId", "RoomId", "StartDate" },
                values: new object[] { 2, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "d10f33cb-1a0a-4c89-b31b-e34dad3dc9b3", 2, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "EndDate", "PaymentId", "RoomId", "StartDate" },
                values: new object[] { 3, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "156df5d7-74a0-4566-8530-a49fff63bded", 3, new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "EndDate", "PaymentId", "RoomId", "StartDate" },
                values: new object[] { 1, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "edb61b22-6c71-4cbf-9704-ec28762b16c2", 1, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: "156df5d7-74a0-4566-8530-a49fff63bded");

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: "d10f33cb-1a0a-4c89-b31b-e34dad3dc9b3");

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: "edb61b22-6c71-4cbf-9704-ec28762b16c2");

            migrationBuilder.DeleteData(
                table: "Relief",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Relief",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Relief",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
