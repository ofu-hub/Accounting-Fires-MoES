using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WpfApp1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fire_consequences",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    people_died_all = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    people_died_kids = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    people_died_work = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    people_injured_all = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    people_injured_kids = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    people_injured_work = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    m_fire_damage = table.Column<decimal>(type: "numeric(12)", precision: 12, nullable: false),
                    build_dest = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    build_dam = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    apart_dest = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    apart_dam = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fire_consequences", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fire_dev_ext",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    detection_time = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    message_time = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    arrival_time_1st = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    local_time = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    open_fire_eli_time = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    eli_fire_time = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    liquidation_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fire_dev_ext", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fire_forces_means",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    firefighters = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    technique = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    num_technique = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    individ_protect = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    water_on_fire = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    fire_ext_manager = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    fire_fighting_head = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    investigative_team = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    fire_ext_agents = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    primary_fire_equip = table.Column<string[]>(type: "character varying(2)[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fire_forces_means", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fire_obj",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    subject = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    sub_type_owner = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    obj_risk = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    kind_fire_obj = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    name_fire_obj = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    floors_obj = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    floor_where_fire = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    location_fire = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    cause_fire = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    guilty_person = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    attitude_person = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    state_person = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fire_obj", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fire_rescued",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    people_saved = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    people_evacuated = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    cattle_large = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    cattle_small = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    technique = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    mat_values = table.Column<decimal>(type: "numeric(12)", precision: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fire_rescued", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gen_info",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    org_code = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    datefire = table.Column<DateOnly>(type: "date", nullable: false),
                    typesett_code = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    typefiresett_code = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gen_info", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "info_dead_a_injured",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    gender_dead = table.Column<string[]>(type: "character varying(1)[]", nullable: false),
                    soc_status = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    education_dead = table.Column<string[]>(type: "character varying(1)[]", nullable: false),
                    cause_dead = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    terms_dead = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    moment_dead = table.Column<string[]>(type: "character varying(1)[]", nullable: false),
                    terms_injury = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    harm_health = table.Column<string[]>(type: "character varying(2)[]", nullable: false),
                    age_dead = table.Column<string[]>(type: "character varying(3)[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_info_dead_a_injured", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "file_reports",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    geninfo_id = table.Column<int>(type: "integer", nullable: false),
                    fireobj_id = table.Column<int>(type: "integer", nullable: false),
                    firecons_id = table.Column<int>(type: "integer", nullable: false),
                    firerescued_id = table.Column<int>(type: "integer", nullable: false),
                    firedae_id = table.Column<int>(type: "integer", nullable: false),
                    fireforc_id = table.Column<int>(type: "integer", nullable: false),
                    infodai_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_reports", x => x.id);
                    table.ForeignKey(
                        name: "file_reports_firecons_id_fkey",
                        column: x => x.firecons_id,
                        principalTable: "fire_consequences",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "file_reports_firedae_id_fkey",
                        column: x => x.firedae_id,
                        principalTable: "fire_dev_ext",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "file_reports_fireforc_id_fkey",
                        column: x => x.fireforc_id,
                        principalTable: "fire_forces_means",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "file_reports_fireobj_id_fkey",
                        column: x => x.fireobj_id,
                        principalTable: "fire_obj",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "file_reports_firerescued_id_fkey",
                        column: x => x.firerescued_id,
                        principalTable: "fire_rescued",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "file_reports_geninfo_id_fkey",
                        column: x => x.geninfo_id,
                        principalTable: "gen_info",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "file_reports_infodai_id_fkey",
                        column: x => x.infodai_id,
                        principalTable: "info_dead_a_injured",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_file_reports_firecons_id",
                table: "file_reports",
                column: "firecons_id");

            migrationBuilder.CreateIndex(
                name: "IX_file_reports_firedae_id",
                table: "file_reports",
                column: "firedae_id");

            migrationBuilder.CreateIndex(
                name: "IX_file_reports_fireforc_id",
                table: "file_reports",
                column: "fireforc_id");

            migrationBuilder.CreateIndex(
                name: "IX_file_reports_fireobj_id",
                table: "file_reports",
                column: "fireobj_id");

            migrationBuilder.CreateIndex(
                name: "IX_file_reports_firerescued_id",
                table: "file_reports",
                column: "firerescued_id");

            migrationBuilder.CreateIndex(
                name: "IX_file_reports_geninfo_id",
                table: "file_reports",
                column: "geninfo_id");

            migrationBuilder.CreateIndex(
                name: "IX_file_reports_infodai_id",
                table: "file_reports",
                column: "infodai_id");
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
