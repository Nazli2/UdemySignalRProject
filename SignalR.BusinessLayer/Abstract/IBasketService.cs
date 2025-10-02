using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract;
public interface IBasketService : IGenericService<Basket>
{
    List<Basket> TGetBaketByMenuTableNumber(int id);
}
