using System.Net.Http.Json;

namespace Inventory_Management.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<OrdersType>> GetOrders()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-orders.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrdersType>>().ConfigureAwait(false);
            }

            return new List<OrdersType>();
        }
    }
}