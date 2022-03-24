using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Day = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeId);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    TimeId = table.Column<int>(nullable: false),
                    TimeSlotTimeId = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_TimeSlots_TimeSlotTimeId",
                        column: x => x.TimeSlotTimeId,
                        principalTable: "TimeSlots",
                        principalColumn: "TimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 1, "Monday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 76, "Friday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 75, "Friday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 74, "Friday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 73, "Friday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 72, "Friday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 71, "Friday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 70, "Friday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 69, "Friday", true, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 68, "Friday", true, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 67, "Friday", true, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 77, "Friday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 66, "Friday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 64, "Thursday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 63, "Thursday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 62, "Thursday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 61, "Thursday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 60, "Thursday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 59, "Thursday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 58, "Thursday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 57, "Thursday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 56, "Thursday", true, "11:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 55, "Thursday", true, "10:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 65, "Thursday", true, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 54, "Thursday", true, "9:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 78, "Friday", true, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 80, "Saturday", true, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 102, "Sunday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 101, "Sunday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 100, "Sunday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 99, "Sunday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 98, "Sunday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 97, "Sunday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 96, "Sunday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 95, "Sunday", true, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 94, "Sunday", true, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 93, "Sunday", true, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 79, "Saturday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 92, "Sunday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 90, "Saturday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 89, "Saturday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 88, "Saturday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 87, "Saturday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 86, "Saturday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 85, "Saturday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 84, "Saturday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 83, "Saturday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 82, "Saturday", true, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 81, "Saturday", true, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 91, "Saturday", true, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 53, "Thursday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 52, "Thursday", true, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 51, "Thursday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 23, "Tuesday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 22, "Tuesday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 21, "Tuesday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 20, "Tuesday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 19, "Tuesday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 18, "Tuesday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 17, "Tuesday", true, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 16, "Tuesday", true, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 15, "Tuesday", true, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 14, "Tuesday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 24, "Tuesday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 13, "Monday", true, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 11, "Monday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 10, "Monday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 9, "Monday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 8, "Monday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 7, "Monday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 6, "Monday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 5, "Monday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 4, "Monday", true, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 3, "Monday", true, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 2, "Monday", true, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 12, "Monday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 25, "Tuesday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 26, "Tuesday", true, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 27, "Wednesday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 50, "Thursday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 49, "Thursday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 48, "Thursday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 47, "Thursday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 46, "Thursday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 45, "Thursday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 44, "Thursday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 43, "Thursday", true, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 42, "Thursday", true, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 41, "Thursday", true, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 40, "Thursday", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 39, "Wednesday", true, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 38, "Wednesday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 37, "Wednesday", true, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 36, "Wednesday", true, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 35, "Wednesday", true, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 34, "Wednesday", true, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 33, "Wednesday", true, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 32, "Wednesday", true, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 31, "Wednesday", true, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 30, "Wednesday", true, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 29, "Wednesday", true, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 28, "Wednesday", true, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 103, "Sunday", true, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeId", "Day", "IsAvailable", "Time" },
                values: new object[] { 104, "Sunday", true, "8:00 PM" });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TimeSlotTimeId",
                table: "Tours",
                column: "TimeSlotTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}
