using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Migrations
{
    /// <inheritdoc />
    public partial class RunnerProfiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RunnerProfiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    JoinedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsModerator = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunnerProfiles", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RunnerProfiles");
        }
    }
}
