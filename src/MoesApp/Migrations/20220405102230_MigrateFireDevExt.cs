using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoesApp.Migrations
{
    public partial class MigrateFireDevExt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

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

            migrationBuilder.AlterColumn<string>(
                name: "open_fire_eli_time",
                table: "fire_dev_ext",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "message_time",
                table: "fire_dev_ext",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "local_time",
                table: "fire_dev_ext",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "eli_fire_time",
                table: "fire_dev_ext",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "detection_time",
                table: "fire_dev_ext",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "arrival_time_1st",
                table: "fire_dev_ext",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone",
                oldMaxLength: 4);

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
