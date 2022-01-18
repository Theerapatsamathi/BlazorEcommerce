using BlazorMCIC.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorMCIC.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                      new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                        new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                         new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     CategoryId = 1,
                     Title = "Thee Gitchi",
                     Description = "IIIIIIIIIIIIIIIIIII",
                     Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                     Price = 9.99m,
                     OriginalPrice = 19.99m,
                     DateCreated = new System.DateTime(2021, 1, 1)
                 },
            new Product
            {
                Id = 2,
                CategoryId = 2,
                Title = "Thee IPSSSSS",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                DateCreated = new System.DateTime(2021, 1, 1)
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Title = "Thee Gitchi222",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                DateCreated = new System.DateTime(2021, 1, 1)
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Title = "Thee IPSSSSS33",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                DateCreated = new System.DateTime(2021, 1, 1)
            },
            new Product
            {
                Id = 5,
                CategoryId = 1,
                Title = "Thee Gitchi444",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                DateCreated = new System.DateTime(2021, 1, 1)
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Title = "Thee IPSSSSS",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                DateCreated = new System.DateTime(2021, 1, 1)
            },
            new Product
            {
                Id = 7,
                CategoryId = 1,
                Title = "Thee Gitchi",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                DateCreated = new System.DateTime(2021, 1, 1)
            },
            new Product
            {
                Id = 8,
                CategoryId = 3,
                Title = "Thee IPSSSSS",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                DateCreated = new System.DateTime(2021, 1, 1)
            }


                );

            modelBuilder.Entity<Edition>().HasData(
                new Edition {  Id = 1, Name = "Paperback"},
                new Edition {  Id = 2, Name = "E-Book"},
                new Edition {  Id = 3, Name = "Audiobook"},
                new Edition {  Id = 4, Name = "PC"},
                new Edition {  Id = 5, Name = "PlayStation"},
                new Edition {  Id = 6, Name = "Xbox"}

                );
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
                .HasData(
                new {EditionsId = 1, ProductsId = 1 },
                new {EditionsId = 2, ProductsId = 1 },
                new {EditionsId = 3, ProductsId = 1 },
                new {EditionsId = 1, ProductsId = 2 },
                new {EditionsId = 2, ProductsId = 2 },
                new {EditionsId = 4, ProductsId = 7 },
                new {EditionsId = 5, ProductsId = 7 },
                new {EditionsId = 6, ProductsId = 7 }
                );
        }
    }
}
