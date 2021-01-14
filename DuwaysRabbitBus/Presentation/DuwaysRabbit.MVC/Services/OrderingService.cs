using System.Net.Http;
using System.Threading.Tasks;
using DuwaysRabit.MVC.Models.DTO;
using Newtonsoft.Json;

namespace DuwaysRabit.MVC.Services
{
  /**
   * Order Service class
   * 
   * Local proxy checkout service.

   */
  public class OrderingService : IOrderingService
  {
    private readonly HttpClient _apiClient;

    public OrderingService(HttpClient apiClient)
    {
      _apiClient = apiClient;
    }

    public async Task Order(OrderDto orderDto)
    {
      var uri = "https://localhost:44331/api/Checkout";
      var orderContent = new StringContent(JsonConvert.SerializeObject(orderDto),
                                      System.Text.Encoding.UTF8, "application/json");
      var response = await _apiClient.PostAsync(uri, orderContent);
      //var response = await _apiClient.GetAsync(uri);
      response.EnsureSuccessStatusCode();
    }
  }
}
