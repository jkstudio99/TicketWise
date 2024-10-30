using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_AssignedToId",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "RaisedBy",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AssignedToId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountConfirmed", "Avartar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", 0, false, null, "564b9fe1-0ece-40d1-8693-b2decff536a5", "Test@gmail.com", true, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAIAAYagAAAAEHF7ngQTD1dcQzdXo1rEv1vMmVO6VLqTj+1KvK/Ei+SUDFS+1JoV1o2oN7XJ0lgRTg==", null, false, "5465e157-2271-4cff-bf12-839d794cdc04", false, "Test@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Application Bug" },
                    { 2, "Network Issue" },
                    { 3, "User Issue" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "ExpectedDays", "PriorityName" },
                values: new object[,]
                {
                    { 1, 14, "Low" },
                    { 2, 7, "Medium" },
                    { 3, 1, "High" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName" },
                values: new object[,]
                {
                    { 1, "Product 1" },
                    { 2, "Product 2" },
                    { 3, "Product 3" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssignedToId", "CategoryId", "Description", "ExpectedDate", "PriorityId", "ProductId", "RaisedBy", "RaisedDate", "Status", "Summary" },
                values: new object[,]
                {
                    { 1, null, 1, "Description for ticket 1", new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 1" },
                    { 2, null, 2, "Description for ticket 2", new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 2" },
                    { 3, null, 1, "Description for ticket 3", new DateTime(2024, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 3" },
                    { 4, null, 2, "Description for ticket 4", new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 4" },
                    { 5, null, 3, "Description for ticket 5", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 5" },
                    { 6, null, 1, "Description for ticket 6", new DateTime(2024, 9, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 6" },
                    { 7, null, 2, "Description for ticket 7", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 7" },
                    { 8, null, 3, "Description for ticket 8", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 8" },
                    { 9, null, 1, "Description for ticket 9", new DateTime(2024, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 9" },
                    { 10, null, 2, "Description for ticket 10", new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 10" },
                    { 11, null, 3, "Description for ticket 11", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 11" },
                    { 12, null, 1, "Description for ticket 12", new DateTime(2024, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 12" },
                    { 13, null, 2, "Description for ticket 13", new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 13" },
                    { 14, null, 3, "Description for ticket 14", new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 14" },
                    { 15, null, 1, "Description for ticket 15", new DateTime(2024, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 15" },
                    { 16, null, 2, "Description for ticket 16", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 16" },
                    { 17, null, 3, "Description for ticket 17", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 17" },
                    { 18, null, 1, "Description for ticket 18", new DateTime(2024, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 18" },
                    { 19, null, 2, "Description for ticket 19", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 19" },
                    { 20, null, 3, "Description for ticket 20", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 20" },
                    { 21, null, 2, "Description for ticket 21", new DateTime(2024, 6, 10, 7, 40, 49, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 6, 5, 7, 40, 49, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 21" },
                    { 22, null, 2, "Description for ticket 22", new DateTime(2023, 11, 6, 23, 56, 10, 0, DateTimeKind.Unspecified), 3, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 11, 6, 15, 56, 10, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 22" },
                    { 23, null, 3, "Description for ticket 23", new DateTime(2023, 10, 9, 16, 10, 57, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 10, 1, 16, 10, 57, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 23" },
                    { 24, null, 2, "Description for ticket 24", new DateTime(2023, 10, 24, 3, 16, 57, 0, DateTimeKind.Unspecified), 3, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 10, 23, 19, 16, 57, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 24" },
                    { 25, null, 1, "Description for ticket 25", new DateTime(2023, 11, 27, 4, 18, 47, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 11, 22, 4, 18, 47, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 25" },
                    { 26, null, 1, "Description for ticket 26", new DateTime(2024, 6, 7, 0, 28, 17, 0, DateTimeKind.Unspecified), 1, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 5, 30, 0, 28, 17, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 26" },
                    { 27, null, 2, "Description for ticket 27", new DateTime(2024, 5, 10, 20, 13, 4, 0, DateTimeKind.Unspecified), 1, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 5, 2, 20, 13, 4, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 27" },
                    { 28, null, 3, "Description for ticket 28", new DateTime(2024, 7, 28, 21, 1, 34, 0, DateTimeKind.Unspecified), 3, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 7, 28, 13, 1, 34, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 28" },
                    { 29, null, 2, "Description for ticket 29", new DateTime(2023, 10, 6, 9, 3, 20, 0, DateTimeKind.Unspecified), 2, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 10, 1, 9, 3, 20, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 29" },
                    { 30, null, 2, "Description for ticket 30", new DateTime(2024, 4, 26, 18, 56, 12, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 4, 21, 18, 56, 12, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 30" },
                    { 31, null, 2, "Description for ticket 31", new DateTime(2023, 12, 5, 11, 40, 49, 0, DateTimeKind.Unspecified), 3, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 12, 5, 3, 40, 49, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 31" },
                    { 32, null, 1, "Description for ticket 32", new DateTime(2023, 8, 15, 12, 50, 18, 0, DateTimeKind.Unspecified), 2, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 8, 10, 12, 50, 18, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 32" },
                    { 33, null, 3, "Description for ticket 33", new DateTime(2023, 8, 6, 5, 16, 30, 0, DateTimeKind.Unspecified), 1, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 7, 29, 5, 16, 30, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 33" },
                    { 34, null, 1, "Description for ticket 34", new DateTime(2023, 12, 25, 14, 40, 25, 0, DateTimeKind.Unspecified), 3, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 12, 25, 6, 40, 25, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 34" },
                    { 35, null, 2, "Description for ticket 35", new DateTime(2023, 8, 7, 11, 10, 42, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 7, 30, 11, 10, 42, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 35" },
                    { 36, null, 3, "Description for ticket 36", new DateTime(2024, 1, 1, 4, 36, 12, 0, DateTimeKind.Unspecified), 3, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 12, 31, 20, 36, 12, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 36" },
                    { 37, null, 1, "Description for ticket 37", new DateTime(2023, 9, 6, 12, 11, 15, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 9, 1, 12, 11, 15, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 37" },
                    { 38, null, 2, "Description for ticket 38", new DateTime(2023, 10, 20, 10, 43, 29, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 10, 12, 10, 43, 29, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 38" },
                    { 39, null, 3, "Description for ticket 39", new DateTime(2024, 7, 20, 8, 50, 11, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 7, 15, 8, 50, 11, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 39" },
                    { 40, null, 2, "Description for ticket 40", new DateTime(2024, 4, 22, 17, 28, 30, 0, DateTimeKind.Unspecified), 3, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 4, 22, 9, 28, 30, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 40" },
                    { 41, null, 1, "Description for ticket 41", new DateTime(2023, 9, 22, 14, 15, 30, 0, DateTimeKind.Unspecified), 1, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 9, 14, 14, 15, 30, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 41" },
                    { 42, null, 3, "Description for ticket 42", new DateTime(2023, 12, 8, 11, 23, 18, 0, DateTimeKind.Unspecified), 2, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 12, 3, 11, 23, 18, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 42" },
                    { 43, null, 2, "Description for ticket 43", new DateTime(2023, 10, 27, 22, 19, 44, 0, DateTimeKind.Unspecified), 3, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 10, 22, 16, 19, 44, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 43" },
                    { 44, null, 1, "Description for ticket 44", new DateTime(2023, 11, 15, 9, 7, 55, 0, DateTimeKind.Unspecified), 1, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 11, 7, 9, 7, 55, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 44" },
                    { 45, null, 2, "Description for ticket 45", new DateTime(2023, 7, 23, 12, 41, 29, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 7, 18, 12, 41, 29, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 45" },
                    { 46, null, 3, "Description for ticket 46", new DateTime(2023, 9, 5, 18, 56, 11, 0, DateTimeKind.Unspecified), 3, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 9, 5, 10, 56, 11, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 46" },
                    { 47, null, 1, "Description for ticket 47", new DateTime(2024, 4, 22, 13, 13, 30, 0, DateTimeKind.Unspecified), 1, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 4, 14, 13, 13, 30, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 47" },
                    { 48, null, 3, "Description for ticket 48", new DateTime(2024, 2, 13, 17, 12, 15, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 2, 8, 17, 12, 15, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 48" },
                    { 49, null, 2, "Description for ticket 49", new DateTime(2024, 3, 16, 15, 45, 48, 0, DateTimeKind.Unspecified), 3, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 3, 16, 7, 45, 48, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 49" },
                    { 50, null, 1, "Description for ticket 50", new DateTime(2023, 12, 3, 16, 19, 33, 0, DateTimeKind.Unspecified), 1, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 11, 25, 16, 19, 33, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 50" },
                    { 51, null, 3, "Description for ticket 51", new DateTime(2023, 10, 9, 15, 26, 21, 0, DateTimeKind.Unspecified), 1, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 10, 1, 15, 26, 21, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 51" },
                    { 52, null, 2, "Description for ticket 52", new DateTime(2023, 10, 4, 8, 30, 17, 0, DateTimeKind.Unspecified), 2, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 9, 29, 8, 30, 17, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 52" },
                    { 53, null, 3, "Description for ticket 53", new DateTime(2024, 1, 13, 22, 36, 48, 0, DateTimeKind.Unspecified), 3, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 1, 13, 14, 36, 48, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 53" },
                    { 54, null, 1, "Description for ticket 54", new DateTime(2023, 8, 26, 10, 17, 29, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 8, 21, 10, 17, 29, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 54" },
                    { 55, null, 3, "Description for ticket 55", new DateTime(2024, 5, 20, 13, 59, 36, 0, DateTimeKind.Unspecified), 3, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 5, 20, 5, 59, 36, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 55" },
                    { 56, null, 2, "Description for ticket 56", new DateTime(2023, 11, 27, 16, 23, 9, 0, DateTimeKind.Unspecified), 1, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 11, 19, 16, 23, 9, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 56" },
                    { 57, null, 1, "Description for ticket 57", new DateTime(2023, 8, 15, 9, 40, 13, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 8, 10, 9, 40, 13, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 57" },
                    { 58, null, 3, "Description for ticket 58", new DateTime(2023, 11, 7, 11, 7, 25, 0, DateTimeKind.Unspecified), 1, 1, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 10, 30, 11, 7, 25, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 58" },
                    { 59, null, 2, "Description for ticket 59", new DateTime(2024, 6, 15, 20, 19, 44, 0, DateTimeKind.Unspecified), 3, 2, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 6, 15, 12, 19, 44, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 59" },
                    { 60, null, 1, "Description for ticket 60", new DateTime(2023, 9, 7, 18, 24, 59, 0, DateTimeKind.Unspecified), 2, 3, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2023, 9, 2, 18, 24, 59, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 60" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_AssignedToId",
                table: "Tickets",
                column: "AssignedToId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_AssignedToId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "RaisedBy",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssignedToId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_AssignedToId",
                table: "Tickets",
                column: "AssignedToId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
