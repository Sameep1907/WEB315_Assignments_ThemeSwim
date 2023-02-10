using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB315_Assignments_ThemeSwim.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThemeSwim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventName = table.Column<string>(type: "TEXT", nullable: true),
                    BookingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Competition = table.Column<string>(type: "TEXT", nullable: true),
                    PoolName = table.Column<string>(type: "TEXT", nullable: true),
                    EntryPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeSwim", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThemeSwim");
        }
    }
}
