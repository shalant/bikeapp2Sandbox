using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class simplifiedEventmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_BikeRoutes_BikeRouteId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_BikeRouteId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "BikeRouteId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Route",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Route",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BikeRouteId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_BikeRouteId",
                table: "Events",
                column: "BikeRouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_BikeRoutes_BikeRouteId",
                table: "Events",
                column: "BikeRouteId",
                principalTable: "BikeRoutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
