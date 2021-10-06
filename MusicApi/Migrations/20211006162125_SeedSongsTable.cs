using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicApi.Migrations
{
    public partial class SeedSongsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "Language", "Title" },
                values: new object[] { 1, "11:20", "English", "November Rain" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "Language", "Title" },
                values: new object[] { 2, "3:25", "Español", "Laura" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
