using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimerParcial.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "PreparationTimeMinutes",
                table: "Recipes",
                newName: "PreparationTime");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Recipes",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<int>(
                name: "CookingTime",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookingTime",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "PreparationTime",
                table: "Recipes",
                newName: "PreparationTimeMinutes");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Recipes",
                newName: "Description");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
