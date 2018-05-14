using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdManager001.Data.Migrations
{
    public partial class CampaignBannerImageHeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BannerImageHieght",
                table: "Campaign",
                newName: "BannerImageHeight");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BannerImageHeight",
                table: "Campaign",
                newName: "BannerImageHieght");
        }
    }
}
