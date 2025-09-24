using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract;
public interface IProductService : IGenericService<Product>
{
    List<Product> TGetProductsWithCategories();
    int TProductCount();
    int TProductCountByCategoryNameSalatalar();
    int TProductCountByCategoryNameTatlılar();
    decimal TProductPriceAvg();
    string TProductNameByMaxPrice();
    string TProductNameByMinPrice();
    decimal TProductAvgPriceBySalatalar();
}
