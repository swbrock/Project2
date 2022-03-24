using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeId",
                keyValue: 2,
                column: "IsAvailable",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "TimeId",
                keyValue: 2,
                column: "IsAvailable",
                value: true);
        }
    }
}
