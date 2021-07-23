using Microsoft.EntityFrameworkCore.Migrations;

namespace Offers.Data.Migrations
{
    public partial class UpdateYearTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_offerUsers_offerUserId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Year_YearId",
                table: "Offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_offerUsers",
                table: "offerUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Year",
                table: "Year");

            migrationBuilder.RenameTable(
                name: "offerUsers",
                newName: "OfferUsers");

            migrationBuilder.RenameTable(
                name: "Year",
                newName: "Years");

            migrationBuilder.RenameColumn(
                name: "offerUserId",
                table: "Offers",
                newName: "ΟfferUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_offerUserId",
                table: "Offers",
                newName: "IX_Offers_ΟfferUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferUsers",
                table: "OfferUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Years",
                table: "Years",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_OfferUsers_ΟfferUserId",
                table: "Offers",
                column: "ΟfferUserId",
                principalTable: "OfferUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Years_YearId",
                table: "Offers",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_OfferUsers_ΟfferUserId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Years_YearId",
                table: "Offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferUsers",
                table: "OfferUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Years",
                table: "Years");

            migrationBuilder.RenameTable(
                name: "OfferUsers",
                newName: "offerUsers");

            migrationBuilder.RenameTable(
                name: "Years",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "ΟfferUserId",
                table: "Offers",
                newName: "offerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_ΟfferUserId",
                table: "Offers",
                newName: "IX_Offers_offerUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_offerUsers",
                table: "offerUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Year",
                table: "Year",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_offerUsers_offerUserId",
                table: "Offers",
                column: "offerUserId",
                principalTable: "offerUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Year_YearId",
                table: "Offers",
                column: "YearId",
                principalTable: "Year",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
