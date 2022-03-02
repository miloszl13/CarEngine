using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class EngineToEngineTypes_ManyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EngineType_Id",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Engines_EngineType_Id",
                table: "Engines",
                column: "EngineType_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineTypes_EngineType_Id",
                table: "Engines",
                column: "EngineType_Id",
                principalTable: "EngineTypes",
                principalColumn: "EngineType_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineTypes_EngineType_Id",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_EngineType_Id",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "EngineType_Id",
                table: "Engines");
        }
    }
}
