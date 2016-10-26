using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Farm");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Farm",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Farm");

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Farm",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
