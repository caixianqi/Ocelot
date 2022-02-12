using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace IdentityDbContext.Migrations
{
    public partial class initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    is_delete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "serviceregister",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientid = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    secret = table.Column<string>(type: "text", nullable: false),
                    service_name = table.Column<string>(type: "text", nullable: false),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    update_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    is_delete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceregister", x => x.id);
                    table.ForeignKey(
                        name: "FK_serviceregister_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "create_time", "password", "is_delete", "update_time", "username" },
                values: new object[] { "1f69815c-b8eb-4dff-b395-5a8ead375173", new DateTime(2022, 2, 12, 18, 30, 35, 439, DateTimeKind.Local).AddTicks(4572), "f25f9f47e96b27dbe495d59614c0d6b9", false, new DateTime(2022, 2, 12, 18, 30, 35, 440, DateTimeKind.Local).AddTicks(6681), "123" });

            migrationBuilder.CreateIndex(
                name: "IX_serviceregister_UserId",
                table: "serviceregister",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "serviceregister");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
