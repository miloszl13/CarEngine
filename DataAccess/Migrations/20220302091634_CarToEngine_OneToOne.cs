using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class CarToEngine_OneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Car_Id",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Engines_Car_Id",
                table: "Engines",
                column: "Car_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_Cars_Car_Id",
                table: "Engines",
                column: "Car_Id",
                principalTable: "Cars",
                principalColumn: "Car_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_Cars_Car_Id",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_Car_Id",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "Car_Id",
                table: "Engines");
        }
    }
}
