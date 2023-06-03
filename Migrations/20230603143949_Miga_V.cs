using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class Miga_V : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketFlower_Flower_FlowersFlowerId",
                table: "BasketFlower");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketSoftToy_SoftToy_softToysSoftToyId",
                table: "BasketSoftToy");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoftToy",
                table: "SoftToy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flower",
                table: "Flower");

            migrationBuilder.RenameTable(
                name: "SoftToy",
                newName: "SoftToys");

            migrationBuilder.RenameTable(
                name: "Flower",
                newName: "Flowers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoftToys",
                table: "SoftToys",
                column: "SoftToyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flowers",
                table: "Flowers",
                column: "FlowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketFlower_Flowers_FlowersFlowerId",
                table: "BasketFlower",
                column: "FlowersFlowerId",
                principalTable: "Flowers",
                principalColumn: "FlowerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketSoftToy_SoftToys_softToysSoftToyId",
                table: "BasketSoftToy",
                column: "softToysSoftToyId",
                principalTable: "SoftToys",
                principalColumn: "SoftToyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketFlower_Flowers_FlowersFlowerId",
                table: "BasketFlower");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketSoftToy_SoftToys_softToysSoftToyId",
                table: "BasketSoftToy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoftToys",
                table: "SoftToys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flowers",
                table: "Flowers");

            migrationBuilder.RenameTable(
                name: "SoftToys",
                newName: "SoftToy");

            migrationBuilder.RenameTable(
                name: "Flowers",
                newName: "Flower");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoftToy",
                table: "SoftToy",
                column: "SoftToyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flower",
                table: "Flower",
                column: "FlowerId");

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BasketFlower_Flower_FlowersFlowerId",
                table: "BasketFlower",
                column: "FlowersFlowerId",
                principalTable: "Flower",
                principalColumn: "FlowerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketSoftToy_SoftToy_softToysSoftToyId",
                table: "BasketSoftToy",
                column: "softToysSoftToyId",
                principalTable: "SoftToy",
                principalColumn: "SoftToyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
