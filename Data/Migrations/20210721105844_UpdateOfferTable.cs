using Microsoft.EntityFrameworkCore.Migrations;

namespace Offers.Data.Migrations
{
    public partial class UpdateOfferTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DromologioId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_DromologioId",
                table: "Offers",
                column: "DromologioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Dromologia_DromologioId",
                table: "Offers",
                column: "DromologioId",
                principalTable: "Dromologia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Dromologia_DromologioId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_DromologioId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "DromologioId",
                table: "Offers");
        }
    }
}
