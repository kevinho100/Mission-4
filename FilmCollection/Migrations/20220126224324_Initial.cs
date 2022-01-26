using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LenTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LenTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Jon Watts", false, "", "Best movie of 2022", "PG-13", "Spider-Man: No way home", 2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LenTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Kevin Feige", false, "", "Best movie of 2019", "PG-13", "Avengers:Endgame", 2019 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LenTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Jon Watts", false, "", "Best movie of 2018", "PG-13", "Avengers:Infinity War", 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
