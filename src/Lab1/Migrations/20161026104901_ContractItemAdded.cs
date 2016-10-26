using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Migrations
{
    public partial class ContractItemAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "ContractItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ContractItems_ContractId",
                table: "ContractItems",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractItems_Contracts_ContractId",
                table: "ContractItems",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractItems_Contracts_ContractId",
                table: "ContractItems");

            migrationBuilder.DropIndex(
                name: "IX_ContractItems_ContractId",
                table: "ContractItems");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "ContractItems");
        }
    }
}
