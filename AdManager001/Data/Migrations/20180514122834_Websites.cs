using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdManager001.Data.Migrations
{
    public partial class Websites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Zone",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdPlacementHeight",
                table: "Zone",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdPlacementWidth",
                table: "Zone",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WebsiteId",
                table: "Zone",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Website",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactEmail = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Website", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Website_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zone_WebsiteId",
                table: "Zone",
                column: "WebsiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Website_UserId",
                table: "Website",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zone_Website_WebsiteId",
                table: "Zone",
                column: "WebsiteId",
                principalTable: "Website",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zone_Website_WebsiteId",
                table: "Zone");

            migrationBuilder.DropTable(
                name: "Website");

            migrationBuilder.DropIndex(
                name: "IX_Zone_WebsiteId",
                table: "Zone");

            migrationBuilder.DropColumn(
                name: "AdPlacementHeight",
                table: "Zone");

            migrationBuilder.DropColumn(
                name: "AdPlacementWidth",
                table: "Zone");

            migrationBuilder.DropColumn(
                name: "WebsiteId",
                table: "Zone");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Zone",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
