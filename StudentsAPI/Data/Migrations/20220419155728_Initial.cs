using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsAPI.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteFoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    GlutenFree = table.Column<bool>(nullable: false),
                    Vegan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteMusics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Genre = table.Column<string>(nullable: true),
                    FavoriteSong = table.Column<string>(nullable: true),
                    FavoriteArtist = table.Column<string>(nullable: true),
                    FavoriteBand = table.Column<string>(nullable: true),
                    FavoriteAlbum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteMusics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoritePlaces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MustVisit = table.Column<bool>(nullable: false),
                    Visited = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritePlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    CollegeProgram = table.Column<string>(nullable: true),
                    YearInProgram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "GlutenFree", "Name", "Origin", "Vegan" },
                values: new object[] { 1, false, "Pho", "Vietnamese", false });

            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "GlutenFree", "Name", "Origin", "Vegan" },
                values: new object[] { 2, false, "Waffles", "Belgia", false });

            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "GlutenFree", "Name", "Origin", "Vegan" },
                values: new object[] { 3, false, "Pizza", "Italia", false });
                
            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "GlutenFree", "Name", "Origin", "Vegan" },
                values: new object[] { 4, false, "Doughnuts", "Dutch", false });

            migrationBuilder.InsertData(
                table: "FavoriteMusics",
                columns: new[] { "Id", "FavoriteAlbum", "FavoriteArtist", "FavoriteBand", "FavoriteSong", "Genre" },
                values: new object[] { 1, "PSY - 4x2=8", "NF - Nathan John Feuerstein", "Imagine Dragons", "Natural - Imagine Dragons", "Pop" });

            migrationBuilder.InsertData(
                table: "FavoriteMusics",
                columns: new[] { "Id", "FavoriteAlbum", "FavoriteArtist", "FavoriteBand", "FavoriteSong", "Genre" },
                values: new object[] { 2, "Stevie Wonder - Songs In The Key Of Life", "George Michael", "ABBA", "Frank Sinatra - My Way", "Pop" });

            migrationBuilder.InsertData(
                table: "FavoriteMusics",
                columns: new[] { "Id", "FavoriteAlbum", "FavoriteArtist", "FavoriteBand", "FavoriteSong", "Genre" },
                values: new object[] { 3, "Guns N’ Roses – Appetite for Destruction", "Bob Dylan", "Guns N' Roses", "Guns N’ Roses – Paradise City,", "Rock" });

            migrationBuilder.InsertData(
                table: "FavoriteMusics",
                columns: new[] { "Id", "FavoriteAlbum", "FavoriteArtist", "FavoriteBand", "FavoriteSong", "Genre" },
                values: new object[] { 4, "AJR - Neotheater", "Ben Platt", "Glass Animals", "John Mayer - Wild Blue", "Pop" });

            migrationBuilder.InsertData(
                table: "FavoritePlaces",
                columns: new[] { "Id", "City", "Country", "Description", "MustVisit", "Name", "Visited" },
                values: new object[] { 1, "Giza", "Egypt", "The largest ancient structure in the world.", true, "The Great Pyramid of Giza", false });

            migrationBuilder.InsertData(
                table: "FavoritePlaces",
                columns: new[] { "Id", "City", "Country", "Description", "MustVisit", "Name", "Visited" },
                values: new object[] { 2, "Paris", "France", "The world's largest art museum.", true, "The Louvre", true });

            migrationBuilder.InsertData(
                table: "FavoritePlaces",
                columns: new[] { "Id", "City", "Country", "Description", "MustVisit", "Name", "Visited" },
                values: new object[] { 3, " Dubai", "United Arab Emirates", "The world’s tallest building.", true, "Burj Khalifa", false });

            migrationBuilder.InsertData(
                table: "FavoritePlaces",
                columns: new[] { "Id", "City", "Country", "Description", "MustVisit", "Name", "Visited" },
                values: new object[] { 4, "Chicago", "United States", "Reflective Sculpture.", true, "The Bean", true });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 1, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "David Nguyen", "Sophomore" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 2, new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business", "John Doe", "Sophomore" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 3, new DateTime(2000, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business", "Jane Doe", "Junior" });
        
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 4, new DateTime(2002, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Amber Willis", "Sophomore" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteFoods");

            migrationBuilder.DropTable(
                name: "FavoriteMusics");

            migrationBuilder.DropTable(
                name: "FavoritePlaces");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
