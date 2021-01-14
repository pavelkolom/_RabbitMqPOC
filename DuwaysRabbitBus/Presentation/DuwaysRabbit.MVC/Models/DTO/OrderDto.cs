
using System.ComponentModel.DataAnnotations.Schema;

namespace DuwaysRabit.MVC.Models.DTO
{

    /**
     * Order Dto class
     * 
     * This class holds the same properties from the Account Order class for 
     * the Checkout controller.

     */
    public class OrderDto
    {
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public decimal Amount { get; set; }
    }
}
