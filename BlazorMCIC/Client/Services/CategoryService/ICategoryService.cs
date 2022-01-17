using BlazorMCIC.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMCIC.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
