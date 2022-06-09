using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmTicketReservation.Data.Migrations
{
    public partial class FixOrderDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MovieId",
                table: "Orders",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Movies_MovieId",
                table: "Orders",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Movies_MovieId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MovieId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Orders");
        }
    }
}
