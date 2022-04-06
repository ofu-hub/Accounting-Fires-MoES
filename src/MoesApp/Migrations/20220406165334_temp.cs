using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoesApp.Migrations
{
    public partial class temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "arrival_time_1st",
                table: "fire_dev_ext");

            migrationBuilder.DropColumn(
                name: "detection_time",
                table: "fire_dev_ext");

            migrationBuilder.DropColumn(
                name: "eli_fire_time",
                table: "fire_dev_ext");

            migrationBuilder.DropColumn(
                name: "local_time",
                table: "fire_dev_ext");

            migrationBuilder.DropColumn(
                name: "message_time",
                table: "fire_dev_ext");

            migrationBuilder.DropColumn(
                name: "open_fire_eli_time",
                table: "fire_dev_ext");

            migrationBuilder.AlterColumn<decimal>(
                name: "mat_values",
                table: "fire_rescued",
                type: "numeric(12)",
                precision: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(12,0)",
                oldPrecision: 12);

            migrationBuilder.AlterColumn<decimal>(
                name: "m_fire_damage",
                table: "fire_consequences",
                type: "numeric(12)",
                precision: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(12,0)",
                oldPrecision: 12);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "mat_values",
                table: "fire_rescued",
                type: "numeric(12,0)",
                precision: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(12)",
                oldPrecision: 12);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "arrival_time_1st",
                table: "fire_dev_ext",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "detection_time",
                table: "fire_dev_ext",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "eli_fire_time",
                table: "fire_dev_ext",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "local_time",
                table: "fire_dev_ext",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "message_time",
                table: "fire_dev_ext",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "open_fire_eli_time",
                table: "fire_dev_ext",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AlterColumn<decimal>(
                name: "m_fire_damage",
                table: "fire_consequences",
                type: "numeric(12,0)",
                precision: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(12)",
                oldPrecision: 12);
        }
    }
}
