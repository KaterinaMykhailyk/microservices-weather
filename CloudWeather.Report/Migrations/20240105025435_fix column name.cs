using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudWeather.Report.Migrations
{
    /// <inheritdoc />
    public partial class fixcolumnname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShowTotalInches",
                table: "weather_report",
                newName: "SnowTotalInches");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SnowTotalInches",
                table: "weather_report",
                newName: "ShowTotalInches");
        }
    }
}
