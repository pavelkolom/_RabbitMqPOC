
using System.ComponentModel.DataAnnotations.Schema;

namespace DuwaysRabbitBus.Ordering.Domain.Models
{
    /**
     * Transfer Log class
     */
    public class OrderingLog
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int AccountId {get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get;  set; }
    }
}
