
using System.ComponentModel.DataAnnotations.Schema;

namespace DuwaysRabit.MVC.Models
{

    /**
     * Order View Model class
     * 
     */
    public class OrderViewModel
    {
        public string OrderNotes { get; set; }
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public decimal Amount { get; set; }
    }
}
