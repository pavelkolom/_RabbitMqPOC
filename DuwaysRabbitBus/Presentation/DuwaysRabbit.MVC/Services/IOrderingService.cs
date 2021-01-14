using DuwaysRabit.MVC.Models.DTO;
using System.Threading.Tasks;

namespace DuwaysRabit.MVC.Services
{
    /**
    * Order Service interface
    * 
    */
    public interface IOrderingService
    {
        Task Order(OrderDto transferDto);
    }
}
