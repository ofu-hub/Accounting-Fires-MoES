using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrganCode = table.Column<string>(nullable: true),
                    DateOfFire = table.Column<DateTime>(nullable: false),
                    TypeOfSettlement = table.Column<string>(nullable: true),
                    TypeOfFireDepSettlement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileRepots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    GeneralInfoId = table.Column<Guid>(nullable: false),
                    _GeneralInfoId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileRepots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileRepots_GeneralInformations_GeneralInfoId",
                        column: x => x.GeneralInfoId,
                        principalTable: "GeneralInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileRepots_GeneralInformations__GeneralInfoId1",
                        column: x => x._GeneralInfoId1,
                        principalTable: "GeneralInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileRepots_GeneralInfoId",
                table: "FileRepots",
                column: "GeneralInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_FileRepots__GeneralInfoId1",
                table: "FileRepots",
                column: "_GeneralInfoId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileRepots");

            migrationBuilder.DropTable(
                name: "GeneralInformations");
        }
    }
}
