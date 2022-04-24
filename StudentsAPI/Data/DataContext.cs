using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models;
using System.Data;

namespace StudentsAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<FavoriteFood> FavoriteFoods { get; set; }
        public DbSet<FavoriteMusic> FavoriteMusics { get; set; }
        public DbSet<FavoritePlace> FavoritePlaces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FullName = "David Nguyen",
                    BirthDate = new System.DateTime(1999, 3, 31),
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Sophomore"
                },
                new Student
                {
                    Id = 2,
                    FullName = "John Doe",
                    BirthDate = new System.DateTime(1980, 4, 1),
                    CollegeProgram = "Business",
                    YearInProgram = "Sophomore"
                },
                new Student
                {
                    Id = 3,
                    FullName = "Jane Doe",
                    BirthDate = new System.DateTime(2000, 8, 16),
                    CollegeProgram = "Business",
                    YearInProgram = "Junior"
                },
                new Student
                {
                    Id = 4,
                    FullName = "Amber Willis",
                    BirthDate = new System.DateTime(2002, 1, 12),
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Sophomore"
                },
                new Student
                {
                    Id = 5,
                    FullName = "Jenna Wasilko",
                    BirthDate = new System.DateTime(2002, 2, 5),
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Sophomore"
                }
            );

            modelBuilder.Entity<FavoriteFood>().HasData(
                new FavoriteFood
                {
                    Id = 1,
                    Name = "Pho",
                    Origin = "Vietnamese",
                    GlutenFree = false,
                    Vegan = false
                },  
                new FavoriteFood
                {
                    Id = 2,
                    Name = "Waffles",
                    Origin = "Belgia",
                    GlutenFree = false,
                    Vegan = false
                },
                new FavoriteFood
                {
                    Id = 3,
                    Name = "Pizza",
                    Origin = "Italia",
                    GlutenFree = false,
                    Vegan = false
                },
                new FavoriteFood
                {
                    Id = 4,
                    Name = "Doughnuts",
                    Origin = "Dutch",
                    GlutenFree = false,
                    Vegan = false
                },
                  new FavoriteFood
                {
                    Id = 5,
                    Name = "Pasta",
                    Origin = "Asian",
                    GlutenFree = false,
                    Vegan = true
                }
                
            );

            modelBuilder.Entity<FavoriteMusic>().HasData(
                new FavoriteMusic
                {
                    Id = 1,
                    Genre = "Pop",
                    FavoriteSong = "Natural - Imagine Dragons",
                    FavoriteAlbum = "PSY - 4x2=8",
                    FavoriteArtist = "NF - Nathan John Feuerstein",
                    FavoriteBand = "Imagine Dragons"
                },
                new FavoriteMusic
                {
                    Id = 2,
                    Genre = "Pop",
                    FavoriteSong = "Frank Sinatra - My Way",
                    FavoriteAlbum = "Stevie Wonder - Songs In The Key Of Life",
                    FavoriteArtist = "George Michael",
                    FavoriteBand = "ABBA"
                },
                new FavoriteMusic
                {
                    Id = 3,
                    Genre = "Rock",
                    FavoriteSong = "Guns N’ Roses – Paradise City,",
                    FavoriteAlbum = "Guns N’ Roses – Appetite for Destruction",
                    FavoriteArtist = "Bob Dylan",
                    FavoriteBand = "Guns N' Roses"
                },
                new FavoriteMusic
                {
                    Id = 4,
                    Genre = "Pop",
                    FavoriteSong = "John Mayer - Wild Blue",
                    FavoriteAlbum = "AJR - Neotheater",
                    FavoriteArtist = "Ben Platt",
                    FavoriteBand = "Glass Animals"
                },
                new FavoriteMusic
                {
                    Id = 5,
                    Genre = "Pop",
                    FavoriteSong = "blackbear - halfalive",
                    FavoriteAlbum = "Amine - ONEPOINTFIVE",
                    FavoriteArtist = "Baby Keem",
                    FavoriteBand = "One Direction"
                }
            );

            modelBuilder.Entity<FavoritePlace>().HasData(
                new FavoritePlace
                {
                    Id = 1,
                    Name = "The Great Pyramid of Giza",
                    City = "Giza",
                    Country = "Egypt",
                    Description = "The largest ancient structure in the world.",
                    MustVisit = true,
                    Visited = false
                },
                new FavoritePlace
                {
                    Id = 2,
                    Name = "The Louvre",
                    City = "Paris",
                    Country = "France",
                    Description = "The world's largest art museum.",
                    MustVisit = true,
                    Visited = true
                },
                new FavoritePlace
                {
                    Id = 3,
                    Name = "Burj Khalifa",
                    City = " Dubai",
                    Country = "United Arab Emirates",
                    Description = "The world’s tallest building.",
                    MustVisit = true,
                    Visited = false
                },
                new FavoritePlace
                {
                    Id = 4,
                    Name = "The Bean",
                    City = "Chicago",
                    Country = "United States",
                    Description = "Reflective Sculpture.",
                    MustVisit = true,
                    Visited = true
                },
                new FavoritePlace
                {
                    Id = 5,
                    Name = "Empire State Building",
                    City = "New York",
                    Country = "United States",
                    Description = "A historical landmark",
                    MustVisit = true,
                    Visited = true
                }
            );
        }

    }
}
