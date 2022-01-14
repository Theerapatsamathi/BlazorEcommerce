using BlazorMCIC.Shared;
using System.Collections.Generic;

namespace BlazorMCIC.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; }

        public void LoadProducts()
        {
            Products = new List<Product> {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Title = "Thee Gitchi",
                Description = "IIIIIIIIIIIIIIIIIII",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
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
            },


            };
        }
    }
}
