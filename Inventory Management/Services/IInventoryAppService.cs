namespace Inventory_Management.InventoryApp
{
    public interface IInventoryAppService
    {
        Task<List<NewProductsType>> GetNewProducts();

        Task<List<ProductsType>> GetProducts();
    }
}