﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddVisitLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Services");
        }
    }
}
