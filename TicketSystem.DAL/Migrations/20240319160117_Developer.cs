using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Developer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentDeveloper",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    DevelopersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentDeveloper", x => new { x.DepartmentsId, x.DevelopersId });
                    table.ForeignKey(
                        name: "FK_DepartmentDeveloper_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentDeveloper_Developer_DevelopersId",
                        column: x => x.DevelopersId,
                        principalTable: "Developer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Developer",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Islam" },
                    { 2, "Amin" },
                    { 3, "Rahaf" },
                    { 4, "Ali" },
                    { 5, "Nassar" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 9, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 3, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 8, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 5, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 10, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentDeveloper_DevelopersId",
                table: "DepartmentDeveloper",
                column: "DevelopersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentDeveloper");

            migrationBuilder.DropTable(
                name: "Developer");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 9, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 3, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 8, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 5, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 10, 13, 46, 38, 308, DateTimeKind.Local).AddTicks(4734));
        }
    }
}
