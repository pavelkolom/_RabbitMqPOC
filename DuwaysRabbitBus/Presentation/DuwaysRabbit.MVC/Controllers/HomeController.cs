using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DuwaysRabit.MVC.Models;
using DuwaysRabit.MVC.Services;
using DuwaysRabit.MVC.Models.DTO;

namespace DuwaysRabit.MVC.Controllers
{
  /**
   * Home api controller
   * 
   */
  public class HomeController : Controller
  {
    private readonly IOrderingService _orderService;

    public HomeController(IOrderingService orderService)
    {
      _orderService = orderService;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public async Task<IActionResult> Order(OrderViewModel model)
    {
      OrderDto orderDto = new OrderDto()
      {
        AccountId = model.AccountId,
        CourseId = model.CourseId,
        Amount = model.Amount
      };

      await _orderService.Order(orderDto);

      return View("Index");
    }
  }
}
