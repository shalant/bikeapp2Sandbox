using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedBikeRoutetoBikeRoutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeRoute",
                table: "BikeRoute");

            migrationBuilder.RenameTable(
                name: "BikeRoute",
                newName: "BikeRoutes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeRoutes",
                table: "BikeRoutes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikeRouteId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_BikeRoutes_BikeRouteId",
                        column: x => x.BikeRouteId,
                        principalTable: "BikeRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_BikeRouteId",
                table: "Events",
                column: "BikeRouteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeRoutes",
                table: "BikeRoutes");

            migrationBuilder.RenameTable(
                name: "BikeRoutes",
                newName: "BikeRoute");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeRoute",
                table: "BikeRoute",
                column: "Id");
        }
    }
}
