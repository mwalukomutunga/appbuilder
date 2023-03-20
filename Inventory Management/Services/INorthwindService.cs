namespace Inventory_Management.Northwind
{
    public interface INorthwindService
    {
        Task<List<OrdersType>> GetOrders();
    }
}