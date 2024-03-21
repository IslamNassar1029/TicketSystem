using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Finance" },
                    { 4, "Marketing" },
                    { 5, "Operations" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "Email", "IsClosed", "Severity" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 4, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4647), 3, "user1@example.com", false, 0 },
                    { 2, new DateTime(2024, 3, 9, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4714), 2, "user2@example.com", true, 1 },
                    { 3, new DateTime(2024, 3, 3, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4717), 1, "user3@example.com", false, 2 },
                    { 4, new DateTime(2024, 3, 8, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4719), 3, "user4@example.com", false, 2 },
                    { 5, new DateTime(2024, 3, 5, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4721), 2, "user5@example.com", true, 0 },
                    { 6, new DateTime(2024, 3, 12, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4725), 1, "user6@example.com", true, 1 },
                    { 7, new DateTime(2024, 3, 15, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4727), 5, "user7@example.com", true, 0 },
                    { 8, new DateTime(2024, 3, 7, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4729), 2, "user8@example.com", false, 1 },
                    { 9, new DateTime(2024, 3, 6, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4731), 4, "user9@example.com", false, 1 },
                    { 10, new DateTime(2024, 3, 10, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4734), 3, "user10@example.com", true, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DepartmentId",
                table: "Tickets",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
