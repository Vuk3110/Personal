using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baza.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Karte",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MestoPolaska = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MestoDolaska = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VremePolaska = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karte", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karte");
        }
    }
}
