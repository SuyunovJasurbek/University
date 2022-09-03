using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class uniersity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "universeties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Rooms = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Adres = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    AccountNumber = table.Column<ulong>(type: "INTEGER", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universeties", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "universeties");
        }
    }
}
