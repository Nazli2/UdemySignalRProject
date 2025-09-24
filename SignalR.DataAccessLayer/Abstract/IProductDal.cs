using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract;
public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetProductsWithCategories();
     int ProductCount();
    int ProductCountByCategoryNameSalatalar();
    int ProductCountByCategoryNameTatlılar();
    decimal ProductPriceAvg();
    string ProductNameByMaxPrice();
    string ProductNameByMinPrice();
    decimal ProductAvgPriceBySalatalar();
}
