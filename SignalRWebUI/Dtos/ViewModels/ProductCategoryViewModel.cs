using SignalRWebUI.Dtos.CategoryDtos;
using SignalRWebUI.Dtos.ProductDtos;

namespace SignalRWebUI.Dtos.ViewModels;

public class ProductCategoryViewModel
{
    public List<ResultProductWithCategoriesDto> Product { get; set; }
    public List<ResultCategoryDto> Category { get; set; }
}
