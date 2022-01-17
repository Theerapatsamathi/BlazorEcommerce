using BlazorMCIC.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMCIC.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProduct();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<Product> GetProductById(int Id);
    }
}
