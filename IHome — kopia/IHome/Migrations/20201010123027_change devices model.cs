using Microsoft.EntityFrameworkCore.Migrations;

namespace IHome.Migrations
{
    public partial class changedevicesmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Buildings_BuildingsID",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_BuildingsID",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "BuildingsID",
                table: "Devices");

            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "Devices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_BuildingId",
                table: "Devices",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Buildings_BuildingId",
                table: "Devices",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Buildings_BuildingId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_BuildingId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "Devices");

            migrationBuilder.AddColumn<int>(
                name: "BuildingsID",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_BuildingsID",
                table: "Devices",
                column: "BuildingsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Buildings_BuildingsID",
                table: "Devices",
                column: "BuildingsID",
                principalTable: "Buildings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
