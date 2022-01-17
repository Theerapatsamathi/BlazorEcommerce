using BlazorMCIC.Server.Services.CategoryService;
using BlazorMCIC.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMCIC.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<List<Product>> GetAllProduct()
        {
            return Products;
        }
        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public async Task<Product> GetProductById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> Products { get; set; } = new List<Product> {
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
