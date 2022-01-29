using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityDbContext.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "serviceregister",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    secret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    service_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    create_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_delete = table.Column<bool>(type: "bit", nullable: false),
                    creator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceregister", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "serviceregister");
        }
    }
}
