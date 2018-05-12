using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdManager001.Data.Migrations
{
    public partial class ZoneUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Zone",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zone_UserId",
                table: "Zone",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zone_AspNetUsers_UserId",
                table: "Zone",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zone_AspNetUsers_UserId",
                table: "Zone");

            migrationBuilder.DropIndex(
                name: "IX_Zone_UserId",
                table: "Zone");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Zone");
        }
    }
}
