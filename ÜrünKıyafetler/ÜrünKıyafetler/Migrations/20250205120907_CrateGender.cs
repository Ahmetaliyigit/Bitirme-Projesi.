using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ÜrünKıyafetler.Migrations
{
    /// <inheritdoc />
    public partial class CrateGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jackets_Gender_GenderId",
                table: "Jackets");

            migrationBuilder.DropForeignKey(
                name: "FK_pants_Gender_GenderId",
                table: "pants");

            migrationBuilder.DropForeignKey(
                name: "FK_Shirts_Gender_GenderId",
                table: "Shirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_Gender_GenderId",
                table: "Tshirts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jackets_Genders_GenderId",
                table: "Jackets",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pants_Genders_GenderId",
                table: "pants",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shirts_Genders_GenderId",
                table: "Shirts",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_Genders_GenderId",
                table: "Tshirts",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jackets_Genders_GenderId",
                table: "Jackets");

            migrationBuilder.DropForeignKey(
                name: "FK_pants_Genders_GenderId",
                table: "pants");

            migrationBuilder.DropForeignKey(
                name: "FK_Shirts_Genders_GenderId",
                table: "Shirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_Genders_GenderId",
                table: "Tshirts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jackets_Gender_GenderId",
                table: "Jackets",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pants_Gender_GenderId",
                table: "pants",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shirts_Gender_GenderId",
                table: "Shirts",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_Gender_GenderId",
                table: "Tshirts",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
