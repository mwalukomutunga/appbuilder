namespace Inventory_Management.ECommerce
{
    public interface IECommerceService
    {
        Task<List<SalesType>> GetSales();

        Task<List<RevenueType>> GetRevenue();
    }
}