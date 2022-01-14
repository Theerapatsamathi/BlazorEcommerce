using BlazorMCIC.Shared;
using System.Collections.Generic;

namespace BlazorMCIC.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
