using Microsoft.EntityFrameworkCore.Migrations;

namespace Offers.Data.Migrations
{
    public partial class UpdateOfferTableAddAditionalFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalFileName",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalFileName",
                table: "Offers");
        }
    }
}
