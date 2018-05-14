using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdManager001.Data.Migrations
{
    public partial class CampaignFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Campaign",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BannerImageHieght",
                table: "Campaign",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BannerImageUrl",
                table: "Campaign",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BannerImageWidth",
                table: "Campaign",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Budget",
                table: "Campaign",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ClickUrl",
                table: "Campaign",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Campaign",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Revenue",
                table: "Campaign",
                type: "decimal(3, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImageHieght",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "BannerImageUrl",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "BannerImageWidth",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "ClickUrl",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "Revenue",
                table: "Campaign");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Campaign",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
