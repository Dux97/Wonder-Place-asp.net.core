using Microsoft.EntityFrameworkCore.Migrations;

namespace WonderPlace.Migrations
{
    public partial class userID_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Place",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Place",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Place");
        }
    }
}
