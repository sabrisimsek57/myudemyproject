using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccsessLayer.Migrations
{
    public partial class mig323241 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "bookings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "bookings");
        }
    }
}
