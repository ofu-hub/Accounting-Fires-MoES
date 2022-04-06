using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MoesApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "file_reports");

            migrationBuilder.DropTable(
                name: "fire_consequences");

            migrationBuilder.DropTable(
                name: "fire_dev_ext");

            migrationBuilder.DropTable(
                name: "fire_forces_means");

            migrationBuilder.DropTable(
                name: "fire_obj");

            migrationBuilder.DropTable(
                name: "fire_rescued");

            migrationBuilder.DropTable(
                name: "gen_info");

            migrationBuilder.DropTable(
                name: "info_dead_a_injured");
        }
    }
}
